using AE;
using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class blProduct
    {
        public List<aeProduct> GetRows(ref string pResult, int pIdCategory)
        {
            return daProduct.GetData(ref pResult, pIdCategory);
        }
        public aeProduct GetRowById(ref string pResult, int pIdProduct)
        {
            return daProduct.GetDataById(ref pResult, pIdProduct);
        }
        public List<aeProduct> GetRowsSearch(ref string pResult, string pSearch)
        {
            return daProduct.GetDataSearch(ref pResult, pSearch);
        }
    }
}
