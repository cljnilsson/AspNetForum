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
    public class LogModel : PageModel
    {
		public bool loggedin;
		public string user;
		public void OnGet()
        {
			var s = HttpContext.Session;
			if(s.GetString("username") != "") {
				System.Console.WriteLine("Si");
				loggedin = true;
				user = s.GetString("username");
			} else {
				System.Console.WriteLine("nein");
			}
        }

		public IActionResult OnPost() {
			System.Console.WriteLine("TRYING TO LOGIN");

			var username 	= Request.Form["username"];
			var password 	= Request.Form["password"];
			var db 			= new DB();
			
			var correct = db.Login(username, password);

			if(correct) {
				HttpContext.Session.SetString("username", username);
				db.updateLastLogin(username);
			}

			return Redirect(Request.Headers["Referer"].ToString());
		}	
    }
}
