using System;
using DA;
using AE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blSession
    {
        daSesion oSesion = new daSesion();
        public int? ValidateUser(string pUser, string pPassword, ref string result)
        {
            return oSesion.ValidateUser(pUser,pPassword,ref result);
        } 
        public aeSession Login(string pUser, string pPassword, ref string pResult)
        {
            pResult = null;
            aeSession sesion = new aeSession();

            //Recopilar informacion del usuario
            blUser user = new blUser();
            sesion.User = user.GetRow(pUser, pPassword, ref pResult);

            //Recopilar informacion de los roles
            

            //Recopilar informacion de los modulos
            daModulo modulosesion = new daModulo();
            sesion.Modulos = modulosesion.GetData(pUser.IdUser);

            //Recopilar informacion de los menus
            daMenu menusesion = new daMenu();
            sesion.Menus = menusesion.GetData(pUser.IdUser);
            return sesion;
        }
        public bool CerrarSesion(aeSession pSesion)
        {
            return oSesion.CerrarSesion(pSesion);
        }
    }
}
