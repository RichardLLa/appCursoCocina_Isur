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
        public static bool CreateUser(aeUser pUser,ref string pResult )
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "spUsuarioInsert";
                oCmd.Parameters.AddWithValue("@Alias", pUser.Alias);
                oCmd.Parameters.AddWithValue("@Password", pUser.Password);
                //oCmd.Parameters.AddWithValue("@Result", pResult);
                int e = oCmd.ExecuteNonQuery();
                oCnnData.Close();
                if (e == 1)
                {
                    return true;
                }
                else {
                    pResult = "Usuario no encontrado";
                }
            }
            catch (Exception ex)
            {
                oCnnData.Close();
                pResult = ex.Message;
            }
            return false;
        }
        public static bool CambiarContraseña(aeUser pUser,ref string result)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "spUsuarioUpdatePassword";
                oCmd.Parameters.AddWithValue("@Alias", pUser.Alias);
                oCmd.Parameters.AddWithValue("@Password", pUser.Password);
                if (oCmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                result = "El nombre de usuario no existe";
                oCnnData.Close();
            }
            catch (Exception ex)
            {
                oCnnData.Close();
               result = ex.Message;
            }
            return false;
        }
        public static aeUser GetData(int pIdUsuario)
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
                oRow.IdUser = Convert.ToInt16(oRdr["IdUsuario"]);
                oRow.Alias = (oRdr["Usuario"] == DBNull.Value) ? null : oRdr["Usuario"].ToString();
                oRow.Password = (oRdr["Contraseña"] == DBNull.Value) ? null : oRdr["Contraseña"].ToString();
                oRow.Estate = (oRdr["Estado"] == DBNull.Value) ? false : Convert.ToBoolean(oRdr["Estado"]);
                oRow.IdPerson = (oRdr["IdPersona"] == DBNull.Value) ? 0 :Convert.ToInt16 (oRdr["IdPersona"]);
            }
            oCnnData.Close();
            return oRow;
        }
        public static aeUser GetData(string pAlias,string pPassword, ref string result)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                aeUser oRow = new aeUser();
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "spUsuarioLogin";
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pAlias", pAlias);
                oCmd.Parameters.AddWithValue("@pPassword", pPassword);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                if (oRdr.Read())
                {
                    oRow.FirtsName = (oRdr["FirtsName"] == DBNull.Value) ? null : oRdr["FirtsName"].ToString();
                    oRow.LastName = (oRdr["LastName"] == DBNull.Value) ? null : oRdr["LastName"].ToString();
                    oRow.NroDocument = (oRdr["NroDocument"] == DBNull.Value) ? null : oRdr["NroDocument"].ToString();
                    oRow.IdUser = Convert.ToInt16(oRdr["IdUser"]);
                    oRow.Alias = (oRdr["Alias"] == DBNull.Value) ? null : oRdr["Alias"].ToString();
                    oRow.Password = (oRdr["Password"] == DBNull.Value) ? null : oRdr["Password"].ToString();
                    oRow.Estate = Convert.ToInt16(oRdr["Estate"]) == 1 ? true : false;
                    oRow.IdPerson = Convert.ToInt16(oRdr["IdPerson"]);
                    oRow.RowVersion = (oRdr["RowVersion"] == DBNull.Value) ? null : oRdr["RowVersion"].ToString();
                    oCnnData.Close();
                    return oRow;
                }
                result = "Usuario incorrecto";
            }
            catch (Exception ex)
            {
                result = ex.Message;

            }
            oCnnData.Close();
            return null;
        }

    }
}
