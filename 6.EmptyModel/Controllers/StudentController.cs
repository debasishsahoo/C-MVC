using _6.EmptyModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6.EmptyModel.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(int id)
        {
            StudentBLL Sbll = new StudentBLL();
            Student student = Sbll.GetStudentDetails(id);

            //ViewData["Student"]=student;
            //ViewData["Header"] = "Student Details";

            //ViewBag.Student=student;
            ViewBag.Header = "Student Details";

            return View(student);
        }
    }
}