using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationMSTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Test of the Bamboo CI";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
