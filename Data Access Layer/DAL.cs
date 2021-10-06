using ShortenURL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShortenURL.Data_Access_Layer
{
    public static class DAL
    {

        private static string DBConnString = System.Configuration.ConfigurationManager.ConnectionStrings["LINQ2SQLconnection"].ConnectionString;

        public static bool IsLongURL(string longurl)
        {
            var db = new Linq2SQLDataContext(DBConnString);
            bool _islongurl = db.URLs.Any(s => s.LongURL == longurl);
            return _islongurl;
        }

        public static bool IsShortURLNotUnique(string shorturl)
        {
            var db = new Linq2SQLDataContext(DBConnString);
            bool _shorturl = db.URLs.Any(s => s.ShortURL == shorturl);
            return _shorturl;
        }

        public static string GetShortURL(string longurl)
        {
            var db = new Linq2SQLDataContext(DBConnString);
            string _shorturl = db.URLs.Where(s => s.LongURL == longurl).Select(s => s.ShortURL ).FirstOrDefault();
            string domainName = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority);
            _shorturl = domainName + "/s/i/" + _shorturl;
            return _shorturl;
        }

        public static string GetLongURL(string shorturl)
        {
            var db = new Linq2SQLDataContext(DBConnString);
            string _longurl = db.URLs.Where(s => s.ShortURL == shorturl).Select(s => s.LongURL).FirstOrDefault();
            return _longurl;
        }

        public static bool InsertIntoDB(string longurl)
        {
            var db = new Linq2SQLDataContext(DBConnString);

            URL record = new  URL()
               {
                    LongURL = longurl,
                    ShortURL = Keygen()
                };
            

            db.URLs.InsertOnSubmit(record);

              try
              {
                  db.SubmitChanges();
                  return true;
              }
              catch (Exception)
              {
                  return false;
              }
            
        }

        public static string Keygen()
        {
            // Generates the 7 alphanumeric string that represents the short URL. It also checks that it is not a duplicate
            // For convenienece I call this shorturl elsewhere but it isn't a url, it is appended to the domain to create the short url.
            // Based on Dan Rigby's algorithm on Stackflow
            // Could improve on this

            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[7];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var shorturl = new String(stringChars);
            // Is it unique?

            if (IsShortURLNotUnique(shorturl))
            {
                Keygen();
            } else { }

            return shorturl;




        }

    }

}