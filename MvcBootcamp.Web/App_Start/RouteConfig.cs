﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBootcamp.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Store",
                url: "MyStore/BrowseProduct/{category}",
                defaults: new { controller = "Store", action = "Browse", id = UrlParameter.Optional }
            );

            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{category}",
                defaults: new { controller = "CustomerAjax", action = "Index", id = UrlParameter.Optional }
            );*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
