using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class SqlHelper
    {
        private const string MHRSConnectionString = "server=.;database=MHRS;Integrated Security=true";

        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = MHRSConnectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

    }
}
