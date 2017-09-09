using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClinicBLL : IBusiness<Clinic, Int32>
    {
        ClinicDAL _clinicDAL = new ClinicDAL();

        public Clinic Get(int id)
        {
            Clinic clinic = _clinicDAL.Get(id);
            return clinic;
        }

        public List<Clinic> GetAll()
        {
            List<Clinic> clinicList = _clinicDAL.GetAll();
            return clinicList;
        }

        public int Insert(Clinic item)
        {
            throw new NotImplementedException();
        }

        public List<Clinic> GetClinic(int TownId)
        {
            List<Clinic> clinicList = _clinicDAL.GetClinic(TownId);
            return clinicList;
        }

        public bool Update(Clinic item)
        {
            throw new NotImplementedException();
        }

        public int GetClinicPeriod(int id)
        {
            int clinicPeriod = _clinicDAL.GetClinicPeriod(id);
            return clinicPeriod;
        }
    }
}
