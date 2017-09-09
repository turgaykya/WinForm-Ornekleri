using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DoctorDAL : IDataMapper<Doctor, Int32>
    {
        SqlCommand _command;

        public DoctorDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        
        public Doctor Get(int id)
        {
            Doctor doctor = null;
            _command.CommandText = "sp_GetDoctorOne";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@DoctorID", id);
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
                        doctor = new Doctor();
                        doctor.ID = (int)sqlDataReader[0];
                        doctor.TC = sqlDataReader[1].ToString();
                        doctor.FirstName = sqlDataReader[2].ToString();
                        doctor.LastName = sqlDataReader[3].ToString();
                        doctor.Title.Id = (int)sqlDataReader[4];
                        doctor.Gender = (bool)sqlDataReader[5];
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Tek bir Doktor getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return doctor;
        }

        public List<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Doctor> GetDoctor(int TownID, int ClinicID, int HospitalID, int PoliclinicID)
        {
            List<Doctor> listGetDoctor = new List<Doctor>();

            _command.CommandText = "sp_GetDoctor";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TownID", TownID);
            _command.Parameters.AddWithValue("@ClinicID", ClinicID);
            _command.Parameters.AddWithValue("@HospitalID", HospitalID);
            _command.Parameters.AddWithValue("@PoliclinicID", PoliclinicID);
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
                        Doctor doctor = new Doctor();
                        doctor.ID = (int)sqlDataReader[0];
                        doctor.TC = sqlDataReader[1].ToString();
                        doctor.FirstName = sqlDataReader[2].ToString();
                        doctor.LastName = sqlDataReader[3].ToString();
                        doctor.Title.Id = (int)sqlDataReader[4];
                        doctor.Gender = (bool)sqlDataReader[5];
                        doctor.Title.Name = sqlDataReader[6].ToString();
                        listGetDoctor.Add(doctor);
                    }
                }
                sqlDataReader.Close();

            }
            catch (Exception)
            {
                throw new Exception("Doktor getirilemedi.");
            }
            finally
            {
                _command.Connection.Close();
            }


            return listGetDoctor;
        }

        public int Insert(Doctor item)
        {
            throw new NotImplementedException();
        }

        public int Update(Doctor item)
        {
            throw new NotImplementedException();
        }
    }
}
