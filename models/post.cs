using System;
namespace Model
{
	public class Post
	{
		public int id 			{ get; set; }
		public User author 		{ get; set; }
		public string post 		{ get; set; }
		public Thread thread	{ get; set; }
		public DateTime date 	{ get; set; }

		public Post() {
			date = DateTime.Now;
		}
	}
}