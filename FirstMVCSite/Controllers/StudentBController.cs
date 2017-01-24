using FirstMVCSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCSite.Controllers
{
    public class StudentBController : Controller
    {
        // GET: StudentB
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student s)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}