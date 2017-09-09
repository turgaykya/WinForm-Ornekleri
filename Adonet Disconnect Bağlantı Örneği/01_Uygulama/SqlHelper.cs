using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Uygulama
{
    class SqlHelper
    {
        private static SqlConnection _cnn;

        public static SqlConnection cnn
        {
            get { return _cnn; }
        }
        static SqlHelper()
        {
            _cnn = new SqlConnection();
            _cnn.ConnectionString = "server=.;database=Northwind;Integrated Security=true;";
        }
    }
}
