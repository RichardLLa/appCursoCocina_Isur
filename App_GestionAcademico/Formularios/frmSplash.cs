using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_AcademicManagement
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            lblTiempo.Text = contador + "%";
            if (contador > 100)
            {
                timer1.Enabled = false;
                Thread.Sleep(400);
                this.Close();
            }
        }
    }
}
