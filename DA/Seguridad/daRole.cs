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
                SqlCommand oCmd = new SqlCommand("uspRoleSelectIdUser", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdUser", pIdUser);
                oCmd.Parameters.Add("@pResult", SqlDbType.NVarChar,250).Direction = ParameterDirection.Output;
                //oCmd.Parameters.AddWithValue("@NROINSCRITOS", DbType.Int32);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                while (oRdr.Read())
                {
                    aeRole oRow = new aeRole();
                    oRow.IdRole = Convert.ToInt16(oRdr["IdRole"].ToString());
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? "" : oRdr["Name"].ToString();
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToBoolean(oRdr["Estate"]);
                    oLista.Add(oRow);
                }
                if (oLista.Count > 0)
                {
                    oCnnData.Close();
                    return oLista;
                }
                //pResult = "El usuario no tienen ningun ROL asignado, consulte con el administrador.";
                pResult = oCmd.Parameters["@pResult"].Value.ToString();
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
