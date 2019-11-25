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
        public aeSession Login(string pAlias, string pPassword, ref string pResult)
        {
            pResult = null;
            aeSession sesion = new aeSession();

            //Recopilar informacion del usuario
            blUser user = new blUser();
            sesion.User = user.GetRow(pAlias, pPassword, ref pResult);
            if (pResult != null) return null;

            //obtener los menus
            blMenu menu = new blMenu();
            sesion.ListMenuGranted = menu.GetRows(sesion.User.IdUser, ref pResult);
            return sesion;
        }
        public bool CerrarSesion(aeSession pSesion)
        {
            return oSesion.CerrarSesion(pSesion);
        }
    }
}
