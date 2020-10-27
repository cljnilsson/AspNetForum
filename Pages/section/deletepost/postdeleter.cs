using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

using Model;

namespace aspnetcoreapp.Pages
{
    public class PostDeleter : PageModel
    {
		public IActionResult OnGet(string sec, int id, int post) {
			System.Console.WriteLine("trying to delete " + post.ToString());
			new DB().deleteThreadPost(post);
			return Redirect($"/section/{sec}/{id}");
		}
    }
}
