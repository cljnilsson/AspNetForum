using System;
namespace Model
{
	public class Thread
	{
		public int id { get; set; }

		public string author {get; set;}
		public string name { get; set; }
		public string post { get; set; }
		public Section section { get; set; }
	}
}