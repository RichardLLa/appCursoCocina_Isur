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
        public void CreateUser(aeUser pUser)
        {
            pUser.Estado = true;
            oDA.CreateUser(pUser);
        }
        public void CambiarContraseña(aeUser pUser)
        {
              oDA.CambiarContraseña(pUser);
        }
        public aeUser GetRow(int pIdUsuario)
        {
            return oDA.GetData(pIdUsuario);
        }

    }
}
