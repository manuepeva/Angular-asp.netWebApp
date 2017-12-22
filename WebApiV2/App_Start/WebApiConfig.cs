using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using WebApiV2.Custom;

namespace WebApiV2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultRoute",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Services.Replace(typeof(IHttpControllerSelector), new CustomControllerSelector(config));

            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("Accept: application/mpv.pragimtech.students.v1+json"));
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("Accept: application/mpv.pragimtech.students.v2+json"));

            //config.Formatters.XmlFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("Accept: application/mpv.pragimtech.students.v1+xml"));
            //config.Formatters.XmlFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("Accept: application/mpv.pragimtech.students.v2+xml"));
            //config.Routes.MapHttpRoute(
            //    name: "StudentV2",
            //    routeTemplate: "api/v2/students/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "StudentV2" }
            //);
        }
    }
}
