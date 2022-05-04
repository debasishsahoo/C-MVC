using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MesageHandler.Models
{
    public class MsgHandler3: DelegatingHandler
    {
        readonly string[] _methods = {"DELETE","HEAD","PUT" };
        const string _header= "X-HTTP-Method-Override";

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,CancellationToken cancellationToken) 
        {
          if (request.Method==HttpMethod.Post && request.Headers.Contains(_header))
            {
                var method=request.Headers.GetValues(_header).FirstOrDefault();
                if (_methods.Contains(method,StringComparer.InvariantCultureIgnoreCase))
                {
                    //Change the request Method
                    request.Method=new HttpMethod(method);
                }
            }
            return base.SendAsync(request, cancellationToken);
        }

    }
}