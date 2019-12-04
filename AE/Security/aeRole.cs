using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public class aeRole
    {
        public int IdRole { get; set; }
        public string Name { get; set; }
        public bool Estate { get; set; }
        public List<aeMenu> Menus { get; set; }
    }
}
