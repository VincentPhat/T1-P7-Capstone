using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Project Capstone.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Project Capstone Contact Page.";

            return View();
        }
    }
}