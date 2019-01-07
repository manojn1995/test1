using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(MvcFirstTrainingProgram.Startup))]

namespace MvcFirstTrainingProgram
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            // For more information visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login")
            });
            CreateRolesandUsers();
        }

        private void CreateRolesandUsers()
        {
            var userStore = new UserStore<IdentityUser>();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            var UserManager = new UserManager<IdentityUser>(userStore);
            List<string> roles = new List<string> { "admin", "productowner", "employee" };
            //Just making sure this is the first run, later roles add should have it's own check for roles
            if (!roleManager.RoleExists("admin"))
            {
                foreach (var roleName in roles)
                {
                    var role = new IdentityRole
                    {
                        Name = roleName
                    };
                    roleManager.Create(role);
                }
            }
        }
    }

}