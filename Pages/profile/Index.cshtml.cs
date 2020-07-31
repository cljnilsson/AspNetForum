using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.Extensions.Logging;

using Model;

namespace aspnetcoreapp.Pages
{
    public class ProfileModel : PageModel
    {
		public User owner { get; set; }
		public List<ProfilePost> profilePosts;
		public Dictionary<ProfilePost, List<ProfilePostComment>> hash = new Dictionary<ProfilePost, List<ProfilePostComment>>();

		private void onLoad(string user) {
			var db = new DB();
			owner = db.GetUserByName(user);
			profilePosts = db.GetPostsOnProfile(owner);

			foreach(var pp in profilePosts) {
				var list = db.GetCommentsOnProfilePost(pp);
				hash.Add(pp, list);
			}
		}
		public void OnGet(string user)
        {
			onLoad(user);
		}

		public IActionResult OnPost(string user)
        {
			Console.WriteLine("1");
			var db = new DB();
			onLoad(user);

			var msg = Request.Form["profileMessage"];
			var author = HttpContext.Session.GetString("username");

			if(!String.IsNullOrEmpty(msg)) {
				Console.WriteLine($"{author} is trying to write {msg} on {user}'s profile");

				db.makeProfilePost(msg, user, author);
			} else {
				msg = Request.Form["profileMessageComment"];
				if(!String.IsNullOrEmpty(msg)) {
					var id = Int32.Parse(Request.Form["profileMessageCommentId"]);
					Console.WriteLine($"{author} is trying to write {msg} on {user}'s profile as a reply to a comment with id {id}");

					db.makeProfilePostComment(msg, author, id);
				} else {
					Console.WriteLine("TRYING TO EDIT POST");
					msg = Request.Form["profileMessageEdit"];
					if(!String.IsNullOrEmpty(msg)) {
						var id = Int32.Parse(Request.Form["profileMessageCommentId"]);
						db.editProfilePost(id, msg);
					} else {
						Console.WriteLine("Form Request is invalid");
					}
				}
			}

			return Redirect($"/profile/{user}");
		}
    }
}
