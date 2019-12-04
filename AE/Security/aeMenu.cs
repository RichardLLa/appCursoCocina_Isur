using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public class aeMenu
    {
        public int IdMenu { get; set; }
        public string Name { get; set; }
        public string NameCode { get; set; }
        public int IdApplication { get; set; }
        public int IdParent { get; set; }
        public bool Estate { get; set; }
        public string RowVersion { get; set; }
        public int Level { get; set; }
        
    }
}
