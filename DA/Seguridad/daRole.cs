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
    public class daRole
    {
        public static List<aeRole> GetData(int pIdUser,ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeRole> oLista = new List<aeRole>();
                SqlCommand oCmd = new SqlCommand("spRoleSelectIdUser", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdUser", pIdUser);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                while (oRdr.Read())
                {
                    aeRole oRow = new aeRole();
                    oRow.IdRole = Convert.ToInt16(oRdr["IdRol"].ToString());
                    oRow.Name = (oRdr["Nombre"] == DBNull.Value) ? "" : oRdr["Nombre"].ToString();
                    oRow.Estate = (oRdr["Estado"] == DBNull.Value) ? false : Convert.ToBoolean(oRdr["Estado"]);
                    oLista.Add(oRow);
                }
                if (oLista.Count > 0)
                {
                    oCnnData.Close();
                    return oLista;
                }
                pResult = "El usuario no tienen ningun ROL asignado, consulte con el administrador.";
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
