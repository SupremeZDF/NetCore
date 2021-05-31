using NetFrameworkMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrameworkMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.aaa = new User { Age = "11", Name = "222" };
            return View();
        }

        public ActionResult Two(string Name) 
        {
            ViewBag.sss = Name;
            return View();
        }
    }
}