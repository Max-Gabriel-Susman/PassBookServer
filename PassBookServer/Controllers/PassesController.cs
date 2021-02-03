using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using System.IO;

namespace PassBookServer.Controllers
{
    public class PassesController : ApiController
    {
        // this method doesn't have all the parameters detailed in the reference?
        // I think I'm going to have to get a real webservice url to make this shit work
        public HttpResponseMessage Get(string passTypeIdentifier, string serialNumber)
        {
            // If there was new updates, re-generate the whole Pass.
            // I guess I gotta build this logic, better read the docs

            // byte[] passBytes = [YourMethodToGeneratePass]([YourParameter]);
            byte[] passBytes = new byte[1];
            // Return the reponse
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            var dataStream = new MemoryStream(passBytes);
            response.Content = new StreamContent(dataStream);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/vnd.apple.pkpass");
            response.Content.Headers.LastModified = DateTime.Now;
            return response;
        }
    }
}