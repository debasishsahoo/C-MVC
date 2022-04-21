using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class EmployeesController : ApiController
    {

        public IEnumerable<Employee>Get()
        {
          using (WEBAPI_DBEntities dbContext =new WEBAPI_DBEntities())
            {
                return dbContext.Employees.ToList();   
            }
        }


        public Employee Get(int id)
        {
       using (WEBAPI_DBEntities dbContext = new WEBAPI_DBEntities())
            {
                return dbContext.Employees.FirstOrDefault(e=>e.ID==id);
            }
        }
    }
}
