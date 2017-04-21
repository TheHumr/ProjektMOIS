using ProjektMOIS.DAO;
using ProjektMOIS.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjektMOIS.Controllers
{
    public class TripController : Controller 
    {
        private ITripDAO tripDAO = new TripDAO();

        // GET: Trip/5
        public ActionResult Index(long id)
        {
            Trip trip = tripDAO.GetById(id);

            ViewBag.Trip = trip;

            return View();
        }

        // GET: Trip/Register/5

        public ActionResult Register(long id)
        {
            Trip trip = tripDAO.GetById(id);

            ViewBag.Trip = trip;

            return View();
        }

        // GET: Trip/Create

        public ActionResult Create()
        {

            return View();
        }

    }
}
