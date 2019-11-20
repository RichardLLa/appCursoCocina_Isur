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
        daPerson oDA = new daPerson();
        public aePerson GetRow(int pIdPersona)
        {
            return oDA.GetData(pIdPersona);
        }
    }
}
