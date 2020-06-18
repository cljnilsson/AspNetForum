using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

using Model;

namespace aspnetcoreapp.Pages
{
    public class RegModel : PageModel
    {
        public void OnGet()
        {
			System.Console.WriteLine("WoW!zzz");
        }

		public async Task<IActionResult> OnPostAsync() {
			System.Console.WriteLine("TRYING TO MAKE USER");
			using (var reader = new StreamReader(Request.Body)) {
				var body = await reader.ReadToEndAsync();
				System.Console.WriteLine(body);
				var data = JObject.Parse(body);

				var username 	= data.GetValue("username").ToString();
				var password 	= data.GetValue("password").ToString();
				var cpassword 	= data.GetValue("cpassword").ToString();
				var email 		= data.GetValue("email").ToString();

				// Add other checcks for unique username etc

				if(password == cpassword) {
					new DB().CreateUser(username, password, email);
					return Content("Success");
				} else {
					return Content("Passwords did not match");
				}
			}
		}
    }
}
