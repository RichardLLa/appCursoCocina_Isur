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
        //private static readonly string strCnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        private static readonly string strCnn = "Data Source = .; Initial Catalog = CocinaIsur; Integrated Security = True";

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
