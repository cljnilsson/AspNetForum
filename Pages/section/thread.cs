    using System;
	using System.Collections.Generic;
	using Microsoft.AspNetCore.Mvc.RazorPages;
	using Microsoft.Extensions.Logging;

	using Model;

	public class ThreadModel : PageModel
    {
		public Thread thread;
		public List<Post> posts;
        public void OnGet(int id)
        {
			var db = new DB();
			thread = db.GetThread(id);
			posts = db.GetPostsInThread(thread.id);

			thread.views++;
			db.SaveChanges();
        }
    }