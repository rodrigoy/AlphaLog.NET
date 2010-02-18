using System.Web.Mvc;
using System.Web.Routing;
using SharpArch.Web.Areas;

namespace AlphaLog.Web.Controllers
{
    public class RouteRegistrar
    {
        public static void RegisterRoutesTo(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

            // The areas below must be registered from greater subareas to fewer;
            // i.e., the root area should be the last area registered

            // Example illustrative route with a nested area
            //routes.CreateArea("Organization/Department", "AlphaLog.Web.Controllers.Organization.Department",
            //    routes.MapRoute(null, "Organization/Department/{controller}/{action}", new { action = "Index" })
            //);
//
//            routes.CreateArea("Organization", "AlphaLog.Web.Controllers.Organization",
//                routes.MapRoute(null, "Organization/{controller}/{action}", new { action = "Index" }),
//                routes.MapRoute(null, "Organization/{controller}/{action}/{id}")
//            );

            // Routing config for the root area
            routes.CreateArea("Root", "AlphaLog.Web.Controllers",
                routes.MapRoute(null, "{controller}/{action}", new { controller = "Home", action = "Index" })
            );
        }
    }
}
