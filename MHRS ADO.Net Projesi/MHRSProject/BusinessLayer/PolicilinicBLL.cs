using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class PolicilinicBLL : IBusiness<Policlinic,Int32>
    {
       PoliclinicDAL _policlinicDAL = new PoliclinicDAL();

        public int Insert(Policlinic item)
        {
            throw new NotImplementedException();
        }
        public bool Update(Policlinic item)
        {
            throw new NotImplementedException();
        }
        public List<Policlinic> GetAll()
        {
            throw new NotImplementedException();
        }
        public Policlinic Get(int id)
        {
            Policlinic policlinic = _policlinicDAL.Get(id);
            return policlinic;
        }

        public List<Policlinic> GetPoliclinic(int TownID, int ClinicID, int HospitalID)
        {
            List<Policlinic> policlinicList = _policlinicDAL.GetPoliclinic(TownID, ClinicID, HospitalID);
            return policlinicList;
        }
    }
}
