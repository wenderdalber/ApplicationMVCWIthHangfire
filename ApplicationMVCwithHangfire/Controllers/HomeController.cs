using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApplicationMVCwithHangfire.Models;
using Hangfire;

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
            /*Using schedule with a timespan of five minutes, this means this message is start
            five minutes after one click in Message link*/
            ViewBag.Message = BackgroundJob.Schedule<ServiceMessage>(m => m.Messages(), TimeSpan.FromMilliseconds(5));

            return View();
        }
    }
}