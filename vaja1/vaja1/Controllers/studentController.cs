using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vaja1.Models;

namespace vaja1.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            var seznam = new List<student>()
            {
            new student() { studentId = 1, studentName = "esad", Age = 20 },
            new student() { studentId = 2, studentName = "anej", Age = 20 },
            new student() { studentId = 3, studentName = "erik", Age = 20 },
            new student() { studentId = 4, studentName = "klemen", Age = 20 },
            new student() { studentId = 5, studentName = "gasper", Age = 20 }
            };
            return View(seznam);
        }
    }
}