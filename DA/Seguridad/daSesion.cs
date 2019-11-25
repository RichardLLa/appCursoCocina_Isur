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
    public class daSesion
    {

        public int? ValidateUser(string pUser,string pPassword ,ref string result)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "spValidateUser";
                oCmd.Parameters.AddWithValue("@Alias", pUser);
                oCmd.Parameters.AddWithValue("@Password", pPassword);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                if (oRdr.Read())
                {
                    int IdUser = oRdr["IdUser"] == DBNull.Value ? 0 : Convert.ToInt32(oRdr["IdUser"]);
                    oCnnData.Close();
                    return IdUser;
                }
                else
                {
                    oCnnData.Close();
                    result = "Usuario inexistente, por favor vueva a digitar.";
                }
            }
            catch (Exception ex)
            {
                oCnnData.Close();
                result = ex.Message;
            }
            return null;
        }
        public  aeSession Login(string pUser, string pPassword, ref string result)
        {
            return null;
        }

        public bool CerrarSesion(aeSession pSesion)
        {
            bool salir = false;
            return salir;
        }
    }
}
