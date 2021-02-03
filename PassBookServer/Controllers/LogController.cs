using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;

namespace PassBookServer.Controllers
{
    public class LogController : ApiController
    {
        public HttpResponseMessage Post([FromBody] ApplePassServiceData.LogPayload payload)
        {
            string logStr = String.Join("; ", payload.logs);
            // Save to ApplePassAPILog SQL table
            var response = new HttpResponseMessage();

            return response;
        }
    }
}