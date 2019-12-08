using BL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI2.Util
{
    public static class ManagerUtil
    {
        public static DateTime? getDateTimeServer(ref string pResult)
        {
            return blDateTimeServer.GetDateTimeServer(ref pResult);
        }
    }
}
