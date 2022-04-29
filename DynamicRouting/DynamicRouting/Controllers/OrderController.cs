using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DynamicRouting.Controllers
{
    [RoutePrefix("orders")]
    public class OrderController : ApiController
    {
        [Route("{id:int}")]
        public HttpResponseMessage Get(int id)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [Route("details")]
        public HttpResponseMessage GetDetails() { 
            return new HttpResponseMessage(HttpStatusCode.OK); 
        }

        [Route("Pending",Order=1)]
        public HttpResponseMessage GetPendingOrder()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [Route("{customername}")]
        public HttpResponseMessage GetByCustomer(string customername)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [Route("{*date:datetime}")]
        public HttpResponseMessage GetByDate(DateTime date)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage GetDelivered()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
