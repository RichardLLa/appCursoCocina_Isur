using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AE;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace DA
{
    public class daRol
    {
        public List<aeRol> GetData(int pIdUsuario)
        {
            List<aeRol> oLista = new List<aeRol>();
            SqlConnection oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand("spUsuarioRoles", oCnnData);
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@IdUsuario", pIdUsuario);
            SqlDataReader oRdr;
            oRdr = oCmd.ExecuteReader();
            while (oRdr.Read())
            {
                aeRol oRow = new aeRol();
                oRow.IdRol = Convert.ToInt16(oRdr["IdRol"].ToString());
                oRow.Nombre = (oRdr["Nombre"] == DBNull.Value) ? "" : oRdr["Nombre"].ToString();
                oRow.Estado = (oRdr["Estado"] == DBNull.Value) ? false:Convert.ToBoolean(oRdr["Estado"]);
                oLista.Add(oRow);
            }
            oCnnData.Close();
            return oLista;
        }

    }
}
