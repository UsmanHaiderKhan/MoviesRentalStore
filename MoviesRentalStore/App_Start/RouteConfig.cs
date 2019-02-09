using System.Web.Mvc;
using System.Web.Routing;

namespace MoviesRentalStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //    "MoviesByRelaseDate",
            //    "Movies/RelaseByDate/{year}/{month}",
            //    new { controller = "Movies", action = "RelaseByDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" }
            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
