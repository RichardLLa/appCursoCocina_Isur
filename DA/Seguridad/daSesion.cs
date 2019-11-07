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

        public aeUser ValidateUser(aeUser pUser)
        {
            aeUser oRow = new aeUser();
            SqlConnection oCnnData = daConnection.Connect();
            try
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCnnData;
                oCmd.CommandType = CommandType.StoredProcedure;
                oCmd.CommandText = "spValidarUsuario";
                oCmd.Parameters.AddWithValue("@Usuario", pUser.Usuario);
                oCmd.Parameters.AddWithValue("@Contraseña", pUser.Contraseña);
                SqlDataReader oRdr;
                oRdr = oCmd.ExecuteReader();
                if (oRdr.Read())
                {
                    oRow.IdUsuario = oRdr["IdUsuario"] == DBNull.Value ? 0 : Convert.ToInt32(oRdr["IdUsuario"]);
                    oCnnData.Close();
                }
                else
                {
                    oCnnData.Close();
                    throw new Exception("Error desconocido");
                }
                return oRow;
            }
            catch (Exception ex)
            {
                oCnnData.Close();
                throw new Exception(ex.Message);
            }
        }
        public aeSesion IniciarSesion(aeUser pUser)
        {
            aeSesion sesion = new aeSesion();

            //Recopilar informacion del usuario
            daUser usersesion = new daUser();
            sesion.Usuario = usersesion.GetData(pUser.IdUsuario);

            //Informacion de la persona
            daPersona personasesion = new daPersona();
            sesion.Persona = personasesion.GetData(sesion.Usuario.IdPersona);

            //Recopilar informacion de los roles
            daRol sesionrol = new daRol();
            sesion.Roles = sesionrol.GetData(pUser.IdUsuario);

            //Recopilar informacion de los modulos
            daModulo modulosesion = new daModulo();
            sesion.Modulos = modulosesion.GetData(pUser.IdUsuario);

            //Recopilar informacion de los menus
            daMenu menusesion = new daMenu();
            sesion.Menus = menusesion.GetData(pUser.IdUsuario);
            return sesion;
        }

        public bool CerrarSesion(aeSesion pSesion)
        {
            bool salir = false;
            return salir;
        }
    }
}
