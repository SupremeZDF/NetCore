using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;

namespace NetFrameworkMVC.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        public ActionResult Index(int? yyyy ,int? mm ,int? dd)
        {
            ViewData["sss"] = yyyy + mm + dd;
            return View();
        }

        public void Websocket() 
        {
            if (HttpContext.IsWebSocketRequest) 
            {
                HttpContext.AcceptWebSocketRequest(async s => {

                    Name(s,"dada");
                });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aspNetWebSocketContext"></param>
        /// <param name="str"></param>
        public async void Name(AspNetWebSocketContext aspNetWebSocketContext , string str) 
        {
        
        }
    }
}