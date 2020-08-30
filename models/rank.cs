using System;
namespace Model
{
	public class Rank
	{
		public int id { get; set; }
		public string name { get; set; }

		public Boolean edit { get; set; }
		public Boolean post { get; set; } // meant as some sort of mute maybe?
		public Boolean delete { get; set; }
		public Boolean controlPanel { get; set; }
	}
}