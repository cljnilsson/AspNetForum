using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using LoremNET;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Extensions;
using Hash;

public class DB : DbContext
  {
    public MySqlConnection Connection;

	public DbSet<Section> Sections {get; set;}
	public DbSet<Thread> Threads {get; set;}
	public DbSet<Post> Posts {get; set;}
	public DbSet<User> Users {get; set;}
	public DbSet<ProfilePost> ProfilePosts {get; set;}
	public DbSet<ProfilePostComment> ProfilePostComments {get; set;}


	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
   		optionsBuilder.UseMySQL("server=localhost;database=forum;uid=root;password=;"); //Fix this at some point, not good practice for security reasons
	}

	public List<Post> searchPosts(String q) {
		var list = new List<Post>();

		foreach(var p in Posts.Include(w => w.thread).ToList()) {
			if(p.post.Contains(q)) {
				list.Add(p);
			}
		}

		return list;
	}

	public User GetRandomUser() {
		return Users.ToList().Random();
	}

	public void AddToPostCountOfUser(string username) {
		var u = Users.Where(u => u.Username == username).First();
		u.posts++;
		SaveChanges();
	}
	public async void populateSections()
	{
		if (await Sections.AnyAsync())
		{
			return; // DB has been seeded
		}

		var sections = new Section[] {
			new Section{Name = "Gaming" 		, Image = "gaming.png" 		, description = "Talk about any game"},
			new Section{Name = "News"   		, Image = "news.png"   		, description = "Post news here and share your views on them!"},
			new Section{Name = "Software"  		, Image = "wrench.png"  	, description = "Discuess software here!"},
			new Section{Name = "Hardware"  	 	, Image = "cogs.png"   		, description = "Post about anything hardware"},
			new Section{Name = "Nature"   		, Image = "nature.png"   	, description = "Post beutriful pictures of nature and talk about locations you would like to visit"},
			new Section{Name = "Craftmanship"	, Image = "crafting.png"   	, description = "How off your creations and build projects here, or ask for advice"},
			new Section{Name = "Art"			, Image = "art.png"   		, description = "Drawings, textures or similar can be shared here and discuessed here!"},
			new Section{Name = "Music"			, Image = "music.png"   	, description = "Talk about music, or share your own"},
			new Section{Name = "Books"   		, Image = "books.png"   	, description = "Share your thoughts about books you've read, or are writing"},
			new Section{Name = "Off Topic"		, Image = "offtopic.png"   	, description = "Talk about anything random here"}
		};

		Sections.AddRange(sections);
		SaveChanges();
	}

	public void populateUsers() {
		var demousers = new List<User>();
		foreach(var i in Enumerable.Range(0, 20)) {
			var username = Lorem.Email();
			demousers.Add(new User{Username = username, Password = "", Email = username});
		}

		Users.AddRange(demousers);
		SaveChanges();

		CreateUser("admin", "admin", "");
	}

	public void populateThreads()
	{
		var threads = new List<Thread>();
		var rnd = new Random();

		foreach (var i in Enumerable.Range(0, 40))
		{
			var test = Sections.ToList().Random();
			var username = GetRandomUser().Username;
			AddToPostCountOfUser(username);
			threads.Add(new Thread{author = username , name = Lorem.Words(2,5), post = LoremNET.Lorem.Paragraph(4, 20, 3, 10), section = test});
		}

		Threads.AddRange(threads);
		SaveChanges();
	}

	public void populatePosts() {
		var posts = new List<Post>();

		foreach(var i in Enumerable.Range(0, 140)) {
			var test = Threads.ToList().Random();
			var username = GetRandomUser().Username;
			AddToPostCountOfUser(username);
			posts.Add(new Post{author = username, post = LoremNET.Lorem.Paragraph(4, 20, 3, 10), thread = test});
		}

		Posts.AddRange(posts);
		SaveChanges();
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Section>().ToTable("Section");
	}

	public List<Section> GetAllSections()  
	{  	
		return Sections.ToList();
	}

	public List<Thread> GetThreadsFromSection(string section)  
	{  
		var s = Sections.Where(s => s.Name == section).First();
		return Threads.Where(b => b.section == s).ToList();
	}

	public List<ProfilePostComment> GetCommentsOnProfilePost(ProfilePost pp)  
	{  
		var s = ProfilePostComments.Where(pc => pc.parent == pp).ToList();
		return s;
	}

	public User GetUserByName(string s) {
		return Users.Where(u => u.Username == s).FirstOrDefault();
	}

	public ProfilePost GetProfilePostById(int i) {
		return ProfilePosts.Where(p => p.id == i).FirstOrDefault();
	}

	public ProfilePostComment GetProfilePostCommentById(int i) {
		return ProfilePostComments.Where(p => p.id == i).FirstOrDefault();
	}

	public Thread GetThread(int id) {
		return Threads.Where(t => t.id == id).First();
	}

	public List<Post> GetPostsInThread(int id) {
		return Posts.Where(t => t.thread == GetThread(id)).ToList();
	}

	public void updateLastLogin(String username) {
		var u = GetUserByName(username);
		u.lastLogin = DateTime.Now;
		SaveChanges();
	}

	public List<Post> GetLatestPostsByUser(string username, int i) {
		var u = GetUserByName(username);
		var list = Posts.Where(p => p.author == username).Take(i).ToList();
		return list;
	}

	public void CreateUser(string username, string password, string email) {
		string hashed = Hash.SecurePasswordHasher.Hash(password);
		Users.Add(new User{Email = email, Username = username, Password = hashed});
		SaveChanges();
	}

	public bool UserExist(string username) {
		return Users.Where(u => u.Username == username).ToList().Count > 0;
	}

	public bool Login(string username, string password) {
		var user = Users.Where(u => u.Username == username).FirstOrDefault();
		if(user != null && Hash.SecurePasswordHasher.Verify(password, user.Password)) {
			return true;
		} else {
			return false;
		}
	}

	public void makeThread(string thread, string post, string user, string section) {
		var s = Sections.Where(s => s.Name == section).FirstOrDefault();
		Threads.Add(new Thread{name = thread, post = post, author = user, section = s});
		SaveChanges();
	}

	public List<ProfilePost> GetPostsOnProfile(User u) {
		var list = ProfilePosts.Where(pp => pp.u == u).Include(c => c.author).ToList();
		list.Reverse();
		return list;
	}
	 
	public void makeProfilePost(string post, String on, String author) {
		var profileOwner 	= GetUserByName(on);
		var msgAuthor		= GetUserByName(author);

		ProfilePosts.Add(new ProfilePost{post = post, u = profileOwner, author = msgAuthor});
		SaveChanges();
	}

	public void makeProfilePostComment(string post, String author, int id) {
		var msgAuthor	= GetUserByName(author);
		var msgParent 	= GetProfilePostById(id); 

		ProfilePostComments.Add(new ProfilePostComment{post = post, parent = msgParent, author = msgAuthor});
		SaveChanges();
	}

	public void editProfilePost(int id, String msg) {
		var msgParent 	= GetProfilePostById(id);

		msgParent.post = msg;
		SaveChanges();
	}

	public void editProfilePostComment(int id, String msg) {
		var msgParent 	= GetProfilePostCommentById(id);

		msgParent.post = msg;
		SaveChanges();
	}

	public void deleteProfilePost(int id) {
		var comments = ProfilePostComments.Where(c => c.parent.id == id).ToList();
		RemoveRange(comments);
		Remove(GetProfilePostById(id));
		SaveChanges();
	}

	public void deleteProfilePostComment(int id) {
		var comment = GetProfilePostCommentById(id);
		Remove(comment);
		SaveChanges();
	}
}