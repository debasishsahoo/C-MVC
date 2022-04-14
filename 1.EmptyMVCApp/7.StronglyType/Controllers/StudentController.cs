using _7.StronglyType.ViewModel;
using _7.StronglyType.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7.StronglyType.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            Student student = new Student()
            {
                StudentId = 101,
                Name = "MIR DA",
                Gender = "Male",
                AddressId = 11,
                Class = "BTECH",
                Roll = "CS14528963",
                Dept = "CS"

            };

            Address address = new Address()
            {
                AddressId = 11,
                City = "Kolkata",
                State = "WB",
                Country = "India",
                Pin = "7000025"
            };

         StudentDetailsViewModel SDVM = new StudentDetailsViewModel()
            {
                Student = student,
                Address = address,
                PageTilte = "Student Details Page",
                PageHeader = "Student Details",
            };

            return View(SDVM);
        }
    }
}