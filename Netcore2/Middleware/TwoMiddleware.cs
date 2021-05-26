using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Middleware
{
    public class TwoMiddleware
    {
        public RequestDelegate requestDelegate;
        public TwoMiddleware(RequestDelegate next) 
        {
            requestDelegate = next;
        }

        public async Task Invoke(HttpContext httpContext) 
        {
            Console.WriteLine("TwoMiddleware:xxxxxx");
            await requestDelegate.Invoke(httpContext);
            Console.WriteLine("TwoMiddleware:xxxxxx");
        }
    }
}
