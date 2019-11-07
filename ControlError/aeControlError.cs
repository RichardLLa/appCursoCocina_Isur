using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ControlError
{
    public class aeControlError
    {
        public aeControlError()
        {
            Ruta = Directory.GetCurrentDirectory();
            NombreEquipo = Environment.MachineName;
            IpEquipo = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(ip => ip.AddressFamily.ToString().ToUpper().Equals("INTERNETWORK")).FirstOrDefault().ToString();
            //RutaProyecto = this.ToString();
        }
        public int IdControlError { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public int Numero { get; set; }
        public string Usuario { get; set; }
        public string CapaProyecto { get; set; }
        public int Gravedad { get; set; }
        public string ProcAlmacenado { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public string Ruta { get; set; }
        public string RutaProyecto { get; set; }
        public string NombreEquipo { get; set; }
        public string IpEquipo { get; set; }
    }
}
