using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace aspnetcoreapp.Pages
{
    public class RankEditModel : PageModel
    {
		public Rank rank;
        public void OnGet(string r)
        {
			rank = new DB().GetRankByName(r);
        }

		public IActionResult OnPost(string r) {
			System.Console.Write(Request.Form["name"]);
			System.Console.Write(Request.Form["edit"]);
			return Redirect($"/admin/ranks/");
		}
    }
}