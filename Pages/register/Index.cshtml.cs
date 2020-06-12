using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Model;

namespace aspnetcoreapp.Pages
{
    public class RegModel : PageModel
    {
        public void OnGet()
        {
			System.Console.WriteLine("WoW!zzz");
        }

		public void OnPost() {
			System.Console.WriteLine("TRYING TO MAKE USER");
			var username 	= Request.Form["username"];
			var password 	= Request.Form["password"];
			var cpassword 	= Request.Form["cpassword"];
			var email 		= Request.Form["email"];

			if(password == cpassword) {
				new DB().CreateUser(username, password, email);
			} else {
				// Return error somehow
			}
		}
    }
}
