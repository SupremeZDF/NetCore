using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Tool
{
    public class CustomerControllerFiler : Attribute, IActionFilter
    {
        public CustomerControllerFiler()
        {

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //context.Result = new JsonResult("dsadsada");
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
