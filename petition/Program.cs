using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using petition.Models;
using petition.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var services = host.Services.CreateScope())
            {
                var dbcontext = services.ServiceProvider.GetRequiredService<AppDbContext>();
                var usermgr = services.ServiceProvider.GetRequiredService<UserManager<ApplicationIdentityUser>>();
                var rolemgr = services.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                dbcontext.Database.Migrate();
                var adminrole = new IdentityRole("Admin");
                var Subscribers = new IdentityRole("Subscribers");
                var Registered_Users = new IdentityRole("Registered Users");
                var KPM_Coordinator = new IdentityRole("KPM Coordinator");
                var Administrators = new IdentityRole("Administrators");
                var External_Validator = new IdentityRole("External Validator");
                var KPM_Circulator = new IdentityRole("KPM Circulator");
                var KPM_Management = new IdentityRole("KPM_Management");
                var KPM_SubCoordinator = new IdentityRole("KPM_SubCoordinator");
                var KPM_Validator = new IdentityRole("KPM_Validator");
                var Office_Manager = new IdentityRole("Office_Manager");
                var Translator = new IdentityRole("Translator (en-US)");
                var Unverified_Users = new IdentityRole("Unverified Users");
                if (!dbcontext.Roles.Any())
                {
                    rolemgr.CreateAsync(adminrole).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(Subscribers).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(Registered_Users).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(KPM_Coordinator).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(Administrators).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(External_Validator).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(KPM_Circulator).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(KPM_Management).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(KPM_SubCoordinator).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(KPM_Validator).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(Office_Manager).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(Translator).GetAwaiter().GetResult();
                    rolemgr.CreateAsync(Unverified_Users).GetAwaiter().GetResult();
                }
                if (!dbcontext.Users.Any(u => u.UserName == "admin"))
                {
                    var adminUser = new ApplicationIdentityUser
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        UserName = "admin",
                        EmailConfirmed = true,
                        Email = "admin@aquatic.com"
                    };
                    var result = usermgr.CreateAsync(adminUser, "password").GetAwaiter().GetResult();
                    usermgr.AddToRoleAsync(adminUser, adminrole.Name).GetAwaiter().GetResult();
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
