using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public static class daConnection
    {
        private static SqlConnection Conn;
        private static readonly string strCnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public static SqlConnection Connect()
        {
            if (Conn == null)
            {
                Conn = new SqlConnection(strCnn);
            }
            Conn.Open();
            return Conn;
        }

    }
}
