using DA.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Util
{
    public static class blDateTimeServer
    {
        public static DateTime? GetDateTimeServer(ref string pResult)
        {
            return daDateTimeServer.GetDateTimeServer(ref pResult);
        }
    }
}
