using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blowout_Kraupp_Tyler.Controllers
{
    public class HomeController : Controller
    {
        //VARIABLES
        public static string sNewUsed = "";

        public ActionResult Index()
        {
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

        public ActionResult Rentals()
        {
            return View("Rentals");
        }

        //METHOD TO GENERATE CLIENT FORM
        public ActionResult Client()
        {
            return View("Client");
        }

        //METHODS TO CALL INDIVIDUAL RENTAL PAGES AND PASS HARD CODED INSTRUMENT DATA TO THE VIEWBAG
        public ActionResult Trumpet()
        {
            ViewBag.Name = "/Content/Images/Trumpet.jpeg";
            ViewBag.NewPrice = "$55 a month";
            ViewBag.UsedPrice = "$25 a month";

            return View("Instrument");
        }

        public ActionResult Trombone()
        {
            ViewBag.Name = "/Content/Images/Trombone.jpeg"; ;
            ViewBag.NewPrice = "$60 a month";
            ViewBag.UsedPrice = "$35 a month";

            return View("Instrument");
        }

        public ActionResult Tuba()
        {
            ViewBag.Name = "/Content/Images/Tuba.jpeg"; ;
            ViewBag.NewPrice = "$70 a month";
            ViewBag.UsedPrice = "$50 a month";

            return View("Instrument");
        }

        public ActionResult Clarinet()
        {
            ViewBag.Name = "/Content/Images/Clarinet.jpeg"; ;
            ViewBag.NewPrice = "$40 a month";
            ViewBag.UsedPrice = "$25 a month";

            return View("Instrument");
        }

        public ActionResult Flute()
        {
            ViewBag.Name = "/Content/Images/Flute.jpeg"; ;
            ViewBag.NewPrice = "$35 a month";
            ViewBag.UsedPrice = "$27 a month";

            return View("Instrument");
        }

        public ActionResult Saxophone()
        {
            ViewBag.Name = "/Content/Images/Saxophone.jpeg"; ;
            ViewBag.NewPrice = "$42 a month";
            ViewBag.UsedPrice = "$30 a month";

            return View("Instrument");
        }
    }
}