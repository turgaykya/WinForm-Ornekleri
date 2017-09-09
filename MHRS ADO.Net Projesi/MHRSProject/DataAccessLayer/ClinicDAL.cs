using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClinicDAL : IDataMapper<Clinic, Int32>
    {
        SqlCommand _command;

        public ClinicDAL()
        {
            _command = SqlHelper.CreateSqlCommand();

        }

        public Clinic Get(int id)
        {
            Clinic clinic = null;

            _command.CommandText = "sp_GetClinicOne";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@ClinicID", id);
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
                        clinic = new Clinic();
                        clinic.Id = (int)sqlDataReader[0];
                        clinic.Name = sqlDataReader[1].ToString();
                        clinic.CheckupPeriod = (int)sqlDataReader[2];
                    }
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Clinic getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return clinic;

        }

        public List<Clinic> GetAll()
        {
            List<Clinic> getClinicList = new List<Clinic>();

            _command.CommandText = "vw_GetClinic";
            _command.Parameters.Clear();

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                SqlDataReader dataReader = _command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Clinic clinic = new Clinic();
                        clinic.Id = (int)dataReader[0];
                        clinic.Name = dataReader[1].ToString();
                        clinic.CheckupPeriod = (int)dataReader[2];
                        getClinicList.Add(clinic);
                    }
                }

                dataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Clinic Listesi Getirilemedi");
            }
            finally
            {
                _command.Connection.Close();
            }


            return getClinicList;
        }

        public List<Clinic> GetClinic(int id)
        {
            List<Clinic> getClinicList = new List<Clinic>();

            _command.CommandText = "sp_GetClinic";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TownID", id);
            _command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                SqlDataReader dataReader = _command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Clinic clinic = new Clinic();
                        clinic.Id = (int)dataReader[0];
                        clinic.Name = dataReader[1].ToString();
                        clinic.CheckupPeriod = (int)dataReader[2];
                        getClinicList.Add(clinic);
                    }
                }

                dataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("C Clinic Listesi Getirilemedi");
            }
            finally
            {
                _command.Connection.Close();
            }


            return getClinicList;
        }

        public int Insert(Clinic item)
        {
            throw new NotImplementedException();
        }

        public int Update(Clinic item)
        {
            throw new NotImplementedException();
        }

        public int GetClinicPeriod(int id)
        {

            Clinic clinic = new Clinic();
            _command.CommandText = "sp_GetPeriod";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@ClinicID", id);
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

                        clinic.CheckupPeriod = (int)sqlDataReader[0];
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {

                throw new Exception("Reserve'ler getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return clinic.CheckupPeriod;
        }

    }
}
