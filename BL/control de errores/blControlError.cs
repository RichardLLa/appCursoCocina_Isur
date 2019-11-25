using System;
using AE;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using System.Net;
using System.IO;

namespace BL.control_de_errores
{
    public class blControlError
    {
        public void ErrorInsert(aeControlError pControlError)
        {
            SqlConnection oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand();
            oCmd.Connection = oCnnData;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.CommandText = "spControlErrorInsert";
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.Descripcion);
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.Estado);
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.Numero);
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.Usuario);
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.CapaProyecto);
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.Gravedad);
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.ProcAlmacenado);
            oCmd.Parameters.AddWithValue("@Usuario", pControlError.Detalle);
            oCmd.Parameters.AddWithValue("@Usuario", Directory.GetCurrentDirectory());
            oCmd.Parameters.AddWithValue("@Usuario", Environment.MachineName);
            oCmd.Parameters.AddWithValue("@Usuario", Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily.ToString().ToUpper().Equals("INTERNETWORK")).FirstOrDefault().ToString());
            oCmd.ExecuteNonQuery();
            oCnnData.Close();
        }
    }
}
