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
		public Dictionary<Thread, int> comments = new Dictionary<Thread, int>();
        public void OnGet(string sec)
        {
			var db = new DB();
			threads = db.GetThreadsFromSection(sec);
			foreach(var t in threads) {
				var posts 	= db.GetPostsInThread(t.id);
				var c 		= posts.Count;

				comments.Add(t, c > 0 ? c : 0);

				if(c == 0) {
					t.latest = t.date;
					t.latestSource = t.author.Username;
				} else {
					var last = posts.Last();
					t.latest = last.date;
					t.latestSource = last.author.Username;
				}
			}

			threads = threads.OrderByDescending(t => t.latest).ToList();
        }
    }