using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;


namespace Role_Base_Auth.Controllers
{
    public class EmployeeController : ApiController
    {
        public HttpResponseMessage GetAllMaleEmployee()
        {
            var identity = (ClaimIdentity)User.Identity;

        }
        public HttpResponseMessage GetAllFeMaleEmployee()
        {

        }
        public HttpResponseMessage GetAllEmployee()
        {

        }
    }
