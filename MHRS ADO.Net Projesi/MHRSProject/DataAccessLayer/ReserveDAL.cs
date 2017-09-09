using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ReserveDAL : IDataMapper<Reserve, Int32>
    {
        SqlCommand _command;

        public ReserveDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public int Update(Reserve item)
        {
            int affectedRows = 0;

            if (item == null)
            {
                return affectedRows;
            }

            _command.CommandText = "sp_CancelReserve";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@ReserveID", item.Id);

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Randevu iptali başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }
        public Reserve Get(int id)
        {
            throw new NotImplementedException();
        }
        public List<String> GetAll(DateTime date, int DoctorID)
        {
            List<String> reserveList = new List<String>();
            _command.CommandText = "sp_GetHour";
            _command.Parameters.Clear();

            _command.Parameters.AddWithValue("@Date", date.Date);
            _command.Parameters.AddWithValue("@DoctorID", DoctorID);
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

                        string ReserveTime = sqlDataReader[0].ToString();
                        reserveList.Add(ReserveTime);
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                _command.Connection.Close();
            }
            return reserveList;
        }
        public List<Reserve> GetAll()
        {
            throw new NotImplementedException();
        }
        public int Insert(Reserve item)
        {
            int affectedRows = 0;

            if (item == null)
            {
                return affectedRows;
            }

            _command.CommandText = "sp_AddReserve";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@UserID", item.UserID);
            _command.Parameters.AddWithValue("@HcpdID", item.hcpdID);
            _command.Parameters.AddWithValue("@ReserveDate", item.ReserveDate.Date);
            _command.Parameters.AddWithValue("@ReserveTime", item.ReserveTime.ToShortTimeString());

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                affectedRows = _command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw new Exception(" HCPDID Getirilemedi ");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }
        public int HCPDID(int HospitalID, int ClinicID, int PoliclinicID, int DoctorID)
        {
            object hcpdID = 0;

            _command.CommandText = "sp_GetHCPDID";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@HospitalID", HospitalID);
            _command.Parameters.AddWithValue("@ClinicID", ClinicID);
            _command.Parameters.AddWithValue("@PoliclinicID", PoliclinicID);
            _command.Parameters.AddWithValue("@DoctorID", DoctorID);

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                hcpdID = _command.ExecuteScalar();


            }
            catch (Exception)
            {

                throw new Exception("Boş alan bırakılamaz.");
            }
            finally
            {
                _command.Connection.Close();
            }

            return (int)hcpdID;

        }
        public int ReserveControl(int UserID, int ClinicID)
        {
            object control = 0;

            _command.CommandText = "sp_GetReserveControl";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@UserID", UserID);
            _command.Parameters.AddWithValue("@ClinicID", ClinicID);
            _command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                control = _command.ExecuteScalar();

            }
            catch (Exception)
            {

                throw new Exception("Hatalı İşlem");
            }
            finally
            {
                _command.Connection.Close();
            }

            return control == null ? 0 : (int)control;
        }

        public List<Reserve> GetReserveHistory(int id)
        {
            List<Reserve> getReserveList = new List<Reserve>();

            _command.CommandText = "sp_GetReserveHistory";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@UserID", id);
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
                        Reserve reserve = new Reserve();
                        reserve.Id = (int)sqlDataReader[0];
                        reserve.Hospital.Name = sqlDataReader[1].ToString();
                        reserve.Clinic.Name = sqlDataReader[2].ToString();
                        reserve.Policlinic.Name = sqlDataReader[3].ToString();
                        reserve.Doctor.FirstName = sqlDataReader[4].ToString();
                        reserve.Doctor.LastName = sqlDataReader[5].ToString();
                        reserve.ReserveDate = (DateTime)sqlDataReader[6];
                        reserve.ReserveTime = DateTime.Parse(sqlDataReader[7].ToString());
                        reserve.IsPassed = (bool)sqlDataReader[8];
                        reserve.IsDrop = (bool)sqlDataReader[9];
                        reserve.Doctor.Title.Name = sqlDataReader[11].ToString();
                        getReserveList.Add(reserve);
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _command.Connection.Close();
            }




            return getReserveList;
        }

        public void ReserveUpdate()
        {
            _command.CommandText = "sp_UpdateReserve";
            _command.Parameters.Clear();
            _command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                _command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Reserveler Güncellenmedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

        }

        public int ReserveCancel(int id)
        {
            int affectedRows = 0;

            _command.CommandText = "sp_CancelReserve";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@ReserveID", id);

            try
            {
                if (_command.Connection.State == System.Data.ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }

                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Randevu iptali başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }

    }
}
