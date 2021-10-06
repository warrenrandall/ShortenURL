using ShortenURL.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ShortenURL.Controllers
{
    public class SController : Controller
    {
    

        public ActionResult I(string id)
        {
            var longurl = DAL.GetLongURL(id);
            return new RedirectResult(longurl);
        }
    }
}