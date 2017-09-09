using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SecretQuestionDAL : IDataMapper<SecretQuestion, Int32>
    {
        SqlCommand _command;

        public SecretQuestionDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public SecretQuestion Get(int id)
        {

            SecretQuestion secretQuestion = null;
            _command.CommandText = "sp_GetSecretQuestion";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@SecretQuestionID", id);

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
                        secretQuestion = new SecretQuestion();
                        secretQuestion.Id = (int)sqlDataReader[0];
                        secretQuestion.Question = sqlDataReader[1].ToString();
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Tek bir SecretQuestion getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return secretQuestion;
        }

        public List<SecretQuestion> GetAll()
        {
            List<SecretQuestion> getSercerQuestionList = new List<SecretQuestion>();

            _command.CommandText = "SELECT * FROM vw_GetSecretQuestion";
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
                        SecretQuestion secretQuestion = new SecretQuestion();
                        secretQuestion.Id = (int)sqlDataReader[0];
                        secretQuestion.Question = sqlDataReader[1].ToString();

                        getSercerQuestionList.Add(secretQuestion);
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Question'lar getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return getSercerQuestionList;
        }

        public int Insert(SecretQuestion item)
        {
            throw new NotImplementedException();
        }
        public int Update(SecretQuestion item)
        {
            throw new NotImplementedException();
        }

    }
}
