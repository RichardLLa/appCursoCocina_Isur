using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public class aeSesion
    {
        public aePersona Persona { get; set; }
        public aeUser Usuario { get; set; }
        public List<aeRol> Roles { get; set; }
        public List<aeModulo> Modulos { get; set; }
        public List<aeMenu> Menus { get; set; }
        public int nivel { get; set; }

    }
}
