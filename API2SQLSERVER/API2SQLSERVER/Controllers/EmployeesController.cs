using API2SQLSERVER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API2SQLSERVER.Controllers
{
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
                 return Request.CreateResponse(HttpStatusCode.NotFound, "Employee with ID"+id.ToString()+"not found");
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
                return Request.CreateResponse(HttpStatusCode.BadRequest,Ex);
            }

        }


    }
}
