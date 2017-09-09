using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Sepet_Uygulaması
{
    class SqlHelper
    {
        private static SqlConnection _cnn;

        public static SqlConnection cnn
        {
            get { return SqlHelper._cnn; }
            set { SqlHelper._cnn = value; }
        }
        static string _stringConnection;
        static SqlHelper()
        {
            _cnn = new SqlConnection();
            _stringConnection = "server=.;database=Northwind;Integrated Security=true;";
            SqlHelper.cnn.ConnectionString = _stringConnection;
        }
        
    }
}
