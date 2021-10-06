using Payroc_ShortenURL.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Payroc_ShortenURL.Controllers
{
    public class SController : ApiController
    {
        // GET: WebApi

  /*      public HttpResponseMessage Get(string shorturl)
        {
            var response = Request.CreateResponse(HttpStatusCode.Found);
            var longurl = DAL.GetLongURL(shorturl);
            response.Headers.Location = new Uri(longurl);
            return response;
        }*/

        public string Get(string shorturl)
        {

            return (shorturl);
        }
    }
}