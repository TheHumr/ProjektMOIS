using ProjektMOIS.Model;
using ProjektMOIS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMOIS.DAO
{
    public class TripDAO : AbstractDAO<Trip>, ITripDAO
    {

        private ITripEntityManager em = new NHibernateTripEntityManager();

        public IList<Trip> GetAllByCategory(String category)
        {
            return em.GetAllByCategory(category);
        }

        public IList<Trip> GetByFilters(string destination, int days, DateTime date, float prize)
        {
            return em.GetByFilters(destination, days, date, prize);
        }


        

    }
}