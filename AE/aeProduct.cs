using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public class aeProduct
    {
        public aeProduct()
        {

        }
        public aeProduct(string pName, double pUnitPrice)
        {
            Name = pName;
            UnitPrice = pUnitPrice;
        }

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string CodeCategory { get; set; }
        public double UnitPrice { get; set; }
        public int IdCategory { get; set; }
        public int IdMeasure { get; set; }
        public double Stock { get; set; }
        public bool Estate { get; set; }
        public string RowVersion { get; set; }
        public string UserInsert { get; set; }
        public string UserUpdate { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
    }

}
