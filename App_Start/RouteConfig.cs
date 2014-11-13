using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing.Constraints;

namespace CeniraBiblioteca
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
                url: "Home/Search/{page}",
                defaults: new { controller = "Home", action = "Search" },
                constraints: new { page = @"\d+" });

            routes.MapRoute("Category",
                url: "Home/Search/{category}",
                defaults: new { controller = "Home", action = "Search", page = 1 });

            routes.MapRoute(null,
                url: "Home/Search/{category}/{page}",
                defaults: new { controller = "Home", action = "Search" },
                constraints: new { page = @"\d+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
