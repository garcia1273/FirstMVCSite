using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCSite.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(FormCollection data)
        {
            string firstName = data["fName"];
            string lastName = data["lName"];

            // bundle data in object
            // validate data
            // if valid, add to database

            ViewBag.IsSucess = true;

            return View();
        }

        public ActionResult AddStudentResult()
        {
            return View();
        }
    }
}