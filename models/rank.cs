using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
	public class Rank
	{
		public int id 				{ get; set; }
		[Required]
		public string name 			{ get; set; }
		public Boolean edit 		{ get; set; }
		public Boolean post 		{ get; set; }
		public Boolean delete 		{ get; set; }
		public Boolean controlPanel { get; set; }
		public Boolean permanent 	{ get; set; }
		[Required]
		public string color 		{ get; set; }

		public Rank()  {
			permanent = false;
		}
	}
}