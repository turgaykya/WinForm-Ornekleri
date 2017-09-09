using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class HospitalDAL : IDataMapper<Hospital, Int32>
    {
        SqlCommand _command;
        public HospitalDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Hospital Get(int id)
        {
            Hospital hospital = null;
            _command.CommandText = "sp_GetHospitalOne";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@HospitalID", id);
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }


                SqlDataReader sqlDataReader = _command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    if (sqlDataReader.Read())
                    {
                        hospital = new Hospital();
                        hospital.Id = (int)sqlDataReader[0];
                        hospital.Name = sqlDataReader[1].ToString();
                        hospital.TownID = (int)sqlDataReader[2];

                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Tek bir Hospital getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return hospital;
        }
        public List<Hospital> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Hospital> GetHospital(int TownID, int ClinicID)
        {
            List<Hospital> getHospitalList = new List<Hospital>();

            _command.CommandText = "sp_GetHospital";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TownID", TownID);
            _command.Parameters.AddWithValue("@ClinicID", ClinicID);
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                SqlDataReader sqlDataReader = _command.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Hospital hospital = new Hospital();
                        hospital.Id = (int)sqlDataReader[0];
                        hospital.Name = sqlDataReader[1].ToString();
                        hospital.TownID = (int)sqlDataReader[2];
                        getHospitalList.Add(hospital);
                    }
                }
                sqlDataReader.Close();

            }
            catch (Exception)
            {

                throw new Exception("Hospital Getirme İşlemi Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return getHospitalList;
        }
        public int Insert(Hospital item)
        {
            throw new NotImplementedException();
        }
        public int Update(Hospital item)
        {
            throw new NotImplementedException();
        }
    }
}
