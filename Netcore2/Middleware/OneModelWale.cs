using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Middleware
{
    public class OneModelWale
    {
        public RequestDelegate Delegate;
        public OneModelWale(RequestDelegate next) 
        {
            Delegate = next;
        }

        public async Task Invoke(HttpContext httpContext) 
        {
            Console.WriteLine("OneModelWale:xxxxxx");
            await Delegate.Invoke(httpContext);
            Console.WriteLine("OneModelWale:xxxxxx");
        }
    }
}
