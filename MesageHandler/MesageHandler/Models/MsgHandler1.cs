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