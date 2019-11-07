using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public class aeUser
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Estado { get; set; }
        public int IdPersona{ get; set; }
    }
}
