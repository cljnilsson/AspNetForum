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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;		
		public List<Section> baba;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
			var db = new DB();
			baba = db.GetAllSections();

			// Finds latest post in all threads
			foreach(var s in baba) {
				var threads = db.GetThreadsFromSection(s.Name);
				if(threads.Count > 0) {
					foreach(var t in threads) {
						var posts 	= db.GetPostsInThread(t.id);
						var c 		= posts.Count;

						if(c == 0) {
							t.latest = t.date;
							t.latestSource = t.author;
						} else {
							var last = posts.Last();
							t.latest = last.date;
							t.latestSource = last.author;
						}
					}

					threads = threads.OrderByDescending(t => t.latest).ToList();
					
					s.latest = threads.FirstOrDefault().latest;
					s.latestSource = threads.FirstOrDefault().latestSource;
					s.latestThread = threads.FirstOrDefault().name;
				}
			}
        }
    }
}
