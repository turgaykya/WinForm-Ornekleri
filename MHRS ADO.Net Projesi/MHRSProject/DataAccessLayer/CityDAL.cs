using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CityDAL : IDataMapper<City, String>
    {
        SqlCommand _command;

        public CityDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public City Get(string id)
        {
            City city = null;

            _command.CommandText = "sp_GetCity";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@CityLicensePlate", id);

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
                        city = new City();
                        city.LicensePlate = sqlDataReader[0].ToString();
                        city.Name = sqlDataReader[1].ToString();
                    }
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("City getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return city;
        }

        public List<City> GetAll()
        {
            List<City> cityList = new List<City>();
            _command.CommandText = "select * from vw_Getcity";
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
                        City city = new City();
                        city.LicensePlate = sqlDataReader[0].ToString();
                        city.Name = sqlDataReader[1].ToString();
                        cityList.Add(city);
                    }
                }

                sqlDataReader.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
            finally
            {
                _command.Connection.Close();
            }

            return cityList;
        }

        public int Insert(City item)
        {
            throw new NotImplementedException();
        }

        public int Update(City item)
        {
            throw new NotImplementedException();
        }
    }
}
