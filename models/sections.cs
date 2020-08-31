using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
	public class Section
	{
		public int Id 				{ get; set; }
		public string Name 			{ get; set; }
		public string description 	{ get; set; }
		public string Image 		{ get; set; }
		
		[NotMapped] //Does not add field to DB
		public DateTime latest 		{ get; set; }
		[NotMapped]
		public User latestSource	{ get; set; }
		[NotMapped]
		public string latestThread	{ get; set; }
	}
}