using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrameworkMVC.Areas.System.Controllers
{
    public class DefaultController : Controller
    {
        // GET: System/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}