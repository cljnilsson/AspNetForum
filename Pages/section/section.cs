    using System;
	using System.Collections.Generic;
	using Microsoft.AspNetCore.Mvc.RazorPages;
	using Microsoft.Extensions.Logging;

	using Model;

	public class SectionModel : PageModel
    {
		public List<Thread> threads;
        public void OnGet()
        {
			threads = new DB().GetThreadsFromSection("Gaming");
        }
    }