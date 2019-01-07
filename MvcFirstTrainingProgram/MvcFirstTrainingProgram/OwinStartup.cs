using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using MvcFirstTrainingProgram.App_Start;
using Owin;

//[assembly: OwinStartup(typeof(MvcFirstTrainingProgram.OwinStartup))]

namespace MvcFirstTrainingProgram
{
    public class OwinStartup
    {
        public void Configuration(IAppBuilder app)
        {

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login")

            });
//
          //  GlobalConfiguration.Configure(WebApiConfig.Register);
        }

    }
}
