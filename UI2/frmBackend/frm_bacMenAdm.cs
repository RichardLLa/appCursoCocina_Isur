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
using BL;
using AE;
using MetroFramework;
using BL.Util;
using UI2.Util;

namespace UI2
{
    public partial class frm_bacMenAdm : MetroForm
    {
        public frm_bacMenAdm()
        {
            InitializeComponent();
            CargarInicial();
        }

        #region Variables
        static string error = null;
        List<aeMenu> listModulo;// = new List<aeMenu>();
        List<aeMenu> listMenu = new List<aeMenu>();
        List<aeMenu> listPermisos = new List<aeMenu>();
        blMenu blMen = new blMenu();
        aeMenu aeMen = new aeMenu();
        #endregion

        #region Metodos
        private void CargarInicial()
        {
            listModulo = null;
            listModulo = blMen.GetRowsByParent(0, ref error);

            this.lbxPermisos.DataSource = null;
            cboModulos.DataSource = null;

            if (listModulo != null)
            {

                cboModulos.DisplayMember = "Name";
                cboModulos.ValueMember = "IdMenu";
                cboModulos.DataSource = listModulo;
            }
        }
        private void CargarMenus(int IdModulo)
        {

            error = null;
            listMenu = blMen.GetRowsByParent(IdModulo, ref error);

            cboMenus.DataSource = null;
            this.lbxPermisos.DataSource = null;

            if (listMenu != null)
            {
                cboMenus.DisplayMember = "Name";
                cboMenus.ValueMember = "IdMenu";
                cboMenus.DataSource = listMenu;
            }

        }
        private void CargarPermisos(int IdMenu)
        {
            error = null;
            listPermisos = this.blMen.GetRowsByParent(IdMenu, ref error);

            this.lbxPermisos.DataSource = null;

            if (listPermisos != null)
            {

                this.lbxPermisos.DisplayMember = "Name";
                this.lbxPermisos.ValueMember = "IdMenu";
                this.lbxPermisos.DataSource = listPermisos;
            }
        }
        private void CargarDatos(int idMenu)
        {
            aeMen = blMen.GetRow(idMenu, ref error);
            if (aeMen != null)
            {
                txtIdMenu.Text = aeMen.IdMenu.ToString();
                txtNombre.Text = aeMen.Name.ToString();
                txtCodigo.Text = aeMen.NameCode.ToString();
                txtIdAplicacion.Text = aeMen.IdApplication.ToString();
                txtLevel.Text = aeMen.Level.ToString();
                chkEstado.Checked = aeMen.Estate;
                switch (aeMen.Level)
                {
                    case 1:
                        this.cboPadre.DataSource = null;
                        break;
                    case 2:
                        this.cboPadre.DisplayMember = "Name";
                        this.cboPadre.ValueMember = "IdMenu";
                        this.cboPadre.DataSource = listModulo;
                        break;
                    case 3:
                        this.cboPadre.DisplayMember = "Name";
                        this.cboPadre.ValueMember = "IdMenu";
                        this.cboPadre.DataSource = listMenu;
                        break;
                }
            }
        }
        #endregion

        #region Eventos
        bool moduloClick;
        private void cboModulos_Enter(object sender, EventArgs e)
        {
            moduloClick = true;

        }

        private void cboModulos_Leave(object sender, EventArgs e)
        {
            moduloClick = false;

        }
        private void cboModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdModulo = Convert.ToInt32(cboModulos.SelectedValue);
            CargarMenus(IdModulo);
            if (moduloClick)
            {
                CargarDatos(IdModulo);
                selecionado = true;
            }
        }

        bool menuClick;

        private void cboMenus_Enter(object sender, EventArgs e)
        {
            menuClick = true;

        }

        private void cboMenus_Leave(object sender, EventArgs e)
        {
            menuClick = false;

        }
        private void cboMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdMenu = Convert.ToInt32(cboMenus.SelectedValue);
            CargarPermisos(IdMenu);
            if (menuClick)
            {
                CargarDatos(IdMenu);
                selecionado = true;
            }
        }

        private void lbxPermisos_MouseClick(object sender, MouseEventArgs e)
        {
            int IdPermiso = Convert.ToInt32(lbxPermisos.SelectedValue);
            selecionado = true;
            CargarDatos(IdPermiso);
        }



        #endregion
        private bool selecionado;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (selecionado)
            {
                if (VerificarDatos())
                {
                    error = null;
                    blMen.UpdateRow(aeMen, ref error);
                    if (error != null)
                    {
                        MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                CargarInicial();
            }
        }

        private bool VerificarDatos()
        {
            if (txtNombre.Text == string.Empty)
            {
                errorProvider1.SetError(txtNombre, "Ingrese un dato.");
                txtNombre.Focus();
                return false;
            }
            aeMen.Name = txtNombre.Text;
            aeMen.NameCode = txtCodigo.Text;
            try
            {
                aeMen.IdApplication = Convert.ToInt32(txtIdAplicacion.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(txtIdAplicacion, "Ingrese un dato del tipo entero.");
                txtIdAplicacion.Focus();
                return false;
            }
            try
            {
                    aeMen.Level = Convert.ToInt32(txtLevel.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(txtLevel, "Ingrese un dato del tipo entero.");
                txtLevel.Focus();
                return false;
            }
            aeMen.IdParent = cboPadre.SelectedValue == null? 0:Convert.ToInt32(cboPadre.SelectedValue);
            aeMen.Estate = chkEstado.Checked;
            aeMen.UserUpdate = "Admin";
            error = null;
            aeMen.DateUpdate = ManagerUtil.getDateTimeServer(ref error);
            if (error!=null)
            {
                MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            if (selecionado)
            {
                frm_ManageRole frmRol = new frm_ManageRole(aeMen.IdMenu);
                frmRol.ShowDialog();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (selecionado)
            {
                frm_ManageUsers frmUser = new frm_ManageUsers(aeMen.IdMenu);
                frmUser.ShowDialog();
            }
        }
    }
}
