using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Showcase1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn More";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Send me a Note";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "What else do you expect from a programmer";

            return View();
        }
    }
}