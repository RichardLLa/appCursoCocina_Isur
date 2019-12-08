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
    public partial class frm_ManageMenu : MetroForm
    {
        #region Variables
        private int IdSelec;
        private List<aeMenu> listPermisos;
        private List<aeMenu> listModulos = new List<aeMenu>();
        private List<aeMenu> listMenus= new List<aeMenu>()  ;
        private List<aeMenu> listPermisosActivos = new List<aeMenu>();
        private List<aeMenu> listPermisosNoActivos = new List<aeMenu>();
        blMenu blMen = new blMenu();
        blPermission blPer = new blPermission();
        private static string error = null;
        bool OptionUser; 
        #endregion
        public frm_ManageMenu()
        {
            InitializeComponent();
        }
        public frm_ManageMenu(int pIdUserOrRole,bool pUser)
        {
            InitializeComponent();
            OptionUser = pUser;
            IdSelec = pIdUserOrRole;
            if (pUser)
            {
                listPermisos = blMen.GetRowsByIdUser(pIdUserOrRole, ref error);
                if (error != null)
                {
                    MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    return;
                }
            }
            else
            {
               //listPermisos = blMen.GetRowByIdUser(pIdUserOrRole, ref error);
               //IdMenuSelec = pIdMenu;
               //if (error != null)
               //{
               //    MetroMessageBox.Show(this, error, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               //    this.Close();
               //    return;
               //}
            }
            //cargaInicial();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
