using System;
using DA;
using AE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blSesion
    {
        daSesion oSesion = new daSesion();
        public aeUser ValidateUser(aeUser pUser)
        {
            return oSesion.ValidateUser(pUser);
        } 
        public aeSesion IniciarSesion(aeUser pUser)
        {
            return oSesion.IniciarSesion(pUser);
        }
        public bool CerrarSesion(aeSesion pSesion)
        {
            return oSesion.CerrarSesion(pSesion);
        }
    }
}
