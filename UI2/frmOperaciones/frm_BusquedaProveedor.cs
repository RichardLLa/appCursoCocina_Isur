using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace UI2.frmOperaciones
{
    public partial class frm_BusquedaProveedor : MetroForm
    {

        public frm_BusquedaProveedor()
        {
            InitializeComponent();
            CargaInicial();
        }

        #region Variables
        public string Documento = null;
        public string NombresCompletos = null;
        #endregion
        #region Eventos

        private void CargaInicial()
        {

        }
        #endregion

        private void frm_BusquedaProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarActualizarClick(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
