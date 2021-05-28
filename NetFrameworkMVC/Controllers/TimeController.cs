using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}