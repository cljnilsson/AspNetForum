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

	public void populateThreads()
	{
		var threads = new List<Thread>();
		var rnd = new Random();

		foreach (var i in Enumerable.Range(0, 20))
		{
			var test = Sections.ToList().Random();
			threads.Add(new Thread{author = Lorem.Email() , name = Lorem.Words(2,5), post = LoremNET.Lorem.Paragraph(4, 20, 3, 10), section = test});
		}

		Threads.AddRange(threads);
		SaveChanges();
	}

	public void populatePosts() {
		var sections = new List<Post>();

		foreach(var i in Enumerable.Range(0, 120)) {
			var test = Threads.ToList().Random();
			sections.Add(new Post{author = Lorem.Email(), post = LoremNET.Lorem.Paragraph(4, 20, 3, 10), thread = test});
		}

		Posts.AddRange(sections);
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

	public Thread GetThread(int id) {
		return Threads.Where(t => t.id == id).First();
	}

	public List<Post> GetPostsInThread(int id) {
		return Posts.Where(t => t.thread == GetThread(id)).ToList();
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
}