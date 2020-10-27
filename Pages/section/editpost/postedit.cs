using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Web;
using Microsoft.AspNetCore.Mvc;

using Model;

namespace aspnetcoreapp.Pages
{
    public class PostEditModel : PageModel
    {
		User loggedin;
		Post p;
		public IActionResult OnGet(int post) {
			var db = new DB();

			var name = HttpContext.Session.GetString("username");
			if(name != null && name != "") {
				loggedin = db.GetUserByNameWithRank(name);
				p = db.GetPostByIdWithAuthor(post);
				if(p.author == loggedin || loggedin.Rank.edit) {

				} else {
					System.Console.WriteLine("User is not the original poster AND does not have editing permissions");
					return Redirect("/");
				}
			} else {
				System.Console.WriteLine("User is not logged in, redirecting");
				return Redirect("/");
			}
			return Page();
		}
	}
}
