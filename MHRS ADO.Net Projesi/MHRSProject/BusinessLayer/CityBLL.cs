using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CityBLL : IBusiness<City,String> 
    {
        CityDAL _cityDAL = new CityDAL();

        public City Get(String id)
        {
            City city = _cityDAL.Get(id);
            return city;
        }

        public List<City> GetAll()
        {
            List<City> cityList = _cityDAL.GetAll();
            return cityList;
        }

        public int Insert(City item)
        {
            throw new NotImplementedException();
        }

        public bool Update(City item)
        {
            throw new NotImplementedException();
        }
         

    }
}
