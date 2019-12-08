using AE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class daPermission
    {
        public static void InsertData(int? pUser, int? pRole, int pMenu, ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "uspPermissionInsert";
                if (pUser != null) oCmd.Parameters.AddWithValue("@pIdUser", pUser); 
                if (pRole != null) oCmd.Parameters.AddWithValue("@pIdRole", pRole);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu);
                oCmd.ExecuteNonQuery();
                oCnnData.Close();
                return;
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
            return;
        }

        //eliminar usuario menu
        public static void DeleteData(int? pUser, int? pRole, int pMenu, ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "uspPermissionDelete";
                if (pUser != null) oCmd.Parameters.AddWithValue("@pIdUser", pUser);
                if (pRole != null) oCmd.Parameters.AddWithValue("@pIdRole", pRole);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu);
                oCmd.ExecuteNonQuery();
                oCnnData.Close();
                return;
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
            return;
        }
    }
}
