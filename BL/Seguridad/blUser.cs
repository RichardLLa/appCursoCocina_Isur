using AE;
using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blUser
    {
        daUser oDA = new daUser();
        public bool CreateUser(aeUser pUser, ref string result)
        {
            pUser.Estate = true;
            return oDA.CreateUser(pUser,ref result);
        }
        public bool CambiarContraseña(aeUser pUser, ref string result)
        {
             return oDA.CambiarContraseña(pUser,ref result);
        }
        public aeUser GetRow(int pIdUsuario)
        {
            return oDA.GetData(pIdUsuario);
        }
        public aeUser GetRow(string pUser,string pPassword, ref string pResult)
        {
            pResult = null;
            aeUser oRow = new aeUser();
            oRow = oDA.GetData( pUser,  pPassword, ref  pResult);
            if (pResult != null) return null;
            //roles del usuario
            blRole rol = new blRole();
            oRow.ListRoles = rol.GetRow(oRow.IdUser, ref pResult);
            return oRow;
        }
    }
}
