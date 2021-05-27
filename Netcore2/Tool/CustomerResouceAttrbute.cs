using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Tool
{
    public class CustomerResouceAttrbute : Attribute, IResourceFilter
    {
        public CustomerResouceAttrbute() 
        {
        
        }
        //资源过滤器
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            //throw new NotImplementedException();
            //context.Result = new JsonResult("dsds");
            Console.WriteLine("TwoMiddleware:xxxxxx");
            throw new Exception("xxxxxxxx");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            //throw new NotImplementedException();
            //context.Result = new JsonResult("dsds");
        }
    
    }
}
