using System;
using AE;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class daUser
    {
        public void CreateUser(aeUser pUser)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "spUsuarioInsert";
                oCmd.Parameters.AddWithValue("@Usuario", pUser.Usuario);
                oCmd.Parameters.AddWithValue("@Contraseña", pUser.Contraseña);
                oCmd.ExecuteNonQuery();
                oCnnData.Close();
            }
            catch (Exception ex)
            {
                oCnnData.Close();
                throw new Exception(ex.Message);
            }
        }
        public void CambiarContraseña(aeUser pUser)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "spUsuarioUpdateContraseña";
                oCmd.Parameters.AddWithValue("@Usuario", pUser.Usuario);
                oCmd.Parameters.AddWithValue("@Contraseña", pUser.Contraseña);
                oCmd.ExecuteNonQuery();
                oCnnData.Close();
                return;
            }
            catch (Exception ex)
            {
                oCnnData.Close();
                throw new Exception(ex.Message);
            }
        }
        public aeUser GetData(int pIdUsuario)
        {
            aeUser oRow = new aeUser();
            SqlConnection oCnnData = new SqlConnection();
            oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand();
            oCmd.Connection = oCnnData;
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.CommandText = "spUsuarioSelectByIdUsuario";
            oCmd.Parameters.Clear();
            oCmd.Parameters.AddWithValue("@IdUsuario", pIdUsuario);
            SqlDataReader oRdr;
            oRdr = oCmd.ExecuteReader();
            while (oRdr.Read())
            {
                oRow.IdUsuario = Convert.ToInt16(oRdr["IdUsuario"]);
                oRow.Usuario = (oRdr["Usuario"] == DBNull.Value) ? null : oRdr["Usuario"].ToString();
                oRow.Contraseña = (oRdr["Contraseña"] == DBNull.Value) ? null : oRdr["Contraseña"].ToString();
                oRow.Estado = (oRdr["Estado"] == DBNull.Value) ? false : Convert.ToBoolean(oRdr["Estado"]);
                oRow.IdPersona = (oRdr["IdPersona"] == DBNull.Value) ? 0 :Convert.ToInt16 (oRdr["IdPersona"]);
            }
            oCnnData.Close();
            return oRow;
        }
        
    }
}
