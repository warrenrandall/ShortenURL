using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Payroc_ShortenURL.Controllers
{
    public class LControlle : ApiController
    {
        // GET: WebApi
        public string Get(string id)
        {
            return (id);
        }
    }
}