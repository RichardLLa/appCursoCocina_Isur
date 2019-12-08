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
        public static aeMenu GetDataById(int pIdMenu,ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                    aeMenu oRow = new aeMenu();
                SqlCommand oCmd = new SqlCommand("uspMenuSelectById", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdMenu", pIdMenu);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();

                if (oRdr.Read())
                {

                    oRow.IdMenu = Convert.ToInt16(oRdr["IdMenu"].ToString());
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? null : oRdr["Name"].ToString();
                    oRow.NameCode = (oRdr["NameCode"] == DBNull.Value) ? null : oRdr["NameCode"].ToString();
                    oRow.IdApplication = (oRdr["IdApplication"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdApplication"]);
                    oRow.IdParent = (oRdr["IdParent"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdParent"]);
                    oRow.Estate = (oRdr["IdParent"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["IdParent"]) == 1? true:false ;
                    oRow.RowVersion = (oRdr["NameCode"] == DBNull.Value) ? null : oRdr["NameCode"].ToString();
                    oRow.Level = (oRdr["Level"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["Level"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) ==1? true:false;
                }

                oCnnData.Close();
                return oRow;
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
            return null;
        }
        public static List<aeMenu> GetDataByUser(int pIdUser, ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeMenu> oLista = new List<aeMenu>();
                SqlCommand oCmd = new SqlCommand("uspMenuSelectByIdRole", oCnnData);
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
                    oRow.Estate = (oRdr["IdParent"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["IdParent"]) == 1 ? true : false;
                    oRow.RowVersion = (oRdr["NameCode"] == DBNull.Value) ? null : oRdr["NameCode"].ToString();
                    oRow.Level = (oRdr["Level"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["Level"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) ==1? true:false;
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
                    oRow.Level = oRdr["Level"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["Level"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) ==1? true:false;
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
        public static List<aeMenu> GetDataByParent(int pIdParent, ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeMenu> oLista = new List<aeMenu>();
                SqlCommand oCmd = new SqlCommand("uspMenuSelectByParent", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdParent", pIdParent);
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
                    oRow.RowVersion = (oRdr["NameCode"] == DBNull.Value) ? null : oRdr["NameCode"].ToString();
                    oRow.Level = (oRdr["Level"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["Level"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) ==1? true:false;
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
        public static void UpdateData(aeMenu pMenu, ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                aeMenu oRow = new aeMenu();
                SqlCommand oCmd = new SqlCommand("uspMenuUpdate", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.IdMenu);
                oCmd.Parameters.AddWithValue("@pName", pMenu.Name);
                oCmd.Parameters.AddWithValue("@pNameCode", pMenu.NameCode);
                oCmd.Parameters.AddWithValue("@pIdApplication", pMenu.IdApplication);
                oCmd.Parameters.AddWithValue("@pIdParent", pMenu.IdParent);
                oCmd.Parameters.AddWithValue("@pEstate", pMenu.Estate);
                oCmd.Parameters.AddWithValue("@pLevel", pMenu.Level);
                oCmd.Parameters.AddWithValue("@pUserUpdate", pMenu.UserUpdate);
                oCmd.Parameters.AddWithValue("@pDateUpdate", pMenu.DateUpdate);
                oCmd.ExecuteNonQuery();
                oCnnData.Close();
                return;
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
        }

        public static void InsertData(aeMenu pMenu, ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                aeMenu oRow = new aeMenu();
                SqlCommand oCmd = new SqlCommand("uspMenuInsert", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.Name);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.NameCode);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.IdApplication);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.IdParent);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.Estate);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.Level);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.Estate);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.UserInsert);
                oCmd.Parameters.AddWithValue("@pIdMenu", pMenu.DateInsert);
                oCmd.ExecuteNonQuery();
                oCnnData.Close();
                return;
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
        }
        public static List<aeMenu> GetDataByIdUser(int pIdUser, ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeMenu> listMen = new List<aeMenu>();
                SqlCommand oCmd = new SqlCommand("uspMenuSelectByIdUser", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdUser", pIdUser);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();

                if (oRdr.Read())
                {
                    aeMenu oRow = new aeMenu();

                    oRow.IdMenu = Convert.ToInt16(oRdr["IdMenu"].ToString());
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? null : oRdr["Name"].ToString();
                    oRow.Level = (oRdr["Level"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["Level"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) == 1 ? true : false;
                    oRow.IdParent = (oRdr["IdParent"] == DBNull.Value) ? 0 : Convert.ToInt16(oRdr["IdParent"]);
                    listMen.Add(oRow);
                }

                oCnnData.Close();
                return listMen;
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
