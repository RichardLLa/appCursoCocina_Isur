using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AE;
using DA;

namespace BL
{
    public class blRole
    {
        public List<aeRole> GetRows(int pIdUser, ref string pResult)
        {
            return daRole.GetDataByUser(pIdUser,ref pResult);
            //foreach (var item in oList)
            //{
            //    blMenu blMenu = new blMenu();
            //}
            //return oList;
        }

        public List<aeRole> GetRowByIdMenu(int pIdMenu, ref string pResult)
        {
            return daRole.GetDataByIdMenu(pIdMenu, ref pResult);
        }
    }
}
