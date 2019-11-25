using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE
{
    public  class aeSession
    {
        public  aeUser User { get; set; }
        public  List<aeMenu> ListMenuGranted { get; set; }
        public  int nivel { get; set; }
        public  DateTime Date { get; set; }
        public  int NroSession { get; set; }
    }
}
