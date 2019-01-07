using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MvcFirstTrainingProgram.App_Start
{
    public class WebApiConfig
    {
         public static void Register(HttpConfiguration config)
        {
            // Enable attribute routing
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "Login",
               routeTemplate: "api/{controller}/index",
               defaults: new { id = RouteParameter.Optional }
                );

            // Add default route using convention-based routing
           config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}