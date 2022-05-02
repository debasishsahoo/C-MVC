using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using BasicAuth.Models;

namespace BasicAuth.Controllers
{
    
    public class EmployeeController : ApiController
    {
        [BasicAuthentication]
        [HttpGet]
        public HttpResponseMessage GetEmployees() {
            string username = Thread.CurrentPrincipal.Identity.Name;
            List<Employee> EmpList=new EmployeeBLL().GetEmployees();
            switch(username.ToLower())
            {
                case "abir":
             return Request.CreateResponse(HttpStatusCode.OK,EmpList.Where(e=>e.Gender.ToLower()=="male").ToList());

                case "mir":
                    return Request.CreateResponse(HttpStatusCode.OK, EmpList.Where(e => e.Gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
