using System;
using AE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DA
{
    public class daModulo
    {
        public List<aeModulo> GetData()
        {
            List<aeModulo> oLista = new List<aeModulo>();
            SqlConnection oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand("spModulosSelect", oCnnData);
            SqlDataReader oRdr;
            oRdr = oCmd.ExecuteReader();
            while (oRdr.Read())
            {
                aeModulo oRow = new aeModulo();
                oRow.IdModulo = Convert.ToInt16(oRdr["IdModulo"].ToString());
                oRow.Nombre = (oRdr["Nombre"] == null) ? "" : oRdr["Nombre"].ToString();
                oRow.Codigo = (oRdr["Codigo"] == null) ? "" : oRdr["Codigo"].ToString();
                oLista.Add(oRow);
            }
            oCnnData.Close();
            return oLista;
        }
        public List<aeModulo> GetData(int pIdUsuario)
        {
            List<aeModulo> oLista = new List<aeModulo>();
            SqlConnection oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand("spModulosSelectByIdUsuario", oCnnData);
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@IdUsuario", pIdUsuario);
            SqlDataReader oRdr;
            oRdr = oCmd.ExecuteReader();
            while (oRdr.Read())
            {
                aeModulo oRow = new aeModulo();
                oRow.IdModulo = Convert.ToInt16(oRdr["IdModulo"].ToString());
                oRow.Nombre = (oRdr["Nombre"] == null) ? "" : oRdr["Nombre"].ToString();
                oRow.Codigo = (oRdr["Codigo"] == null) ? "" : oRdr["Codigo"].ToString();
                oLista.Add(oRow);
            }
            oCnnData.Close();
            return oLista;
        }

    }
}
