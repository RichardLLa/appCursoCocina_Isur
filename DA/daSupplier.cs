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
    public class daSupplier
    {
        public static List<aeSupplier> GetData( ref string pResult)
        {
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                List<aeSupplier> oLista = new List<aeSupplier>();
                SqlCommand oCmd = new SqlCommand("uspSupplierSelect", oCnnData);
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.Parameters.Clear();
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                while (oRdr.Read())
                {
                    aeSupplier oRow = new aeSupplier();
                    oRow.IdPerson = (oRdr["IdPerson"] == DBNull.Value) ? 0 :Convert.ToInt32(oRdr["IdPerson"]);
                    oRow.FirtsName = (oRdr["FirtsName"] == DBNull.Value) ? null : oRdr["FirtsName"].ToString();
                    oRow.LastName = (oRdr["LastName"] == DBNull.Value) ? null : oRdr["LastName"].ToString();
                    oRow.Telephone = (oRdr["Telephone"] == DBNull.Value) ? null : oRdr["Telephone"].ToString();
                    oRow.TypeDocument = (oRdr["TypeDocument"] == DBNull.Value) ? 0 :Convert.ToInt32(oRdr["TypeDocument"]);
                    oRow.NroDocument = (oRdr["NroDocumento"] == DBNull.Value) ? null : oRdr["NroDocumento"].ToString();
                    oRow.Mail = (oRdr["Mail"] == DBNull.Value) ? null : oRdr["Mail"].ToString();
                    oRow.IdSupplier = (oRdr["IdSupplier"] == DBNull.Value) ? 0 :Convert.ToInt32(oRdr["IdSupplier"]);
                    oRow.CompanyName = (oRdr["CompanyName"] == DBNull.Value) ? null : oRdr["CompanyName"].ToString();
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
    }
}
