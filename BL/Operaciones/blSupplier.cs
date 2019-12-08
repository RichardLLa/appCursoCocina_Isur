using AE;
using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blSupplier
    {
        public List<aeSupplier> GetRows(ref string pResult)
        {
            return daSupplier.GetData(ref pResult);
        }
    }
}
