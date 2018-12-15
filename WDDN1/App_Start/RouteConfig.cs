using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WDDN1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Student",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Students", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Branch",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Branches", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Mark",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Marks", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Course",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Courses", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
