using System;
using System.Collections.Generic;
namespace Extensions {
	public static class Extensions {
		private static Random rng = new Random();
		public static T Random<T>(this List<T> l) {
			return l[rng.Next(l.Count)];
		}

		public static T Last<T>(this List<T> l) {
			return l[l.Count - 1];
		}
	}
}