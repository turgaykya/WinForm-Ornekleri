using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAL : IDataMapper<User, Int32>
    {
        SqlCommand _command;

        public UserDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public User Get(int id)
        {
            User user = null;
            _command.CommandText = "sp_GetUser";
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
                    if (sqlDataReader.Read())
                    {
                        user = new User();
                        user.Id = (int)sqlDataReader[0];
                        user.TC = sqlDataReader[1].ToString();
                        user.Password = sqlDataReader[2].ToString();
                        user.FirstName = sqlDataReader[3].ToString();
                        user.LastName = sqlDataReader[4].ToString();
                        user.Gender = (bool)sqlDataReader[5];
                        user.DateOfBirth = (DateTime)sqlDataReader[6];
                        user.PlaceOfBirth = sqlDataReader[7].ToString();
                        user.FatherName = sqlDataReader[8].ToString();
                        user.MotherName = sqlDataReader[9].ToString();
                        user.Phone = sqlDataReader[10].ToString();
                        user.Email = sqlDataReader[11].ToString();
                        user.SecretID = (int)sqlDataReader[12];
                        user.SecretAnswer = sqlDataReader[13].ToString();
                    }
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Kişi getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return user;
        }
        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
        public int Insert(User item)
        {
            int affectedRows = 0;

            if (item == null)
            {
                return affectedRows;
            }

            _command.CommandText = "sp_UserCreateAndControl";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TC", item.TC);
            _command.Parameters.AddWithValue("@Password", item.Password);
            _command.Parameters.AddWithValue("@FirstName", item.FirstName);
            _command.Parameters.AddWithValue("@LastName", item.LastName);
            _command.Parameters.AddWithValue("@Gender", item.Gender);
            _command.Parameters.AddWithValue("@DateOfBirth", item.DateOfBirth);
            _command.Parameters.AddWithValue("@PlaceOfBirth", item.PlaceOfBirth);
            _command.Parameters.AddWithValue("@FatherName", item.FatherName);
            _command.Parameters.AddWithValue("@MotherName", item.MotherName);
            _command.Parameters.AddWithValue("@Phone", item.Phone);
            _command.Parameters.AddWithValue("@Email", item.Email);
            _command.Parameters.AddWithValue("@SecretID", item.SecretQuestion.Id);
            _command.Parameters.AddWithValue("@SecretAnswer", item.SecretAnswer);
            _command.CommandType = System.Data.CommandType.StoredProcedure;



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
                throw new Exception("Ekleme Başarasız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;

        }
        public int Update(User item)
        {
            int affectedRows = 0;

            if (item == null)
            {
                return affectedRows;
            }

            _command.CommandText = "sp_UserProfilUpdate";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@UserID", item.Id);
            _command.Parameters.AddWithValue("@Password", item.Password);
            _command.Parameters.AddWithValue("@FirstName", item.FirstName);
            _command.Parameters.AddWithValue("@LastName", item.LastName);
            _command.Parameters.AddWithValue("@Gender", item.Gender);
            _command.Parameters.AddWithValue("@DateOfBirth", item.DateOfBirth);
            _command.Parameters.AddWithValue("@PlaceOfBirth", item.PlaceOfBirth);
            _command.Parameters.AddWithValue("@FatherName", item.FatherName);
            _command.Parameters.AddWithValue("@MotherName", item.MotherName);
            _command.Parameters.AddWithValue("@Phone", item.Phone);
            _command.Parameters.AddWithValue("@Email", item.Email);
            _command.Parameters.AddWithValue("@SecretID", item.SecretID);
            _command.Parameters.AddWithValue("@SecretAnswer", item.SecretAnswer);
            _command.CommandType = System.Data.CommandType.StoredProcedure;

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
                throw;

                //throw new Exception("Kullanıcı Güncelleme Başarasız!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return affectedRows;
        }
        public int LoginControl(string TC, string Password)
        {
            object control = -2;
            _command.CommandText = "sp_Login";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TC", TC);
            _command.Parameters.AddWithValue("@Password", Password);
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

                throw new Exception("Login İşlemi Hatalı!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return (int)control;
        }
        public User SendPassword(string TC)
        {
            User user = null;

            _command.CommandText = "sp_SendMail";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TC", TC);
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
                        user = new User();

                        user.TC = sqlDataReader[0].ToString();
                        user.FirstName = sqlDataReader[1].ToString();
                        user.LastName = sqlDataReader[2].ToString();
                        user.Email = sqlDataReader[3].ToString();
                        user.Password = sqlDataReader[4].ToString();
                        user.SecretQuestion.Question = sqlDataReader[5].ToString();
                        user.SecretAnswer = sqlDataReader[6].ToString();
                    }
                }

            }
            catch (Exception)
            {
                throw new Exception("UserID getirilemedi");
            }
            finally
            {
                _command.Connection.Close();
            }

            return user;

        }
    }
}
