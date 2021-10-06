using ShortenURL.Data_Access_Layer;
using ShortenURL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShortenURL.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Index(FormCollection form)
        {
         
            var longurl = form["LongURL"];
            if (!String.IsNullOrEmpty(longurl))
            {
                longurl.Trim();
                bool islongurl = DAL.IsLongURL(longurl);
                  
                if (islongurl) {
                    ViewBag.ShortURL = DAL.GetShortURL(longurl);
                }
                else
                {
                    DAL.InsertIntoDB(longurl);
                    ViewBag.ShortURL = DAL.GetShortURL(longurl);
                }
            }
            
            return View();
            
        }

  
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}