using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace aspnetcoreapp.Pages
{
    public class RankViewModel : PageModel
    {
		public Rank rank;
        public void OnGet(string r)
        {
			rank = new DB().GetRankByName(r);
        }
    }
}