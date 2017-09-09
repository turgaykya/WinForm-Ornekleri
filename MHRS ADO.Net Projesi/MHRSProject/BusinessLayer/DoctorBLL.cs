using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DoctorBLL : IBusiness<Doctor, Int32>
    {
        DoctorDAL _doctorDAL = new DoctorDAL();

        public Doctor Get(int id)
        {
            Doctor doctor = _doctorDAL.Get(id);
            return doctor;
        }

        public List<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(Doctor item)
        {
            throw new NotImplementedException();
        }

        public bool Update(Doctor item)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetDoctor(int TownID, int ClinicID, int HospitalID, int PoliclinicID)
        {
            List<Doctor> doctorList = _doctorDAL.GetDoctor(TownID, ClinicID, HospitalID, PoliclinicID);
            return doctorList;
        }
    }
}