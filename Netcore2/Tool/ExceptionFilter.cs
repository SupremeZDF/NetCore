using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Tool
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public ExceptionFilter() 
        {
        
        }

        public override void OnException(ExceptionContext context) 
        {
             
        }

        public string Name { get; set; }
       // public override Task OnExceptionAsync(ExceptionContext context) { }
    }
}
