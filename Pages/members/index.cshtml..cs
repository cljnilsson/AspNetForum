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
    public class MembersModel : PageModel
    {
		public List<User> users;
        public void OnGet()
        {
			users = new DB().GetAllUsersWithRank();
        }
    }
}