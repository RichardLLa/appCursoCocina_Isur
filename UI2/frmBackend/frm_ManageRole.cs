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
    public partial class frm_ManageRole : MetroForm
    {
        #region Variables
        private int IdMenuSelec;
        private List<aeRole> listRoles;
        private List<aeRole> listRolesActivos= new List<aeRole>();
        private List<aeRole> listRolesNoActivos = new List<aeRole>();
        blRole blRol = new blRole();
        blPermission blPer = new blPermission();
        private static string error= null;
        #endregion
        public frm_ManageRole()
        {
            InitializeComponent();
        }
        public frm_ManageRole(int pIdMenu)
        {
            InitializeComponent();
            listRoles = blRol.GetRowByIdMenu(pIdMenu,ref error);
            IdMenuSelec = pIdMenu;
            if (error!= null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                return;
            }
            cargaInicial();
        }
        private void cargaInicial()
        {
            listRolesActivos.Clear();
            listRolesNoActivos.Clear();
            foreach (var item in listRoles)
            {
                if (item.Estate == true)
                {
                    listRolesActivos.Add(item);
                }
                else
                {
                    listRolesNoActivos.Add(item);
                }
            }
            this.lbxRolesActivos.DataSource = null;
            this.lbxRolesActivos.DisplayMember = "Name";
            this.lbxRolesActivos.ValueMember = "IdRole";
            this.lbxRolesActivos.DataSource = listRolesActivos;

            this.lbxRolesNoActivos.DataSource = null;
            this.lbxRolesNoActivos.DisplayMember = "Name";
            this.lbxRolesNoActivos.ValueMember = "IdRole";
            this.lbxRolesNoActivos.DataSource = listRolesNoActivos;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActivarRol()
        {
            if (this.lbxRolesNoActivos.Items.Count == 0) return;
            string b = lbxRolesNoActivos.SelectedItem.ToString();
            int idRolSel = Convert.ToInt32(lbxRolesNoActivos.SelectedValue);
            error = null;
            blPer.InsertRow(null, idRolSel, IdMenuSelec, ref error);
            if (error != null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            ActualizarDatos();
        }
        private void DesactivarRol()
        {
            if (this.lbxRolesActivos.Items.Count == 0) return;
            //int Id_Aplicacion = (string)cboAplicaciones.SelectedValue;
            string b = lbxRolesActivos.SelectedItem.ToString();
            int idRolSel = Convert.ToInt32(lbxRolesActivos.SelectedValue);
            error = null;
            blPer.deleteRow(null, idRolSel, IdMenuSelec, ref error);
            if (error!= null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            ActualizarDatos();
        }
        private void ActualizarDatos()
        {
            listRoles = blRol.GetRowByIdMenu(IdMenuSelec, ref error);
            if (error != null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
                return;
            }
            cargaInicial();
        }

        private void btnDesabilitar_Click(object sender, EventArgs e)
        {
            DesactivarRol();
        }

        private void Habilitar_Click(object sender, EventArgs e)
        {
            ActivarRol();
        }
    }
}
