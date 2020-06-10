using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using LoremNET;
using Microsoft.Extensions.Configuration;
using Extensions;

public class DB : DbContext
  {
    public MySqlConnection Connection;

	public DbSet<Section> Sections {get; set;}
	public DbSet<Thread> Threads {get; set;}
	public DbSet<Post> Posts {get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
   		optionsBuilder.UseMySQL("server=localhost;database=forum;uid=root;password=;"); //Fix this at some point, not good practice for security reasons
	}

     public Guid Random() 
     { // to prove not used by our C# code... 
         throw new NotImplementedException(); 
     }

	public async void populateSections()
	{
		if (await Sections.AnyAsync())
		{
			return; // DB has been seeded
		}

		var sections = new Section[] {
			new Section{Name = "Gaming" 	, Image = "gaming.png" 	, description = "Talk about any game"},
			new Section{Name = "News"   	, Image = "news.png"   	, description = "Post news here and share your views on them!"},
			new Section{Name = "Software"   , Image = "wrench.png"  , description = "Discuess software here!"},
			new Section{Name = "Hardware"   , Image = "cogs.jpg"   	, description = "Post about anything hardware"}
		};

		Sections.AddRange(sections);
		SaveChanges();
	}

	public void populateThreads()
	{
		var threads = new List<Thread>();
		var rnd = new Random();

		foreach (var i in Enumerable.Range(0, 5))
		{
			var test = Sections.ToList().Random();
			threads.Add(new Thread{author = Lorem.Email() , name = Lorem.Words(2,5), post = LoremNET.Lorem.Paragraph(4, 20, 3, 10), section = test});
		}

		Threads.AddRange(threads);
		SaveChanges();
	}

	public void populatePosts() {
		var test = Threads.ToList().Random();
		var sections = new List<Post>();

		foreach(var i in Enumerable.Range(0, 20)) {
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
}