using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using WAF.Presentation.Web.Routing;

namespace FrameworkMVCRazor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Standard MVC Template routing here:
            
            routes.MapRoute(
                name: "Default",
                url: "partial/{controller}/{action}/{id}",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );
            

            // Standard Webnodes routing here:
            routes.MapWebnodesRoute("WAFNode", "{*address}", new { controller = "Article", action = "Index", address = UrlParameter.Optional }).RouteHandler = new WAFRouteHandler();

        }
    }
}
