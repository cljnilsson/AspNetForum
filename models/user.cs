using System;
using System.ComponentModel.DataAnnotations;
namespace Model
{
	public class User
	{
		public int Id { get; set; }

		[Required]
		public string Username 		{ get; set; }
		public string Password 		{ get; set; }
		public string Email 		{ get; set; }
		public string Gender 		{ get; set; }
		public string Country 		{ get; set; }
		public int Age 				{ get; set; }
		public string avatar 		{ get; set; }
		public int posts 			{ get; set; }
		[Required]
		public Rank Rank 			{ get; set; }
		public DateTime lastLogin 	{ get; set; }
		public DateTime created 	{ get; set; }

		public User() {
			Age 		= -1;
			Gender 		= "Unspecified";
			created		= DateTime.Now;
			lastLogin 	= DateTime.Now;
			posts 		= 0;
			avatar 		= "default-avatar.png";
		}
	}
}