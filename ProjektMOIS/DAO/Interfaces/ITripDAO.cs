
using ProjektMOIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMOIS.DAO
{
    public interface ITripDAO : IAbstractDAO<Trip>
    {
        IList<Trip> GetByFilters(string destination, int days, DateTime date, float prize);
        IList<Trip> GetAllByCategory(String category);
    }
}
