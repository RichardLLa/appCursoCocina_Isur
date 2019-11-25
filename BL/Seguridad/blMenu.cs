using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using AE;

namespace BL
{
    public class blMenu
    {
        public List<aeMenu> GetRows(int pIdUser, ref string pResult)
        {
            List<aeMenu> oList = daMenu.GetDataByUser(pIdUser, ref pResult);
            return oList;
        }
    }
}
