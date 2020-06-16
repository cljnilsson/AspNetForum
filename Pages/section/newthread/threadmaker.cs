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
    public class ThreadMaker : PageModel
    {
		public bool loggedin;
		public string user;

		public IActionResult OnPost() {
			System.Console.WriteLine("TRYING TO MAKE THREAD");
			var name 	= Request.Form["name"];
			var post 	= Request.Form["text"];
			var sec 	= Request.Form["section"];

			System.Console.WriteLine(name);
			System.Console.WriteLine(post);

			new DB().makeThread(name, post, "DefaultUser", sec); // Update hardcoded user later

			return Redirect("/"); // Update this to redirect to new thread once created in the future
		}	
    }
}
