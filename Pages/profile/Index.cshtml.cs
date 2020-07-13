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
    public class ProfileModel : PageModel
    {
		public User owner;
		public void OnGet(string user)
        {
			var db = new DB();
			owner = db.GetUserByName(user);
		}
    }
}
