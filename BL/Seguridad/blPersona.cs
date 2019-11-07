using AE;
using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blPersona
    {
        daPersona oDA = new daPersona();
        public aePersona GetRow(int pIdPersona)
        {
            return oDA.GetData(pIdPersona);
        }
    }
}
