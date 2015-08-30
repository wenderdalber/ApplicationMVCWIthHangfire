using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationMVCwithHangfire.Models;

namespace ApplicationMVCwithHangfire.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Wender Dalber - CTO and Co-Founder Betaup";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Wender Dalber - Contact";

            return View();
        }

        public ActionResult StartMessage()
        {
            ViewBag.Message = ServiceMessage.Messages();

            return View();
        }
    }
}