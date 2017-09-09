using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TitleDAL : IDataMapper<Title, Int32>
    {
        SqlCommand _command;
        public TitleDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public Title Get(int id)
        {
            Title title = null;

            _command.CommandText = "sp_GetTitleOne";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@TitleID", id);

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
                        title = new Title();
                        title.Id = (int)sqlDataReader[0];
                        title.Name = sqlDataReader[1].ToString();
                    }
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {
                throw new Exception("Title getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }


            return title;
        }

        public List<Title> GetAll()
        {
            List<Title> titleList = new List<Title>();
            _command.CommandText = "vw_GetTitle";
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
                        Title title = new Title();

                        title.Id = (int)sqlDataReader[0];
                        title.Name = sqlDataReader[1].ToString();

                        titleList.Add(title);
                    }
                }

                sqlDataReader.Close();
            }
            catch (Exception)
            {

                throw new Exception("Title listesi getirilemedi!");
            }
            finally
            {
                _command.Connection.Close();
            }

            return titleList;
        }

        public int Insert(Title item)
        {
            throw new NotImplementedException();
        }

        public int Update(Title item)
        {
            throw new NotImplementedException();
        }
    }
}
