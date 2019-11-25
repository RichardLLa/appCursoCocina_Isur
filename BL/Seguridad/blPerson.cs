using AE;
using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blPerson
    {
        public aePerson GetRow(int pIdPersona)
        {
            return daPerson.GetData(pIdPersona);
        }
    }
}
