using System;
namespace Model
{
	public class ProfilePostComment
	{
		public int id 				{ get; set; }
		public User author 			{ get; set; }
		public string post 			{ get; set; }
		public ProfilePost parent 	{ get; set; }
		public DateTime date 		{ get; set; }

		public ProfilePostComment() {
			date = DateTime.Now;
		}
	}
}