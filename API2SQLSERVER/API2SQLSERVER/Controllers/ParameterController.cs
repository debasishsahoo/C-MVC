using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API2SQLSERVER.Models;

namespace API2SQLSERVER.Controllers
{
    public class ParameterController : ApiController
    {
        
       
        public HttpResponseMessage get(string gender="All")
        {
            using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
            {

                switch(gender.ToLower())
                {
                    case "all":
                        return Request.CreateResponse(HttpStatusCode.OK, dbcontxt.Employees.ToList());
                    case "male":
                        return Request.CreateResponse(HttpStatusCode.OK, dbcontxt.Employees.Where(e=>e.Gender.ToLower()=="male").ToList());

                    case "female":
                        return Request.CreateResponse(HttpStatusCode.OK, dbcontxt.Employees.Where(e => e.Gender.ToLower() == "female").ToList());

                    default: return Request.CreateResponse(HttpStatusCode.BadRequest, "Value for Gender must be male female or All. " + gender + "is invalid.");
                }
            }
        }

        //public HttpResponseMessage Put(int id, Employee employee)
        //{
        //    try
        //    {
        //        using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
        //        {
        //            Employee singleEmployee = dbcontxt.Employees.FirstOrDefault(e => e.ID == id);

        //            if (singleEmployee != null)
        //            {
        //                singleEmployee.FirstName = employee.FirstName;
        //                singleEmployee.LastName = employee.LastName;
        //                singleEmployee.Salary = employee.Salary;
        //                singleEmployee.Gender = employee.Gender;

        //                dbcontxt.SaveChanges();

        //                return Request.CreateResponse(HttpStatusCode.OK, singleEmployee);

        //            }
        //            else
        //            {
        //                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID" + id.ToString() + "not found to Update");
        //            }
        //        }
        //    }
        //    catch (Exception Ex)
        //    {

        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
        //    }

        //}

        public HttpResponseMessage Put([FromBody]int id, [FromUri]Employee employee)
        {
            try
            {
                using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
                {
                    Employee singleEmployee = dbcontxt.Employees.FirstOrDefault(e => e.ID == id);

                    if (singleEmployee != null)
                    {
                        singleEmployee.FirstName = employee.FirstName;
                        singleEmployee.LastName = employee.LastName;
                        singleEmployee.Salary = employee.Salary;
                        singleEmployee.Gender = employee.Gender;

                        dbcontxt.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, singleEmployee);

                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID" + id.ToString() + "not found to Update");
                    }
                }
            }
            catch (Exception Ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }

        }
    }
}
