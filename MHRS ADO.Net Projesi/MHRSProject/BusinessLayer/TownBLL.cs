using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class TownBLL : IBusiness<Town,Int32>
    {
        TownDAL _townDAL = new TownDAL();

     
        public Town Get(int id)
        {
            Town town = _townDAL.Get(id);
                return town;
        }

        public List<Town> GetAll()
        {
            List<Town> townList = _townDAL.GetAll();
            return townList;
        }

        public int Insert(Town item)
        {
            throw new NotImplementedException();
        }

        public List<Town> GetTown(string CityLicensePlate)
        {
            List<Town> townList = _townDAL.GetTown(CityLicensePlate);
            return townList;
        }

        public bool Update(Town item)
        {
            throw new NotImplementedException();
        }
    }
}
