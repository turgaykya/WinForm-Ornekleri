using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlHelper
    {
        private const string NorthwindConnectionString = "server=.; database=Northwind; Integrated Security=true;";

        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = NorthwindConnectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }
    }
}
