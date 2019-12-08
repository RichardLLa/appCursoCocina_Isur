using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AE;
using DA;

namespace BL
{
    public class blPermission
    {
     
        public void InsertRow(int? pUser, int? pRole, int pMenu, ref string pResult)
        {
            daPermission.InsertData( pUser,  pRole, pMenu, ref  pResult);
        }
        public void deleteRow(int? pUser, int? pRole, int pMenu, ref string pResult)
        {
             daPermission.DeleteData( pUser,  pRole, pMenu,ref  pResult);
        }
    }
}
