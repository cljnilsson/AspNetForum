    using System;
	using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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

		public IActionResult OnPost(string sec, int id) {
			System.Console.WriteLine("TRYING TO MAKE POST IN THREAD");
			var db 		= new DB();
			var post 	= Request.Form["text"];
			var author 	= Request.Form["author"];
			db.makeThreadPost(id, post, author);
			return Redirect($"/section/{sec}/{id}");
		}
    }