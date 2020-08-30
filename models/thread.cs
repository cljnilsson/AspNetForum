using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
	public class Thread
	{
		public int id { get; set; }

		public User author {get; set;}
		public string name { get; set; }
		public string post { get; set; }
		public Section section { get; set; }
		public int views {get; set; }
		public DateTime date {get; set;}

		[NotMapped] //Does not add field to DB
		public DateTime latest {get; set;}

		[NotMapped]
		public string latestSource{get; set;}

		public Thread() {
			date = DateTime.Now;
		}
	}
}