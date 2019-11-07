using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AE;
using System.Reflection;
using MetroFramework.Controls;

namespace App_AcademicManagement
{
    public partial class userCMenu : UserControl
    {
        int xPosicion = 20;
        int yPosicion = 20;
        int xSize = 225;
        int ySize = 130;
        int NumPorX = 3;
        Dictionary<aeMenu,Panel> dicMenus = new Dictionary<aeMenu, Panel>();
        MetroPanel pnlPrincipal;
        MetroFramework.Forms.MetroForm Padre;
        public int IdModulo { get; }
        public userCMenu()
        {
            InitializeComponent();
        }
        public userCMenu(List<aeMenu> menus,int idModulo,MetroFramework.Forms.MetroForm padre, MetroPanel pPnlPrincipal)
        {
            InitializeComponent();
            Padre = padre;
            pnlPrincipal = pPnlPrincipal;
            IdModulo = idModulo;
            foreach (var item in menus)
            {
                dicMenus.Add(item,Agregar(item.Descripcion, item.Codigo,item.Objeto));
            }
        }
        public void VerificarEspacio()
        {
            double result = this.Size.Width / 225;
            int x =Convert.ToInt16( Math.Floor(result));
            if (x != NumPorX)
            {
                NumPorX = x;
                int contadorx = 0;
                int contadory = 0;
                foreach (var item in dicMenus.Values)
                {
                    item.Location = new Point(xSize * contadorx + 15, ySize * contadory + 15);
                    contadorx++;
                    if (contadorx == NumPorX)
                    {
                        contadorx = 0;
                        contadory++;
                    }
                }
            }
        }
        public Panel Agregar(string nombre,string img,string objetoRuta)
        {
            //Imagen
            PictureBox picMenu = new PictureBox();
            picMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMenu.Image = (Image)Properties.Resources.ResourceManager.GetObject(img);
            picMenu.Location = new Point(126, 20);
            picMenu.Name = img;
            picMenu.Size = new Size(57, 59);
            picMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenu.Cursor = Cursors.Hand;
            picMenu.TabIndex = 2;
            picMenu.TabStop = false;
            picMenu.Tag = objetoRuta.ToString();
            picMenu.Click += PicMenu_Click;
            picMenu.MouseEnter += PicMenu_MouseEnter;
            picMenu.MouseLeave += PicMenu_MouseLeave;

            //Label
            nombre = nombre.Replace(" - ", "//-").Replace(" / ", "//-");
            nombre = nombre.Replace("/-", "\n").Replace(" ", "\n");
            Label lblMenu = new Label();
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lblMenu.ForeColor = Color.White;
            lblMenu.Location = new Point(16, 13);
            lblMenu.Size = new Size(92, 19);
            lblMenu.Cursor = Cursors.Hand;
            lblMenu.TabIndex = 0;
            lblMenu.Text = nombre;
            lblMenu.Tag = objetoRuta.ToString();
            lblMenu.Click += LblMen_Click;

            //Panel
            Panel pnlMenu = new Panel();
            pnlMenu.BackColor = Color.RoyalBlue;
            pnlMenu.Location = new Point(xPosicion, yPosicion);
            pnlMenu.Size = new Size(190, 100);
            pnlMenu.Cursor = Cursors.Hand;
            pnlMenu.Tag = objetoRuta.ToString();
            pnlMenu.Click += PnlMenu_Click;
            pnlMenu.Controls.Add(picMenu);
            pnlMenu.Controls.Add(lblMenu);
            this.Controls.Add(pnlMenu);
            return pnlMenu;
        }

        private void PicMenu_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.Image = (Image)Properties.Resources.ResourceManager.GetObject(p.Name);
        }

        private void PicMenu_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.Image = (Image)Properties.Resources.ResourceManager.GetObject(p.Name + "2");
        }

        private void PicMenu_Click(object sender, EventArgs e)
        {
            string RutaFrm = ((PictureBox)sender).Tag.ToString();
            AbrirFormulario(RutaFrm);
        }

        private void LblMen_Click(object sender, EventArgs e)
        {
            string RutaFrm = ((Label)sender).Tag.ToString();
            AbrirFormulario(RutaFrm);
        }

        private void PnlMenu_Click(object sender, EventArgs e)
        {
            string RutaFrm = ((Panel)sender).Tag.ToString();
            AbrirFormulario(RutaFrm);
        }
        private void AbrirFormulario(string ruta)
        {
            try
            {
                MetroFramework.Forms.MetroForm oForm = new MetroFramework.Forms.MetroForm();
                string dll = "UI2";
                Assembly assCadena = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + dll + ".dll");
                oForm = (MetroFramework.Forms.MetroForm)assCadena.CreateInstance(ruta);
                oForm.MdiParent = Padre;
                oForm.FormClosed += OForm_FormClosed;
                //oForm.Dock = DockStyle.Fill;
                oForm.StartPosition = FormStartPosition.CenterParent;
                oForm.BringToFront();
                oForm.Show();
                pnlPrincipal.Visible = false;
            }
            catch (Exception ex)
            {
                //throw new Exception();
            }
        }

        private void OForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnlPrincipal.Visible = true;
        }

        private void userCMenu_Resize(object sender, EventArgs e)
        {
            VerificarEspacio();
        }
    }
}
