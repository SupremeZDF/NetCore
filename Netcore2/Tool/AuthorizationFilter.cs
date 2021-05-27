using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netcore2.Tool
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public AuthorizationFilter() 
        {
        
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
