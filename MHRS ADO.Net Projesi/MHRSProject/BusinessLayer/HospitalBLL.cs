using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class HospitalBLL : IBusiness<Hospital,Int32>
    {
       HospitalDAL _hospitalDAL = new HospitalDAL();
        

        public Hospital Get(int id)
        {
            Hospital hospital = _hospitalDAL.Get(id);
            return hospital;
        }

        public List<Hospital> GetHospital(int TownID, int ClinicID)
        {
            List<Hospital> hospitalList = _hospitalDAL.GetHospital(TownID,ClinicID);
            return hospitalList;
        }


        public int Insert(Hospital item)
        {
            throw new NotImplementedException();
        }
        public bool Update(Hospital item)
        {
            throw new NotImplementedException();
        }
        public List<Hospital> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
