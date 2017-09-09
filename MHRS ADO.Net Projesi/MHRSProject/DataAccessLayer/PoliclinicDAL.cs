using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PoliclinicDAL : IDataMapper<Policlinic, int>
    {
        SqlCommand _command;

        public PoliclinicDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Policlinic Get(int id)
        {
            Policlinic policlinic = null;
            _command.CommandText = "sp_GetPoliclinicOne";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@PoliclinicID", id);

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
                        policlinic = new Policlinic();
                        policlinic.Id = (int)sqlDataReader[0];
                        policlinic.Name = sqlDataReader[1].ToString();
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Policlinic getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return policlinic;

        }
        public List<Policlinic> GetAll()
        {
            throw new NotImplementedException();
        }
        public List<Policlinic> GetPoliclinic(int TownID, int ClinicID, int HospitalID)
        {
            List<Policlinic> getPoliclinicList = new List<Policlinic>();

            _command.CommandText = "sp_GetPoliclinic";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TownID", TownID);
            _command.Parameters.AddWithValue("@ClinicID", ClinicID);
            _command.Parameters.AddWithValue("@HospitalID", HospitalID);
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
                        Policlinic policlinic = new Policlinic();
                        policlinic.Id = (int)sqlDataReader[0];
                        policlinic.Name = sqlDataReader[1].ToString();

                        getPoliclinicList.Add(policlinic);
                    }
                }
                sqlDataReader.Close();
            }

            catch (Exception)
            {
                throw new Exception("Policlinic getirilemedi!");
            }


            return getPoliclinicList;
        }
        public int Insert(Policlinic item)
        {
            throw new NotImplementedException();
        }
        public int Update(Policlinic item)
        {
            throw new NotImplementedException();
        }
    }
}
