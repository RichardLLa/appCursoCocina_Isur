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
    public class daPerson
    {
        public static aePerson GetData(int pIdPersona)
        {
            aePerson oRow = new aePerson();
            SqlConnection oCnnData = daConnection.Connect();
            SqlCommand oCmd = new SqlCommand();
            oCmd.CommandType = CommandType.StoredProcedure;
            oCmd.Parameters.Clear();
            oCmd.CommandText = "spPersonaSelectByIdPersona";
            oCmd.Connection = oCnnData;
            oCmd.Parameters.AddWithValue("@IdPersona", pIdPersona);
            SqlDataReader oRdr;
            oRdr = oCmd.ExecuteReader();
            while (oRdr.Read())
            {
                oRow.IdPerson = Convert.ToInt16(oRdr["IdPersona"].ToString());
                oRow.FirtsName = (oRdr["Nombre"] == DBNull.Value) ? null : oRdr["Nombre"].ToString();
                oRow.LastName = (oRdr["Apellidos"] == DBNull.Value) ? null : oRdr["Apellidos"].ToString();
                oRow.Telephone = (oRdr["Telefono"] == DBNull.Value) ? null : oRdr["Telefono"].ToString();
                oRow.NroDocument = (oRdr["Documento"] == DBNull.Value) ? null : oRdr["Documento"].ToString();
                oRow.NroDocument = (oRdr["NroDocumento"] == DBNull.Value) ? null: oRdr["NroDocumento"].ToString();
                oRow.Mail = (oRdr["Correo"] == DBNull.Value) ?null : oRdr["Correo"].ToString();
            }
            oCnnData.Close();
            return oRow;
        }
    }
}
