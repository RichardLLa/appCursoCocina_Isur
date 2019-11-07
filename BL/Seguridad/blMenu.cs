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
        daMenu oDA = new daMenu();
        public List<aeMenu> GetRows()
        {
            return oDA.GetData();
        }
    }
}
