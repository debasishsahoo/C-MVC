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
    public class MsgHandler5: DelegatingHandler
    {
        public string Key { get; set; }

        public MsgHandler5(string key)
        {
            this.Key = key;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!ValidateKey(request))
            {
                var response=new HttpResponseMessage(HttpStatusCode.Forbidden);
                var tsc=new TaskCompletionSource<HttpResponseMessage>();
                tsc.SetResult(response);
                return tsc.Task;
            }
            return base.SendAsync(request, cancellationToken);
        }

        private bool ValidateKey(HttpRequestMessage message)
        {
            var query= message.RequestUri.ParseQueryString();
            string key = query["key"];
            return (key == Key);
        }

    }
}