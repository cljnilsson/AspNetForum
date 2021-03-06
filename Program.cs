using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {

			using(var db = new DB()) {
				db.Database.EnsureCreated();

				if(!db.Ranks.Any()) {
					db.populateRanks();
				}

				if(!db.Users.Any()) {
					db.populateUsers();
				}

				if(!db.Sections.Any()) {
					db.populateSections();
				}

				if(!db.Threads.Any()) {
					db.populateThreads();
				}

				if(!db.Posts.Any()) {
					db.populatePosts();
				}
			}

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
