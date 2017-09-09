using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ReverseBLL : IBusiness<Reserve, Int32>
    {
        ReserveDAL _reserveDAL;

        public ReverseBLL()
        {
            _reserveDAL = new ReserveDAL();
        }

        public Reserve Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reserve> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(Reserve item)
        {
            int affectedRows = _reserveDAL.Insert(item);
            return affectedRows;
        }

        public bool Update(Reserve item)
        {
            throw new NotImplementedException();
        }

        public List<String> GetAll(DateTime date, int DoctorID)
        {
            List<String> reserveList = _reserveDAL.GetAll(date, DoctorID);
            return reserveList;
        }
        public int HCPDID(int HospitalID, int ClinicID, int PoliclinicID, int DoctorID)
        {
            int HCPDID = _reserveDAL.HCPDID(HospitalID, ClinicID, PoliclinicID, DoctorID);
            return HCPDID;
        }

        public int ReserveControl(int UserID, int ClinicID)
        {
            int control = _reserveDAL.ReserveControl(UserID, ClinicID);
            return control;
        }


        public List<Reserve> GetReserveHistory(int id)
        {
            List<Reserve> reserveList = _reserveDAL.GetReserveHistory(id);
            return reserveList;
        }

        public void ReserveUpdate()
        {
            _reserveDAL.ReserveUpdate();
        }

        public bool ReserveCancel(int id)
        {
            int control = _reserveDAL.ReserveCancel(id);

            if (control == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
