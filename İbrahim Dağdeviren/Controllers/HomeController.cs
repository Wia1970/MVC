using İbrahim_Dağdeviren.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace İbrahim_Dağdeviren.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            wia ww = new wia();
            ww.Name = ("İbrahim");
            ww.Password = ("12345");
            return View(ww);
        }
        
        [HttpPost]
        public ActionResult Index(wia ww)
        {
            return View();
        }
    }
}