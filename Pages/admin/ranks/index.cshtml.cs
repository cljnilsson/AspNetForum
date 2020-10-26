using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace aspnetcoreapp.Pages
{
    public class AdminRankModel : PageModel
    {
		public List<Rank> ranks = new List<Rank>();
        public void OnGet()
        {
			ranks = new DB().GetAllRanks();
        }
    }
}