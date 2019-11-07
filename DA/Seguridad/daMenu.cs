using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AE;
using System.Data.SqlClient;
using System.Data;

namespace DA
{
    public class daMenu
    {
        public List<aeMenu> GetData()
        {
            List<aeMenu> oLista = new List<aeMenu>();
            SqlConnection oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand("SelectMenu", oCnnData);
            SqlDataReader oRdr;
            oRdr = oCmd.ExecuteReader();

            while (oRdr.Read())
            {
                aeMenu oRow = new aeMenu();

                oRow.IdMenu = Convert.ToInt16(oRdr["IdMenu"].ToString());
                oRow.Descripcion = (oRdr["Descripcion"] == DBNull.Value) ? null : oRdr["Descripcion"].ToString();
                oRow.Objeto = (oRdr["Objeto"] == DBNull.Value) ? null : oRdr["Objeto"].ToString();
                oRow.Codigo = (oRdr["Codigo"] == DBNull.Value) ? null : oRdr["Codigo"].ToString();
                oRow.IdModulo = (oRdr["IdModulo"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdModulo"]);
                oLista.Add(oRow);
            }

            oCnnData.Close();
            return oLista;
        }
        public List<aeMenu> GetData(int pIdUsuario)
        {
            List<aeMenu> oLista = new List<aeMenu>();
            SqlConnection oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand("spMenuSelectByIdUsuario", oCnnData);
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@IdUsuario", pIdUsuario);
            SqlDataReader oRdr;
            oRdr = oCmd.ExecuteReader();

            while (oRdr.Read())
            {
                aeMenu oRow = new aeMenu();

                oRow.IdMenu = Convert.ToInt16(oRdr["IdMenu"].ToString());
                oRow.Descripcion = (oRdr["Descripcion"] == DBNull.Value) ? null : oRdr["Descripcion"].ToString();
                oRow.Objeto = (oRdr["Objeto"] == DBNull.Value) ? null : oRdr["Objeto"].ToString();
                oRow.Codigo = (oRdr["Codigo"] == DBNull.Value) ? null : oRdr["Codigo"].ToString();
                oRow.IdModulo = (oRdr["IdModulo"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdModulo"]);
                oLista.Add(oRow);
            }

            oCnnData.Close();
            return oLista;
        }

    }
}
