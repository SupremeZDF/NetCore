using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrameworkMVC.Controllers
{
    public class NameController : Controller
    {
        // GET: Name
        public ActionResult Index()
        {
            return View();
        }
    }
}