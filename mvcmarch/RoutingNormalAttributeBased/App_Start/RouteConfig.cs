using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingNormalAttributeBased
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{pid}",
                defaults: new { controller = "Demo", action = "Index", pid = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "myroute",
                url: "{controller}/{action}/{pid}/{name}",
                defaults: new { }
              
                
                );





        }
    }
}
