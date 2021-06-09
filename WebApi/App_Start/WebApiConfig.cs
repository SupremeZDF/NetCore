using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;
using WebApi.Models;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            //config.DependencyResolver;

            // Web API 路由
            config.MapHttpAttributeRoutes();
            config.Filters.Add(new CustomerExceptionAttribute());
            //config.Filters.Add();
            config.Services.Replace(typeof(IExceptionHandler), new CustomerExceptionHandler());

            //var ss = "dd";
            //var dd = ss?.Equals("ss");

            //config.Services.Replace();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
