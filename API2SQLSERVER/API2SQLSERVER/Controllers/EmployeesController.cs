using API2SQLSERVER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API2SQLSERVER.Controllers
{
    [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
    //[EnableCorsAttribute("*","*","*")]
    public class EmployeesController : ApiController
    {
        //public IEnumerable<Employee> Get()
        //{
        //    using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
        //    {
        //        return dbcontxt.Employees.ToList();
        //    }
        //}

        //public Employee Get(int id)
        //{
        //    using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
        //    {
        //        return dbcontxt.Employees.FirstOrDefault(e => e.ID == id);
        //    }
        //}



        //public IEnumerable<string>get()
        //{
        //    IList<string> formatters=new List<string>();
        //    formatters.Add(GlobalConfiguration.Configuration.Formatters.JsonFormatter.GetType().FullName);

        //    formatters.Add(GlobalConfiguration.Configuration.Formatters.XmlFormatter.GetType().FullName);

        //    formatters.Add(GlobalConfiguration.Configuration.Formatters.FormUrlEncodedFormatter.GetType().FullName);

        //    //foreach (var item in GlobalConfiguration.Configuration.Formatters)
        //    //{
        //    //    formatters.Add(item.ToString());
        //    //}
        //    return formatters.AsEnumerable<string>();
        //}





        //Content-type:"application/json","application/xml"
        //Accept:"application/vnd.debasish.sahoo.tutorials+xml"
        //Accept-Charset:UTF-8 or ISO 8859-1
        //Accept-Encoding:gzip
        //Accept-Language:en-us

        public HttpResponseMessage Get()
        {
            using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
           {
              List<Employee> employees = dbcontxt.Employees.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, employees);
           }

        }

        public HttpResponseMessage Get(int id)
        {
            using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
            {
                Employee employee = dbcontxt.Employees.FirstOrDefault(e=>e.ID==id);

                if(employee!=null)
                {
                 return Request.CreateResponse(HttpStatusCode.OK, employee);
                }
                else
                {
                 return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with ID"+id.ToString()+"not found");
                }

               
            }
        }

        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try {
                using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
                {
                    dbcontxt.Employees.Add(employee);
                    dbcontxt.SaveChanges();

                   var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                    message.Headers.Location = new Uri(Request.RequestUri + employee.ID.ToString());
                    return message;

                }


            }
            catch(Exception Ex) 
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,Ex);
            }

        }

        public HttpResponseMessage Put(int id, [FromBody] Employee employee)
        {
            try 
            {
                using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
                {
            Employee singleEmployee = dbcontxt.Employees.FirstOrDefault(e => e.ID == id);

                    if(singleEmployee!=null)
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
            catch (Exception Ex) {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }
        
        }

        public HttpResponseMessage Delete(int id)
        {
            try 
            {
                using (EmployeeDBContext dbcontxt = new EmployeeDBContext())
                {
                    Employee singlemployee = dbcontxt.Employees.FirstOrDefault(e=>e.ID==id);
                    if(singlemployee!=null)
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
            catch (Exception Ex) {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }
        }

        //Same Origin
        //http://127.0.0.1:1234/home/index  --frontend
        //http://127.0.0.1:1234/api/Employee/get()  --Backend


        //Cross Origin (BeCouse different PORT (4200 vs 5678))
        //http://127.0.0.1:4200/home/index  --frontend
        //http://127.0.0.1:5678/api/Employee/get()  --Backend


        //Cross Origin (BeCouse different Domain (Com vs Net))
        //http://Debasish.sahoo.com/home/index  --frontend
        //http://Debasish.sahoo.net/api/Employee/get()  --Backend


        //Cross Origin (BeCouse different Protocall (https vs http))
        //https://Debasish.sahoo.com/home/index  --frontend
        //http://Debasish.sahoo.net/api/Employee/get()  --Backend






    }
}
