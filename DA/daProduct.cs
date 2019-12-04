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
    public class daProduct
    {
        public static aeProduct GetDataById(ref string pResult, int pIdProduct)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                aeProduct oRow = null;
                SqlCommand oCmd = new SqlCommand("uspProductSelectById", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdProduct", pIdProduct);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                if (oRdr.Read())
                {
                    oRow = new aeProduct();
                    oRow.IdProduct = Convert.ToInt16(oRdr["IdProduct"]);
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? "" : oRdr["Name"].ToString();
                    oRow.CodeCategory = (oRdr["CodeCategory"] == DBNull.Value) ? "" : oRdr["CodeCategory"].ToString();
                    oRow.UnitPrice = oRdr["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDouble(oRdr["UnitPrice"]);
                    oRow.IdCategory = oRdr["IdCategory"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["IdCategory"]);
                    oRow.IdMeasure = oRdr["IdMeasure"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["IdMeasure"]);
                    oRow.Stock = oRdr["Stock"] == DBNull.Value ? 0 : Convert.ToDouble(oRdr["Stock"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) == 1 ? true : false;
                    oRow.RowVersion = (oRdr["RowVersion"] == DBNull.Value) ? "" : oRdr["RowVersion"].ToString();
                }

                oCnnData.Close();
                return oRow;
                //pResult = "El usuario no tienen ningun ROL asignado, consulte con el administrador.";
                //pResult = oCmd.Parameters["@pResult"].Value.ToString();
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
            return null;
        }
        public static List<aeProduct> GetData(ref string pResult, int pIdCategory)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeProduct> oLista = new List<aeProduct>();
                SqlCommand oCmd = new SqlCommand("uspProductSelectByCategory", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pIdCategory", pIdCategory);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                while (oRdr.Read())
                {
                    aeProduct oRow = new aeProduct();
                    oRow.IdProduct = Convert.ToInt16(oRdr["IdProduct"]);
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? "" : oRdr["Name"].ToString();
                    oRow.CodeCategory = (oRdr["CodeCategory"] == DBNull.Value) ? "" : oRdr["CodeCategory"].ToString();
                    oRow.UnitPrice = oRdr["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDouble(oRdr["UnitPrice"]);
                    oRow.IdCategory = oRdr["IdCategory"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["IdCategory"]);
                    oRow.IdMeasure = oRdr["IdMeasure"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["IdMeasure"]);
                    oRow.Stock = oRdr["Stock"] == DBNull.Value ? 0 : Convert.ToDouble(oRdr["Stock"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) == 1 ? true : false;
                    oRow.RowVersion = (oRdr["RowVersion"] == DBNull.Value) ? "" : oRdr["RowVersion"].ToString();

                    oLista.Add(oRow);
                }

                oCnnData.Close();
                return oLista;
                //pResult = "El usuario no tienen ningun ROL asignado, consulte con el administrador.";
                //pResult = oCmd.Parameters["@pResult"].Value.ToString();
            }
            catch (Exception ex)
            {
                pResult = ex.Message;
            }
            oCnnData.Close();
            return null;
        }

        public static List<aeProduct> GetDataSearch(ref string pResult,string pSearch)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeProduct> oLista = new List<aeProduct>();
                SqlCommand oCmd = new SqlCommand("uspProductSearch", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                oCmd.Parameters.AddWithValue("@pSearch", pSearch);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                while (oRdr.Read())
                {
                    aeProduct oRow = new aeProduct();
                    oRow.IdProduct = Convert.ToInt16(oRdr["IdProduct"]);
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? "" : oRdr["Name"].ToString();
                    oRow.CodeCategory = (oRdr["CodeCategory"] == DBNull.Value) ? "" : oRdr["CodeCategory"].ToString();
                    oRow.UnitPrice = oRdr["UnitPrice"] == DBNull.Value ? 0 : Convert.ToDouble(oRdr["UnitPrice"]);
                    oRow.IdCategory = oRdr["IdCategory"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["IdCategory"]);
                    oRow.IdMeasure = oRdr["IdMeasure"] == DBNull.Value ? 0 : Convert.ToInt16(oRdr["IdMeasure"]);
                    oRow.Stock = oRdr["Stock"] == DBNull.Value ? 0 : Convert.ToDouble(oRdr["Stock"]);
                    oRow.Estate = (oRdr["Estate"] == DBNull.Value) ? false : Convert.ToInt16(oRdr["Estate"]) == 1 ? true : false;
                    oRow.RowVersion = (oRdr["RowVersion"] == DBNull.Value) ? "" : oRdr["RowVersion"].ToString();

                    oLista.Add(oRow);
                }

                oCnnData.Close();
                return oLista;
                //pResult = "El usuario no tienen ningun ROL asignado, consulte con el administrador.";
                //pResult = oCmd.Parameters["@pResult"].Value.ToString();
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
