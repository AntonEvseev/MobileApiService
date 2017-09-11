using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using MobileApp.Models;

namespace MobileApp.Controllers
{
    public class ClickInfoController : ApiController
    {
        ApplicationContext db = new ApplicationContext();
        
        [HttpPost]
        public IHttpActionResult ClickMethod()
        {
            ClickInfo ci = new ClickInfo();
            ci.DateClick = DateTime.Now;
            db.ClickInfoes.Add(ci);
            db.SaveChanges();
            ci = db.ClickInfoes.ToList().Last();
            return Ok(ci.DateClick.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
