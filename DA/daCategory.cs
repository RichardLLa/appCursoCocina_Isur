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
    public class daCategory
    {
        public static List<aeCategory> GetData(ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeCategory> oLista = new List<aeCategory>();
                SqlCommand oCmd = new SqlCommand("uspCategorySelect", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                //oCmd.Parameters.AddWithValue("@NROINSCRITOS", DbType.Int32);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                while (oRdr.Read())
                {
                    aeCategory oRow = new aeCategory();
                    oRow.IdCategory = Convert.ToInt16(oRdr["IdCategory"].ToString());
                    oRow.Name = (oRdr["Name"] == DBNull.Value) ? "" : oRdr["Name"].ToString();
                    oRow.Code = (oRdr["Code"] == DBNull.Value) ? "" : oRdr["Code"].ToString();
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
