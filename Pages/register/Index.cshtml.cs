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
			System.Console.WriteLine("user: " + Request.Form["username"]);
			System.Console.WriteLine("user: " + Request.Form["email"]);
		}
    }
}
