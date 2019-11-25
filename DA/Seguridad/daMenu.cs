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
        public static List<aeMenu> GetDataByUser(int pIdUser,ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeMenu> oLista = new List<aeMenu>();
                SqlCommand oCmd = new SqlCommand("spMenuSelectByIdRole", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@IdUser", pIdUser);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();

                while (oRdr.Read())
                {
                    aeMenu oRow = new aeMenu();

                    oRow.IdMenu = Convert.ToInt16(oRdr["IdMenu"].ToString());
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? null : oRdr["Name"].ToString();
                    oRow.NameCode = (oRdr["NameCode"] == DBNull.Value) ? null : oRdr["NameCode"].ToString();
                    oRow.IdApplication = (oRdr["IdApplication"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdApplication"]);
                    oRow.IdParent = (oRdr["IdParent"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdParent"]);
                    oRow.Estate = (oRdr["IdParent"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["IdParent"]) == 1? true:false ;
                    oRow.RowVersion = (oRdr["NameCode"] == DBNull.Value) ? null : oRdr["NameCode"].ToString();
                    oRow.Level = (oRdr["Level"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["Level"]);
                    oLista.Add(oRow);
                }

                oCnnData.Close();
                return oLista;
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
            return null;
        }
        public List<aeMenu> GetDataByRole(int pIdRole,string pResult)
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
                    oRow.IdApplication = (oRdr["IdApplication"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdApplication"]);
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
