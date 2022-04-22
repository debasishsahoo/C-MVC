using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API2SQLSERVER.Models;

namespace API2SQLSERVER.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage LoadStudent()
        {
            using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
            {
                List<Employee> employees = dbcontxt.Employees.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, employees);
            }

        }

        [HttpGet]
        public HttpResponseMessage LoadStudent(int id)
        {
            using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
            {
                Employee employee = dbcontxt.Employees.FirstOrDefault(e => e.ID == id);

                if (employee != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, employee);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID" + id.ToString() + "not found");
                }


            }
        }

        //[HttpGet]
        //public HttpResponseMessage LoadStudent(string gender)
        //{
        //    using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
        //    {

        //        List<Employee> employee = dbcontxt.Employees.Where(e => e.Gender == gender).ToList();

        //        if (employee != null)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, employee);
        //        }
        //        else
        //        {
        //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Gender  " + gender + "not found");
        //        }
        //    }
        //}









        [HttpPost]
        public HttpResponseMessage AddStudent([FromBody] Employee employee)
        {
            try
            {
                using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
                {
                    dbcontxt.Employees.Add(employee);
                    dbcontxt.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
                    return message;

                }


            }
            catch (Exception Ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }

        }

        [HttpPut]
        public HttpResponseMessage UpdateStudent(int id, [FromBody] Employee employee)
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

        [HttpDelete]
        public HttpResponseMessage DeleteStudent(int id)
        {
            try
            {
                using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
                {
                    Employee singlemployee = dbcontxt.Employees.FirstOrDefault(e => e.ID == id);
                    if (singlemployee != null)
                    {
                        dbcontxt.Employees.Remove(singlemployee);
                        dbcontxt.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID " + id.ToString() + " not found to delete");
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
