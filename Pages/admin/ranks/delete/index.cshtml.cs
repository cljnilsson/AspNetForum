using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace aspnetcoreapp.Pages
{
    public class RankDeleteModel : PageModel
    {
        public IActionResult OnGet(string r)
        {
			new DB().deleteRank(r);
			return Redirect($"/admin/ranks/");
        }
    }
}