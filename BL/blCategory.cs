using System;
using AE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;

namespace BL
{
    public class blCategory
    {
        public List<aeCategory> GetRows(ref string pResult)
        {
            return daCategory.GetData( ref pResult);
            //foreach (var item in oList)
            //{
            //    blMenu blMenu = new blMenu();
            //}
            //return oList;
        }
    }
}
