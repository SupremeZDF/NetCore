using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Middleware
{
    public class ThreeMiidleWale
    {
        public RequestDelegate requestDelegate;
        public ThreeMiidleWale(RequestDelegate next) 
        {
            requestDelegate = next;
        }

        public async Task Invoke(HttpContext httpContext) 
        {
            Console.WriteLine("ThreeMiidleWale:xxxxxx");
            await requestDelegate.Invoke(httpContext);
            Console.WriteLine("ThreeMiidleWale:xxxxxx");
        }
    }
}
