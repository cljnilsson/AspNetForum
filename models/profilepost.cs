using System;
namespace Model
{
	public class ProfilePost
	{
		public int id { get; set; }
		public User author { get; set; }
		public string post { get; set; }
		public User u { get; set; }
		public DateTime date {get; set;}

		public ProfilePost() {
			date = DateTime.Now;
		}
	}
}