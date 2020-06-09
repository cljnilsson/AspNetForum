using System;
using MySql.Data.MySqlClient;
using Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class DB : DbContext
  {
    public MySqlConnection Connection;

	public DbSet<Section> Sections {get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
   		optionsBuilder.UseMySQL("server=localhost;database=forum;uid=root;password=;"); //Fix this at some point, not good practice for security reasons
	}

	public async void populate()
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

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Section>().ToTable("Section");
	}

	public List<Section> GetAllSections()  
	{  
		List<Section> list = new List<Section>();  

		foreach(var s in Sections) {
			list.Add(s);
		}
		
		return list;  
	}
}