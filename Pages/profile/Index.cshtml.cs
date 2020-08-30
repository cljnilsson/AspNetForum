using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Primitives;

using Model;

namespace aspnetcoreapp.Pages
{
	public delegate void Callback(HttpRequest Request, StringValues sv, string author, string user);  
    public class ProfileModel : PageModel
    {
		public User owner { get; set; }
		public List<ProfilePost> profilePosts;
		public Dictionary<ProfilePost, List<ProfilePostComment>> hash = new Dictionary<ProfilePost, List<ProfilePostComment>>();
		
		[BindProperty]
		public IFormFile avatar { get; set; }

		private static DB db = new DB();
		private static String [] tocheck = {"profileMessage", "profileMessageComment", "profileMessageEdit", "profileMessageCommentEdit", "profileCommentDelete", "profileMessageDelete"};
		private static Dictionary<String, Callback> callbacks = new Dictionary<String, Callback>
		{
			[tocheck[0]] = onProfileMessage,
			[tocheck[1]] = onProfileMessageComment,
			[tocheck[2]] = onProfileMessageEdit,
			[tocheck[3]] = onProfileCommentEdit,
			[tocheck[4]] = onProfileCommentDelete,
			[tocheck[5]] = onProfileMessageDelete
		};

		private IWebHostEnvironment host;

		public ProfileModel(IWebHostEnvironment he) {
			host = he;
			Console.WriteLine(he.ContentRootPath);
		}

		private string ProcessUploadedFile() {
			string uniqueFileName = avatar.FileName;

			if(avatar != null) {
				string folder = Path.Combine(host.WebRootPath, "images/avatars");
				string path = Path.Combine(folder, uniqueFileName);
				using(var filestream = new FileStream(path, FileMode.Create)) {
					avatar.CopyTo(filestream);
				}
			}

			return uniqueFileName;
		}

		private void onLoad(string user) {
			var db = new DB();
			owner = db.GetUserByNameWithRank(user);
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
			onLoad(user);

			if(avatar != null) {
				Console.WriteLine("HNSAKLJDNKJASND;MASD");
				db.UpdateUserAvatar(user, ProcessUploadedFile());
				return Redirect($"/profile/{user}");
			}

			var author = HttpContext.Session.GetString("username");
			var valid = false;

			foreach(var key in tocheck) {
				var msg = Request.Form[key];

				if(!String.IsNullOrEmpty(msg)) {
					callbacks[key].Invoke(Request, msg, author, user);
					valid = true;
					break; // Also maybe wrong
				}
			}

			if(!valid) {
				Console.WriteLine("Form Request is invalid");
			}

			return Redirect($"/profile/{user}");
		}
		private static void onProfileMessage(HttpRequest Request, StringValues msg, string author, string user) {
			Console.WriteLine($"{author} is trying to write {msg} on {user}'s profile");

			db.makeProfilePost(msg, user, author);
		}

		private static void onProfileMessageComment(HttpRequest Request, StringValues msg, string author, string user) {
			var id = Int32.Parse(Request.Form["profileMessageCommentId"]);
			Console.WriteLine($"{author} is trying to write {msg} on {user}'s profile as a reply to a comment with id {id}");

			db.makeProfilePostComment(msg, author, id);
		}

		private static void onProfileMessageEdit(HttpRequest Request, StringValues msg, string author, string user) {
			var id = Int32.Parse(Request.Form["profileMessageCommentId"]);
			db.editProfilePost(id, msg);
		}

		private static void onProfileCommentEdit(HttpRequest Request, StringValues msg, string author, string user) {
			var id = Int32.Parse(Request.Form["profileMessageCommentId"]); // Reply-to identifier
			db.editProfilePostComment(id, msg);
		}

		private static void onProfileCommentDelete(HttpRequest Request, StringValues msg, string author, string user) {
			var id = Int32.Parse(msg); // Reply-to identifier
			db.deleteProfilePostComment(id);
		}

		private static void onProfileMessageDelete(HttpRequest Request, StringValues msg, string author, string user) {
			var id = Int32.Parse(msg); // Reply-to identifier
			db.deleteProfilePost(id);
		}
    }
}
