using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//This is the home page 
        {
            return View();
        }
        public ActionResult LearnMore()
        {
            return View();
        }
        public ActionResult GetStarted()
        {
            return View();
        }
        public ActionResult Notes()
        {
            return View();
        }

    }
}