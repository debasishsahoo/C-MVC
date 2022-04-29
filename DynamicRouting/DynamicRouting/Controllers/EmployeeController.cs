using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DynamicRouting.Models;

namespace DynamicRouting.Controllers
{
    public class EmployeeController : ApiController
    {
        //static List<Employee> Emp = new List<Employee>() {
        //new Employee(){ID = 1, FirstName ="abc1",LastName ="x1",Gender ="M",Salary =142},
        //new Employee(){ID = 2, FirstName ="abc2",LastName ="x2",Gender ="FM",Salary =14512},
        //new Employee(){ID = 3, FirstName ="abc3",LastName ="x3",Gender ="M",Salary =51222},
        //new Employee(){ID = 4, FirstName ="abc4",LastName ="x4",Gender ="FM",Salary =14222},
        //new Employee(){ID = 5, FirstName ="abc5",LastName ="x5",Gender ="M",Salary =1451},
        //};

        //public IEnumerable<Employee> Get()
        //{
        //    return Emp;
        //}

        //[Route("api/Employee/{stdid:int?}")]
        //public Employee Get(int id=0)
        //{
        //    return Emp.FirstOrDefault(s => s.ID == id);
        //}

        //[Route("api/Employee/{id}/job")]
        //public IEnumerable<string> GetEmp(int id)
        //{
        //    List<string> JobList=new List<string>();

        //    if (id == 1)
        //        JobList = new List<string> {"TIXMA-USER","TIXMA-OBJ"};
        //    else if(id==2)
        //        JobList = new List<string> { "TIXMA-USER", "TIXMA-Testing" };
        //    else if (id == 3)
        //        JobList = new List<string> { "TIXMA-USER", "TIXMA-Dev" };
        //    else if (id == 4)
        //        JobList = new List<string> { "TIXMA-USER", "TIXMA-Mobile" };
        //    else 
        //        JobList = new List<string> { "TIXMA-USER", "TIXMA-SQL" };
        //    return JobList;
           
        //}
    }
}
