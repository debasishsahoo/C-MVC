using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MesageHandler.Models
{

    // request                  response
    //    |                        |
    //    |                        |
    //    |                        |
    //    |                        |
    //    |                        |
    //    |  ____________________  |
    //    |  Delegatiog Handler |  |
    //    |  ____________________  |                   |
    //    |                        |
    //    |  ____________________  |
    //    |    |INNER HANDLER |    |
    //    |  ____________________  |

    //SERVER-SIDE HTTP MESSAGE HANDLER

    //httpServer               --> get the request from the HOST
    //httpRoutingDispatcher    --> dispatches the request on the route
    //httpControllerDisatcher  --> send the request to an Controller

    //Read or Modify the HTTP request Header
    //Add a response Header to the HTTP response
    //Validate the request before they reach the Controller(Authentication & Authorization)

    public class MsgHandler1:DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,CancellationToken cancellationToken)
        {
            Debug.WriteLine("Process Request");
            //Call the Inner Handler
            var response=await base.SendAsync(request,cancellationToken);
            Debug.WriteLine("process Response");
            return response;
        
        }

    }
}