using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace WebApi.Models
{
    //全局异常注册处理 
    public class CustomerExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            var message = context.Exception.Message;
            var bb = context.Request.RequestUri;
            context.ExceptionContext.Response = context.Request.CreateResponse(HttpStatusCode.OK);
            base.Handle(context);
        }

        public override bool ShouldHandle(ExceptionHandlerContext context)
        {
            return base.ShouldHandle(context);
        }
    }
}