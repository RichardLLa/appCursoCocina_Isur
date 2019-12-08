using AE;
using BL;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI2
{
    public partial class frm_ManageUsers : MetroForm
    {
        #region Variables
        private int IdMenuSelec;
        private List<aeUser> listUsuarios;
        private List<aeUser> listUsuariosActivos = new List<aeUser>();
        private List<aeUser> listUsuariosNoActivos = new List<aeUser>();
        blUser blUser = new blUser();
        blPermission blPer = new blPermission();
        private static string error = null;
        #endregion
        public frm_ManageUsers()
        {
            InitializeComponent();
        }

        public frm_ManageUsers(int pIdMenu)
        {
            InitializeComponent();
            listUsuarios = blUser.GetRowByIdMenu(pIdMenu, ref error);
            IdMenuSelec = pIdMenu;
            if (error != null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            cargaInicial();
        }
        private void cargaInicial()
        {
            listUsuariosActivos.Clear();
            listUsuariosNoActivos.Clear();
            foreach (var item in listUsuarios)
            {
                if (item.Estate == true)
                {
                    listUsuariosActivos.Add(item);
                }
                else
                {
                    listUsuariosNoActivos.Add(item);
                }
            }
            this.lbxUsuariosActivos.DataSource = null;
            this.lbxUsuariosActivos.DisplayMember = "Alias";
            this.lbxUsuariosActivos.ValueMember = "IdUser";
            this.lbxUsuariosActivos.DataSource = listUsuariosActivos;

            this.lbxUsuariosNoActivos.DataSource = null;
            this.lbxUsuariosNoActivos.DisplayMember = "Alias";
            this.lbxUsuariosNoActivos.ValueMember = "IdUser";
            this.lbxUsuariosNoActivos.DataSource = listUsuariosNoActivos;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActivarRol()
        {
            if (this.lbxUsuariosNoActivos.Items.Count == 0) return;
            string b = lbxUsuariosNoActivos.SelectedItem.ToString();
            int idUserSel = Convert.ToInt32(lbxUsuariosNoActivos.SelectedValue);
            error = null;
            blPer.InsertRow(idUserSel, null, IdMenuSelec, ref error);
            if (error != null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            ActualizarDatos();
        }
        private void DesactivarRol()
        {
            if (this.lbxUsuariosActivos.Items.Count == 0) return;
            //int Id_Aplicacion = (string)cboAplicaciones.SelectedValue;
            string b = lbxUsuariosActivos.SelectedItem.ToString();
            int idUserSel = Convert.ToInt32(lbxUsuariosActivos.SelectedValue);
            error = null;
            blPer.deleteRow(idUserSel, null, IdMenuSelec, ref error);
            if (error != null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            ActualizarDatos();
        }
        private void ActualizarDatos()
        {
            listUsuarios = blUser.GetRowByIdMenu(IdMenuSelec, ref error);
            if (error != null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                return;
            }
            cargaInicial();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            DesactivarRol();
        }

        private void Habilitar_Click(object sender, EventArgs e)
        {
            ActivarRol();
        }
    }
}
