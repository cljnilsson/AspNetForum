using System;
namespace Model
{
	public class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public string Country { get; set; }
		public int Age { get; set; }
		public int posts {get; set; }
		public string Rank { get; set; } //replace with id/model for rank permissions in the future
		public DateTime lastLogin {get; set;}
		public DateTime created {get; set;}

		public User() {
			Rank 		= "User";
			Age 		= -1;
			Gender 		= "Unspecified";
			created		= DateTime.Now;
			lastLogin 	= DateTime.Now;
			posts 		= 0;
		}
	}
}