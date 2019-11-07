using System;
using DA;
using AE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blModulo
    {
        daModulo oDA = new daModulo();
        public List<aeModulo> GetRows()
        {
            return oDA.GetData();
        }
        public List<aeModulo> GetRow(int pIdUsuario)
        {
            return oDA.GetData(pIdUsuario);
        }
    }
}
