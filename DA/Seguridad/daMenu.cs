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
        public static List<aeMenu> GetData()
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
                oRow.Name = (oRdr["Descripcion"] == DBNull.Value) ? null : oRdr["Descripcion"].ToString();
                oRow.Objeto = (oRdr["Objeto"] == DBNull.Value) ? null : oRdr["Objeto"].ToString();
                oRow.IdApplication = (oRdr["Codigo"] == DBNull.Value) ? null : oRdr["Codigo"].ToString();
                oRow.IdModulo = (oRdr["IdModulo"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdModulo"]);
                oLista.Add(oRow);
            }

            oCnnData.Close();
            return oLista;
        }
        public List<aeMenu> GetData(int pIdRole,string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeMenu> oLista = new List<aeMenu>();
                SqlCommand oCmd = new SqlCommand("spMenuSelectByIdRole", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdRole", pIdRole);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                while (oRdr.Read())
                {
                    aeMenu oRow = new aeMenu();
                    oRow.IdMenu = Convert.ToInt16(oRdr["IdMenu"].ToString());
                    oRow.Name = (oRdr["Descripcion"] == DBNull.Value) ? null : oRdr["Descripcion"].ToString();
                    oRow.IdApplication = (oRdr["IdApplication"] == DBNull.Value) ? null : oRdr["IdApplication"].ToString();
                    oRow.Estate = Convert.ToInt16(oRdr["IdModulo"]) == 1 ? true : false;
                    oRow.Level = oRdr["Level"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["Level"]);
                    oLista.Add(oRow);
                }
                return oLista;
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
