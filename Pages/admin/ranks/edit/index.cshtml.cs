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

			var db = new DB();
			rank = db.GetRankByName(r);

			var toCheck = new string[] {"name", "color", "post", "edit", "delete", "controlPanel"};

			foreach(var s in toCheck) {
				var sent = Request.Form[s].ToString();

				if(sent == "") {
					sent = "false";
				} else if(sent == "on") {
					sent = "true";
				}

				var f = rank.GetType().GetProperty(s);

				if(f != null) {
					if(sent == "true" || sent == "false") {
						f.SetValue(rank, bool.Parse(sent));
					} else {
						f.SetValue(rank, sent);
					}
				} else {
					System.Console.WriteLine("Field " + s + " not found!");
				}
			}

			db.SaveChanges();

			return Redirect($"/admin/ranks/");
		}
    }
}