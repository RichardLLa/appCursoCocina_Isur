﻿using System;
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
        public static List<aeRole> GetRow(int pIdUser, ref string pResult)
        {
            List<aeRole> oList = daRole.GetData(pIdUser,ref pResult);
            foreach (var item in oList)
            {
                blMenu blMenu = new blMenu();
            }
            return oList;
        }
    }
}