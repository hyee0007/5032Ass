using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5032Ass.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "SpanishLearing is a professional company that focuses on Spanish learning eductaion.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email: hyee0007@student.monash.edu";

            return View();
        }
    }
}