using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using WebApi.Models;

namespace WebApi.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController : ApiController
    {
        [HttpGet]
        //[CustomerException]
        //[AllowAnonymous]
        [CustomerActionFilterAttrbute]
        public void Login() 
        {
            FormsAuthenticationTicket authenticationTicket = new FormsAuthenticationTicket(0, "name", DateTime.Now, DateTime.Now.AddHours(1), true, string.Format("sss&sdd"));
            var ss = FormsAuthentication.FormsCookiePath;
            var dd = FormsAuthentication.Encrypt(authenticationTicket);
            throw new Exception("xxxxxxxxx");
            //Request.Headers.Authorization
            //new HttpResponseException();
            var attrbute = Request.GetActionDescriptor().GetCustomAttributes<AllowAnonymousAttribute>();//获取方法的特性
            var con = Request.GetActionDescriptor().ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>(); //获取控制器特性
        }
    }
}
