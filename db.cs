using System.Text.RegularExpressions;
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

	public DbSet<Section> 				Sections 			{get; set;}
	public DbSet<Thread> 				Threads 			{get; set;}
	public DbSet<Post> 					Posts 				{get; set;}
	public DbSet<User> 					Users 				{get; set;}
	public DbSet<ProfilePost> 			ProfilePosts 		{get; set;}
	public DbSet<ProfilePostComment> 	ProfilePostComments {get; set;}
	public DbSet<Rank> 					Ranks				{get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
   		optionsBuilder.UseMySQL("server=localhost;database=forum;uid=root;password=;"); //Fix this at some point, not good practice for security reasons
	}

	public List<Post> searchPosts(String q) {
		var list = new List<Post>();

		foreach(var p in Posts.Include(w => w.thread).ThenInclude(t => t.section).Include(p => p.author).ThenInclude(a => a.Rank).ToList()) {
			if(p.post.Contains(q)) {
				list.Add(p);
			}
		}

		return list;
	}

	public User GetRandomUser() {
		return Users.ToList().Random();
	}

	public Rank GetRankByName(string s) {
		return Ranks.Where(r => s == r.name).FirstOrDefault();
	}

	public void AddToPostCountOfUser(string username) {
		var u = Users.Where(u => u.Username == username).First();
		u.posts++;
		SaveChanges();
	}

	public async void populateRanks() {
		if (await Ranks.AnyAsync())
		{
			return; // DB has been seeded
		}

		var ranks = new Rank[] {
			new Rank{name = "Admin" 	, edit = true  , post = true  , delete = true  , lockthread = true, controlPanel = true  , color = "#dc6434" },
			new Rank{name = "Moderator" , edit = true  , post = true  , delete = true  , lockthread = true, controlPanel = false , color = "#34dcaa" },
			new Rank{name = "User" 		, edit = false , post = true  , delete = false , lockthread = false, controlPanel = false , color = "#3490dc" },
			new Rank{name = "Banned" 	, edit = false , post = false , delete = false , lockthread = false, controlPanel = false , color = "#777877" },
		};

		Ranks.AddRange(ranks);
		SaveChanges();

	}

	public async void populateSections()
	{
		if (await Sections.AnyAsync())
		{
			return; // DB has been seeded
		}

		var sections = new List<Section>() {
			new Section{Name = "Gaming" 		, Image = "gaming.png" 		, description = "Talk about any game"},
			new Section{Name = "News"   		, Image = "news.png"   		, description = "Post news here and share your views on them!"},
			new Section{Name = "Software"  		, Image = "wrench.png"  	, description = "Discuess software here!"},
			new Section{Name = "Hardware"  	 	, Image = "cogs.png"   		, description = "Post about anything hardware"},
			new Section{Name = "Nature"   		, Image = "nature.png"   	, description = "Post beutriful pictures of nature and talk about locations you would like to visit"},
			new Section{Name = "Craftmanship"	, Image = "crafting.png"   	, description = "How off your creations and build projects here, or ask for advice"},
			new Section{Name = "Art"			, Image = "art.png"   		, description = "Drawings, textures or similar can be shared here and discuessed here!"},
			new Section{Name = "Music"			, Image = "music.png"   	, description = "Talk about music, or share your own"},
			new Section{Name = "Books"   		, Image = "books.png"   	, description = "Share your thoughts about books you've read, or are writing"},
			new Section{Name = "Off-topic"		, Image = "offtopic.png"   	, description = "Talk about anything random here"}
		};

		sections.Add(new Section{Name = "World of Warcraft" , Image = "wow.png"		, description = "", parent = sections[0]});
		sections.Add(new Section{Name = "Diablo 3" 			, Image = "diablo.png"	, description = "", parent = sections[0]});
		sections.Add(new Section{Name = "Overwatch" 		, Image = "ow.png"		, description = "", parent = sections[0]});

		Sections.AddRange(sections);
		SaveChanges();
	}

	public void populateUsers() {
		var demousers = new List<User>();
		var rank 	  = GetRankByName("User");
		
		foreach(var i in Enumerable.Range(0, 20)) {
			var username = Lorem.Words(1, false) + Lorem.Number(0, 10000);
			var email = Lorem.Email();
			demousers.Add(new User{Username = username, Password = "", Email = email, Rank = rank});
		}

		Users.AddRange(demousers);
		SaveChanges();

		CreateUser ("user" , "user" , "user@random.com");
		CreateMod  ("Mod1" , "mod"  , "mod@admin.com");
		CreateMod  ("Mod2" , "mod"  , "mod@admin.com");
		CreateAdmin("admin", "admin", "admin@admin.com"); // Default admin account
	}

	public void populateThreads()
	{
		var threads = new List<Thread>();
		var rnd = new Random();

		foreach (var i in Enumerable.Range(0, 40))
		{
			var test = Sections.ToList().Random();
			var user = GetRandomUser();
			AddToPostCountOfUser(user.Username);
			threads.Add(new Thread{author = user , name = Lorem.Words(2,5), post = LoremNET.Lorem.Paragraph(4, 20, 3, 10), section = test});
		}

		Threads.AddRange(threads);
		SaveChanges();
	}

	public void populatePosts() {
		var posts = new List<Post>();

		foreach(var i in Enumerable.Range(30, 140)) {
			var test = Threads.ToList().Random();
			var user = GetRandomUser();
			AddToPostCountOfUser(user.Username);
			posts.Add(new Post{author = user, post = LoremNET.Lorem.Paragraph(4, 20, 3, 10), thread = test});
		}

		Posts.AddRange(posts);
		SaveChanges();
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Section>().ToTable("Section");
	}

	public Section GetSection(string name)  
	{  	
		return Sections.Where(s => s.Name == name).First();
	}

	public List<Section> GetAllSections()  
	{  	
		return Sections.Where(s => s.parent == null).ToList();
	}

	public List<Section> GetAllSectionsOfSection(Section sec)  
	{  	
		return Sections.Where(s => s.parent == sec).ToList();
	}
	public List<Rank> GetAllRanks()  
	{  	
		return Ranks.ToList();
	}

	public List<User> GetAllUsers()  
	{  	
		return Users.ToList();
	}

	public List<User> GetAllUsersWithRank()  
	{  	
		return Users.Include(u => u.Rank).ToList();
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

	public void UpdateUserAvatar(string user, string filename) {
		var u = GetUserByName(user);
		u.avatar = filename;
		SaveChanges();
	}

	public User GetUserByName(string s) {
		return Users.Where(u => u.Username == s).FirstOrDefault();
	}

	public User GetUserByNameWithRank(string s) {
		return Users.Where(u => u.Username == s).Include(u => u.Rank).FirstOrDefault();
	}

	public ProfilePost GetProfilePostById(int i) {
		return ProfilePosts.Where(p => p.id == i).FirstOrDefault();
	}

	public ProfilePostComment GetProfilePostCommentById(int i) {
		return ProfilePostComments.Where(p => p.id == i).FirstOrDefault();
	}

	public Thread GetThread(int id) {
		return Threads.Where(t => t.id == id).Include(c => c.author).ThenInclude(author => author.Rank).First();
	}

	public List<Post> GetPostsInThread(int id) {
		return Posts.Where(t => t.thread == GetThread(id)).Include(c => c.author).ThenInclude(a => a.Rank).ToList();
	}

	public Post GetPostById(int id) {
		return Posts.Where(p => p.id == id).First();
	}

	public Post GetPostByIdWithAuthor(int id) {
		return Posts.Where(p => p.id == id).Include(p => p.author).First();
	}

	public void updateLastLogin(String username) {
		var u = GetUserByName(username);
		u.lastLogin = DateTime.Now;
		SaveChanges();
	}

	public List<Post> GetLatestPostsByUser(string username, int i) {
		var u = GetUserByName(username);
		var list = Posts.Where(p => p.author.Username == username).Take(i).ToList();
		return list;
	}

	private void CreateUser(string username, string password, string email, Rank r) {
		string hashed = Hash.SecurePasswordHasher.Hash(password);
		Users.Add(new User{Email = email, Username = username, Password = hashed, Rank = r});
		SaveChanges();
	}
	public void CreateUser(string username, string password, string email) {
		CreateUser(username, password, email, GetRankByName("User"));
	}

	public void CreateMod(string username, string password, string email) {
		CreateUser(username, password, email, GetRankByName("Moderator"));
	}

	public void CreateAdmin(string username, string password, string email) {
		CreateUser(username, password, email, GetRankByName("Admin"));
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

	public void makeThreadPost(int thread, string post, string user) {
		var t = GetThread(thread); 
		var u = GetUserByName(user);

		AddToPostCountOfUser(u.Username);
		var p = new Post{author = u, post = post, thread = t};
		
		Posts.Add(p);
		SaveChanges();
	}

	public void makeThread(string thread, string post, string user, string section) {
		var s = Sections.Where(s => s.Name == section).FirstOrDefault();
		Threads.Add(new Thread{name = thread, post = post, author = GetUserByName(user), section = s});
		SaveChanges();
	}

	public void copyRank(string rank) {
		var r = GetRankByName(rank);
		Ranks.Add(new Rank{name = r.name + " copy", edit = r.edit, post = r.post, delete = r.delete, controlPanel = r.controlPanel, color = r.color});
		SaveChanges();
	}

	public void deleteRank(string rank) {
		var r = GetRankByName(rank);
		Remove(r);
		SaveChanges();
	}

	public void deleteThreadPost(int id) {
		var p = Posts.Where(p => p.id == id).Include(p => p.author).First();
		var u = p.author;
		u.posts--;
		Remove(p);
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