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
        //daUser oDA = new daUser();
        public bool CreateUser(aeUser pUser, ref string result)
        {
            pUser.Estate = true;
            return daUser.CreateUser(pUser,ref result);
        }
        public bool PasswordChange(aeUser pUser, ref string result)
        {
             return daUser.PasswordChange(pUser,ref result);
        }
        public aeUser GetRow(int pIdUsuario)
        {
            return daUser.GetData(pIdUsuario);
        }
        public aeUser GetRow(string pUser,string pPassword, ref string pResult)
        {
            pResult = null;
            aeUser oRow = new aeUser();
            oRow = daUser.GetData( pUser,  pPassword, ref  pResult);
            if (pResult != null) return null;
            //roles del usuario

            blRole rol = new blRole();
            oRow.ListRoles = rol.GetRows(oRow.IdUser, ref pResult);
            return oRow;
        }
    }
}
