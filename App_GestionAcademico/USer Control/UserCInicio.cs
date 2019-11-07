using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_AcademicManagement
{
    public partial class UserCInicio : UserControl
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                this.lblTitulo.Text = "Bienvenido " + nombre;
            }
        }
        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value;
                this.lblDetalle.Text = detalle;
            }
        }


        public UserCInicio()
        {
            InitializeComponent();
        }
        public UserCInicio(string nombre,string detalle)
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
