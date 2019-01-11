using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var student = new Student() { StudentName = "Josh Rohul" };

            //return View(student);
            return Content("Hello World ");
        }
    }
}
