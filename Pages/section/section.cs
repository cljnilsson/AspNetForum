    using System;
	using System.Collections.Generic;
	using Microsoft.AspNetCore.Mvc.RazorPages;
	using Microsoft.Extensions.Logging;

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
				var c = db.GetPostsInThread(t.id).Count;
				comments.Add(t, c > 0 ? c : 0);
			}
        }
    }