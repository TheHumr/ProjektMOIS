using NHibernate;
using ProjektMOIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektMOIS.Service
{
    public class NHibernateTripEntityManager : ITripEntityManager
    {
        public IList<Trip> GetAllByCategory(String category)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var trips = session.QueryOver<Trip>()
                                    .Where(e => e.Category == category)
                                    .List();
                return trips as IList<Trip>;

            }
        }

        public IList<Trip> GetByFilters(string destination, int days, DateTime date, float prize)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var trips = session.QueryOver<Trip>()
                                    .Where(e => e.Destination == destination)
                                    .Where(e => e.Length == days)
                                    .Where(e => e.DateStart == date)
                                    .Where(e => e.Prize <= prize)
                                    .List();
                return trips as IList<Trip>;

            }
        }
    }
}