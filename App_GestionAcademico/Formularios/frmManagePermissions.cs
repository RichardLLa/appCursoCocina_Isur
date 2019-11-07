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

namespace App_AcademicManagement
{
    public partial class frmManagePermissions : MetroForm
    {
        public frmManagePermissions(Control frm)
        {
            InitializeComponent();
            RegisterControls(frm);
        }
        public void RegisterControls(Control frm)
        {
            foreach (Control c in frm.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    RegisterControls(c);
                }
                if (c is Button || c is ComboBox || c is TextBox ||
                    c is ListBox || c is DataGridView || c is RadioButton ||
                    c is RichTextBox || c is TabPage)
                {
                    //formToolTip2.SetToolTip(c, c.Name);
                    pageControls.Items.Add(c.Name);
                }
            }
        }
    }
}
