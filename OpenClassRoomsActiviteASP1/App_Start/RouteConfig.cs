using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OpenClassRoomsActiviteASP1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            /*routes.MapRoute(
                name: "Auteurs",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Afficher", action = "Auteurs", id = 0 },
                constraints: new { id = @"\d+" }
            );

            routes.MapRoute(
                name: "Livre",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Afficher", action = "Livre", id = 0 },
                constraints: new { id = @"\d+" }
            );*/

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}",
               defaults: new { controller = "Afficher", action = "Index" }
           );
        }
    }
}
