using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DynamicRouting.Models;

namespace DynamicRouting.Controllers
{
    [RoutePrefix("student")]
    public class AttributeRoutingController : ApiController
    {
        static List<Employee> Emp = new List<Employee>() {
        new Employee(){ID = 1, FirstName ="MIR",LastName ="x1",Gender ="M",Salary =142},
        new Employee(){ID = 2, FirstName ="Surjit",LastName ="x2",Gender ="FM",Salary =14512},
        new Employee(){ID = 3, FirstName ="Mainak",LastName ="x3",Gender ="M",Salary =51222},
        new Employee(){ID = 4, FirstName ="Abir",LastName ="x4",Gender ="FM",Salary =14222},
        new Employee(){ID = 5, FirstName ="Polyon",LastName ="x5",Gender ="M",Salary =1451},
        };

        [HttpGet]
        [Route]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return Emp;
        }

        [HttpGet]
        [Route("{id:int:min(1):max(5)}")]
        public Employee GetEmployeeByID(int id)
        {
            return Emp.FirstOrDefault(s => s.ID == id);
        }
        [HttpGet]
        [Route("{name:alpha}")]
        public Employee GetEmployeeByName(string name)
        {
            return Emp.FirstOrDefault(s => s.FirstName == name);
        }

        [HttpGet]
        [Route("{id:int:range(1,5)}/job")]
        public IEnumerable<string> GetEmployeeJob(int id)
        {
            List<string> JobList = new List<string>();

            if (id == 1)
                JobList = new List<string> { "TIXMA-USER", "TIXMA-OBJ" };
            else if (id == 2)
                JobList = new List<string> { "TIXMA-USER", "TIXMA-Testing" };
            else if (id == 3)
                JobList = new List<string> { "TIXMA-USER", "TIXMA-Dev" };
            else if (id == 4)
                JobList = new List<string> { "TIXMA-USER", "TIXMA-Mobile" };
            else
                JobList = new List<string> { "TIXMA-USER", "TIXMA-SQL" };
            return JobList;

        }
    }
}
