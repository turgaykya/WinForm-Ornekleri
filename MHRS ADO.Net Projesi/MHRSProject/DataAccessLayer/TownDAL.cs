using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TownDAL : IDataMapper<Town, Int32>
    {
        SqlCommand _command;
        public TownDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Town Get(int id)
        {
            Town town = null;

            _command.CommandText = "sp_GetTownOne";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TownID", id);

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
                        town = new Town();
                        town.Id = (int)sqlDataReader[0];
                        town.Name = sqlDataReader[1].ToString();
                        town.CityLicensePlate = sqlDataReader[2].ToString();
                    }
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Town getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return town;
        }

        public List<Town> GetAll()
        {
            List<Town> getTownList = new List<Town>();

            _command.CommandText = "vw_GetTown";
            _command.Parameters.Clear();

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
                        Town town = new Town();
                        town.Id = (int)sqlDataReader[0];
                        town.Name = sqlDataReader[1].ToString();
                        town.CityLicensePlate = sqlDataReader[2].ToString();
                        getTownList.Add(town);
                    }
                }
                sqlDataReader.Close();

            }
            catch (Exception)
            {

                throw new Exception("Town listesi getirelemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return getTownList;
        }

        public List<Town> GetTown(string CityLicensePlate)
        {
            List<Town> getTownList = new List<Town>();

            _command.CommandText = "sp_GetTown";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@CityLicensePlate", CityLicensePlate);
            _command.CommandType = CommandType.StoredProcedure;
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
                        Town town = new Town();
                        town.Id = (int)sqlDataReader[0];
                        town.Name = sqlDataReader[1].ToString();
                        town.CityLicensePlate = sqlDataReader[2].ToString();
                        getTownList.Add(town);
                    }
                }
                sqlDataReader.Close();

            }
            catch (Exception)
            {

                throw new Exception("C Town listesi getirelemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return getTownList;
        }

        public int Insert(Town item)
        {
            throw new NotImplementedException();
        }

        public int Update(Town item)
        {
            throw new NotImplementedException();
        }
    }
}
