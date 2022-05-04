using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Web.Http;
using Role_Base_Auth.Models;


namespace Role_Base_Auth.Controllers
{
    public class EmployeeController : ApiController
    {
        [BasicAuthentication]
        [MyAuthoizeAttribute(Roles = "Superadmin")]
        [Route("api/AllMaleEmployees")]
        public HttpResponseMessage GetAllMaleEmployee()
        {
            var identity = (ClaimsIdentity)User.Identity;
            ////Getting the Id value
            var ID = identity.Claims.FirstOrDefault(e => e.Type == "ID").Value;

            //Getting the Email value
            var Email = identity.Claims.FirstOrDefault(e => e.Type == "Email").Value;
            ////Getting the Name value
            var username = identity.Name;

            List<Employee> EmpList = new EmployeeBLL().GetEmployees().Where(e => e.Gender.ToLower() == "male").ToList();

            return Request.CreateResponse(HttpStatusCode.OK, EmpList);

        }

        [BasicAuthentication]
        [MyAuthoizeAttribute(Roles = "Admin")]
        [Route("api/AllFemaleEmployees")]
        public HttpResponseMessage GetAllFeMaleEmployee()
        {
            List<Employee> EmpList = new EmployeeBLL().GetEmployees().Where(e => e.Gender.ToLower() == "female").ToList();

            return Request.CreateResponse(HttpStatusCode.OK, EmpList);
        }

        [BasicAuthentication]
        [MyAuthoizeAttribute(Roles = "Admin,Superadmin")]
        [Route("api/AllEmployees")]
        public HttpResponseMessage GetAllEmployee()
        {
            List<Employee> EmpList = new EmployeeBLL().GetEmployees().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, EmpList);
        }
    }
}
