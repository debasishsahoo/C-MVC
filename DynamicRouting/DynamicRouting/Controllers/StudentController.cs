using DynamicRouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DynamicRouting.Controllers
{
    public class StudentController : ApiController
    {
        //[HttpGet]
        //public HttpResponseMessage LoadStudent()
        //{
        //    using (StudentModel dbcontxt = new StudentModel())
        //    {
        //        List<Employee> employees = dbcontxt.Employees.ToList();
        //        return Request.CreateResponse(HttpStatusCode.OK, employees);
        //    }

        //}

        //[HttpGet]
        //public HttpResponseMessage LoadStudent(int id)
        //{
        //    using (StudentModel dbcontxt = new StudentModel())
        //    {
        //        Employee employee = dbcontxt.Employees.FirstOrDefault(e => e.ID == id);

        //        if (employee != null)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, employee);
        //        }
        //        else
        //        {
        //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID" + id.ToString() + "not found");
        //        }


        //    }
        //}

        //[HttpPost]
        //public HttpResponseMessage AddStudent([FromBody] Employee employee)
        //{
        //    try
        //    {
        //        using (StudentModel dbcontxt = new StudentModel())
        //        {
        //            dbcontxt.Employees.Add(employee);
        //            dbcontxt.SaveChanges();

        //            var message = Request.CreateResponse(HttpStatusCode.Created, employee);
        //            message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
        //            return message;

        //        }


        //    }
        //    catch (Exception Ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
        //    }

        //}

        //[HttpPut]
        //public HttpResponseMessage UpdateStudent(int id, [FromBody] Employee employee)
        //{
        //    try
        //    {
        //        using (StudentModel dbcontxt = new StudentModel())
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

        //[HttpDelete]
        //public HttpResponseMessage DeleteStudent(int id)
        //{
        //    try
        //    {
        //        using (StudentModel dbcontxt = new StudentModel())
        //        {
        //            Employee singlemployee = dbcontxt.Employees.FirstOrDefault(e => e.ID == id);
        //            if (singlemployee != null)
        //            {
        //                dbcontxt.Employees.Remove(singlemployee);
        //                dbcontxt.SaveChanges();
        //                return Request.CreateResponse(HttpStatusCode.OK);
        //            }
        //            else
        //            {
        //                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID " + id.ToString() + " not found to delete");
        //            }
        //        }
        //    }
        //    catch (Exception Ex)
        //    {

        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
        //    }
        //}
    }
}
