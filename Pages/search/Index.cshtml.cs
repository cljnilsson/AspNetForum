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
    public class SearchModel : PageModel
    {
		public List<Post> result;
		public void OnGet()
        {
			string q = Request.Query["q"];
			Console.WriteLine(q);
			var db = new DB();
			result = db.searchPosts(q);
		}
    }
}
