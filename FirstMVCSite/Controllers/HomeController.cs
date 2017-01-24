using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCSite.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";//passes data from controller to the view
            //ViewData["Message"] = "Home Page"
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Page";
            return View();
        }
    }
}