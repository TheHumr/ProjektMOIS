using ProjektMOIS.DAO;
using ProjektMOIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjektMOIS.Controllers
{
    public class HomeController : Controller
    {
        private ITripDAO tripDAO = new TripDAO();

        public ActionResult Index()
        {

            IList<Trip> trips = tripDAO.GetAllByCategory("Last Minute");

            ViewBag.Trips = trips;

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