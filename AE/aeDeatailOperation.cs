using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public class aeDeatailOperation : aeProduct
    {
        public aeDeatailOperation(string pProductName,int pIdProduct,double pQuantity,double pUnitPrice)
            :base(pProductName,pUnitPrice)
        {
            Quantity = pQuantity;
        }
        public int IdDetailOperation { get; set; }
        public int IdOperation       { get; set; }
        public double Quantity       { get; set; }
    }
}
