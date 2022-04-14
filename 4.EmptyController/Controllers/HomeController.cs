using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4.EmptyController.Controllers
{
    public class HomeController : Controller
    {
        //https://localhost:44302/home/index (localhost:port/Controller/Method)
        public string Index()
        {
            return "Mir Da 143 to Mir";
        }

       //https://localhost:44302/home/Mir
        public string Mir()
        {
            return "Rictor 143 to MIR";
        }
        public string Abir(int id,string Name)
        {
            return "Abir 143 to:"  + Name+ "And ID is:"+id;
        }


    }
}