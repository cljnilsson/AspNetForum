    using System;
	using System.Collections.Generic;
	using Microsoft.AspNetCore.Mvc.RazorPages;
	using System.Linq;
	using Microsoft.Extensions.Logging;
	using Extensions;

	using Model;

	public class SectionModel : PageModel
    {
		public List<Thread> threads;
		public List<Section> subsections;
		public Dictionary<Thread, int> comments = new Dictionary<Thread, int>();
		private DB db = new DB();
        public void OnGet(string sec)
        {
			var current = db.GetSection(sec);
			subsections = db.GetAllSectionsOfSection(current);

			threads = db.GetThreadsFromSection(sec);
			foreach(var t in threads) {
				var posts 	= db.GetPostsInThread(t.id);
				var c 		= posts.Count;

				comments.Add(t, c > 0 ? c : 0);

				if(c == 0) {
					t.latest = t.date;
					t.latestSource = t.author;
				} else {
					var last = posts.Last();
					t.latest = last.date;
					t.latestSource = last.author;
				}
			}

			threads = threads.OrderByDescending(t => t.latest).ToList();
        }
    }