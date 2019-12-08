using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.util
{
    public static class daDateTimeServer
    {
        public static DateTime? GetDateTimeServer(ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                DateTime? DateTimeServer= null;
                SqlCommand oCmd = new SqlCommand("GetDateTimeServer", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                if (oRdr.Read())
                {
                    DateTimeServer = oRdr["DatetimeServer"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(oRdr["DatetimeServer"]);
                }
                oCnnData.Close();
                return DateTimeServer;
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
            return null;
        }
    }
}
