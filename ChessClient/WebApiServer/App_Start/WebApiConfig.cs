using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional, }
                
            );

            config.Routes.MapHttpRoute(
                  name: "StepstApi",
                  routeTemplate: "api/game/{gameId}/step/",
                defaults: new {  controller = "step" }

);
        }
    }
}
