    using System;
	using System.Collections.Generic;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Mvc.RazorPages;
	using Microsoft.Extensions.Logging;
	using Microsoft.AspNetCore.Http;

	using Model;

	public class ThreadModel : PageModel
    {
		public Thread thread;
		public List<Post> posts;

		public User loggedin;
        public void OnGet(int id)
        {
			var db = new DB();
			var name = HttpContext.Session.GetString("username");
			if(name != null && name != "") {
				loggedin = db.GetUserByNameWithRank(name);
			}

			thread = db.GetThread(id);
			posts = db.GetPostsInThread(thread.id);

			thread.views++;
			db.SaveChanges();
        }

		public IActionResult OnPost(string sec, int id) {
			var db 		= new DB();
			var post 	= Request.Form["text"];
			var author 	= Request.Form["author"];
			db.makeThreadPost(id, post, author);
			return Redirect($"/section/{sec}/{id}");
		}
    }