using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _8.TempData.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Method1()
        {
            TempData["Name"] = "MIR";
            TempData["Age"] = 30;
            return View();
        }

        public ActionResult Method2()
        {
            string Name;
            int Age;

            if(TempData.ContainsKey("Name"))
                Name= TempData["Name"].ToString();

            if (TempData.ContainsKey("Age"))
                Age=int.Parse(TempData["Age"].ToString());

            return View();
        }

        public ActionResult Method3()
        {
            string Name;
            int Age;

            if (TempData.ContainsKey("Name"))
                Name = TempData["Name"].ToString();

            if (TempData.ContainsKey("Age"))
                Age = int.Parse(TempData["Age"].ToString());

            return View();
        }

    }
}