using AE;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace App_AcademicManagement
{
    public partial class frmCargaInicial : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        public frmCargaInicial()
        {
            InitializeComponent();
            CargarInicial();
        }
        public frmCargaInicial(aeSession pSession)
        {
            SessionActivated = pSession;
            InitializeComponent();
            CargarInicial();
            double result = this.Size.Width / 150;
            NumPorX = Convert.ToInt16(Math.Floor(result));
        }
        #endregion

        #region atributos
        private static aeSession SessionActivated = new aeSession();
        private Dictionary<MetroTile, int> dicModule = new Dictionary<MetroTile, int>();
        private Dictionary<MetroTile, int> dictMenu = new Dictionary<MetroTile, int>();
        private MetroTile objMtile = null;
        private bool menuDesplazado;
        private int NumPorX = 3;
        private bool resize;
        private int IdMenuClicked;
        #endregion

        #region Controles Dinamicos

        #region metodos
        
        private void BuildTitle()
        {
            int yPosition = 0;
            foreach (var item in SessionActivated.ListMenuGranted.Where(n => n.Level == 1))
            {
                ToolTip toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 1000;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                MetroButton btnTitulo = new MetroButton();
                btnTitulo.FontSize = MetroButtonSize.Medium;
                btnTitulo.Location = new Point(yPosition, 1);
                btnTitulo.Size = new Size(120, 33);
                btnTitulo.Style = MetroColorStyle.Orange;
                btnTitulo.Text = item.Name;
                btnTitulo.Cursor = Cursors.Hand;
                btnTitulo.TabIndex = 1;
                btnTitulo.Tag = item.IdMenu;
                btnTitulo.Theme = MetroThemeStyle.Dark;
                btnTitulo.UseSelectable = true;
                toolTip.SetToolTip(btnTitulo, item.Name);
                btnTitulo.Click += BtnTitulo_Click;
                yPosition += 120;
                pnlContenedorTitulo.Controls.Add(btnTitulo);
            }

        }
        void BuildModule(int pIdParent, int pIdMenu, string pName, string pNameCode, int xAlto)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            MetroTile metroTile = new MetroTile();

            metroTile.Text = pName;
            metroTile.Name = pNameCode;
            metroTile.Tag = pIdMenu;
            metroTile.TabIndex = 1;
            metroTile.TileImage = (Image)Properties.Resources.ResourceManager.GetObject(pNameCode);
            metroTile.TileTextFontWeight = MetroTileTextWeight.Bold;
            metroTile.Style = MetroColorStyle.Orange;
            metroTile.Location = new Point(3, xAlto);
            metroTile.Size = new Size(136, 43);
            //metroTile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            metroTile.Cursor = Cursors.Hand;
            metroTile.Cursor = Cursors.Hand;
            metroTile.TileImageAlign = ContentAlignment.MiddleCenter;
            metroTile.TileTextFontSize = MetroTileTextSize.Medium;
            metroTile.Click += MetroTile_Click;
            metroTile.MouseEnter += MetroTile_GotFocus;
            metroTile.MouseLeave += MetroTile_LostFocus;
            toolTip.SetToolTip(metroTile, pName);
            dicModule.Add(metroTile, pIdParent);
            pnlMenuContenedor2.Controls.Add(metroTile);
            if (menuDesplazado)
            {
                CoupleMenu();
            }
        }
        private void BuildMenu(int pIdParent, string pName, string pNameCode, int YPosition, int xPosition)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            MetroTile metroTile = new MetroTile();

            pName = pName.Replace(" - ", "//-").Replace(" / ", "//-");
            pName = pName.Replace("/-", "\n").Replace(" ", "\n");

            metroTile.ActiveControl = null;
            metroTile.Location = new Point(xPosition, YPosition);
            metroTile.Cursor = Cursors.Hand;
            metroTile.Name = pNameCode;
            metroTile.Size = new Size(130, 110);
            metroTile.Style = MetroColorStyle.Green;
            metroTile.TabIndex = 3;
            metroTile.Text = pName;
            metroTile.Theme = MetroThemeStyle.Dark;
            metroTile.TileImage = (Image)Properties.Resources.ResourceManager.GetObject(metroTile.Name);
            metroTile.TileImageAlign = ContentAlignment.TopRight;
            metroTile.TileTextFontWeight = MetroTileTextWeight.Bold;
            metroTile.UseSelectable = true;
            metroTile.UseTileImage = true;
            metroTile.Click += MetroTileMenu_Click;
            metroTile.MouseEnter += MetroTile_GotFocus;
            metroTile.MouseLeave += MetroTile_LostFocus;

            this.ContenedorPrincipal.Controls.Add(metroTile);
            dictMenu.Add(metroTile, pIdParent);

        }

        

        void PlaceMenus(int pIdParent, int pNumByX)
        {
            int x = 10;
            int y = 10;
            int numByXCounter = 0;
            foreach (var item in dictMenu.Where(n => n.Value == pIdParent))
            {
                numByXCounter++;
                item.Key.Location = new Point(x, y);
                if (numByXCounter >= pNumByX)
                {
                    x = 10;
                    y += 130;
                }
                else
                {
                    x += 150;
                }
                ContenedorPrincipal.Controls.Add(item.Key);
            }
        }
        private void CoupleMenu()
        {
            this.pnlMenu.Size = new Size(60, pnlMenu.Size.Height);
            linkMenu.Image = Properties.Resources.kitchen2;
            tltCerrarSesion.UseTileImage = true;
            tltCerrarSesion.Text = "";
            foreach (var item in dicModule.Keys)
            {
                item.Text = "";
                item.UseTileImage = true;
                item.Size = new Size(46, 43);
            }
            pnlMenuContenedor2.Refresh();
        }
        private void UncoupleMenu()
        {
            linkMenu.Image = Properties.Resources.kitchen;
            this.pnlMenu.Size = new Size(150, pnlMenu.Size.Height);
            tltCerrarSesion.UseTileImage = false;
            tltCerrarSesion.Text = "Cerrar Sesión";
            foreach (var item in dicModule.Keys)
            {
                item.Text = SessionActivated.ListMenuGranted.Where(n => n.IdMenu == Convert.ToInt16(item.Tag)).FirstOrDefault().Name;
                item.UseTileImage = false;
                item.Size = new Size(136, 43);
            }
            pnlMenuContenedor2.Refresh();
        }
        #endregion

        #region eventos
        private void MetroTileMenu_Click(object sender, EventArgs e)
        {
            try
            {
                MetroTile menuClick = (MetroTile)sender;
                MetroFramework.Forms.MetroForm oForm = new MetroFramework.Forms.MetroForm();
                string dll = "UI2";
                Assembly assCadena = Assembly.LoadFrom(AppDomain.CurrentDomain.BaseDirectory + dll + ".dll");
                oForm = (MetroFramework.Forms.MetroForm)assCadena.CreateInstance("UI2.frm_"+menuClick.Name);
                oForm.MdiParent = this;
                oForm.Dock = DockStyle.Fill;
                oForm.StartPosition = FormStartPosition.CenterParent;
                oForm.BringToFront();
                oForm.WindowState = FormWindowState.Maximized;
                oForm.MaximizeBox = false;
                oForm.MinimizeBox = false;
                ContenedorPrincipal.Visible = false;
                oForm.FormClosed += OForm_FormClosed;
                oForm.Show();
            }
            catch (Exception ex)
            {
                //throw new Exception();
            }
        }

        private void OForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContenedorPrincipal.Visible = true;
        }

        private void linkMenu_Click(object sender, EventArgs e)
        {
            if (menuDesplazado)
            {
                UncoupleMenu();

            }
            else
            {
                CoupleMenu();
            }
            menuDesplazado = !menuDesplazado;
        }
        private void BtnTitulo_Click(object sender, EventArgs e)
        {
            pnlMenuContenedor2.Controls.Clear();
            ContenedorPrincipal.Controls.Clear();
            MetroButton btnClick = (MetroButton)sender;
            int idMenuParent = Convert.ToInt32(btnClick.Tag);
            if (btnClick.TabIndex != 1)
            {
                foreach (var item in dicModule.Where(n => n.Value == idMenuParent))
                {
                    pnlMenuContenedor2.Controls.Add(item.Key);
                }
            }
            else
            {
                int XPosition = 0;
                foreach (var item in SessionActivated.ListMenuGranted.Where(n => n.Level == 2 && n.IdParent == idMenuParent))
                {
                    BuildModule(idMenuParent, item.IdMenu, item.Name, item.NameCode, XPosition);
                    XPosition += 50;
                }
                btnClick.TabIndex = 2;
            }
        }
        private void MetroTile_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal.Controls.Clear();
            if (objMtile != null)
            {
                if ((objMtile).Name != ((MetroTile)sender).Name)
                {
                    (objMtile).Style = MetroColorStyle.Orange;
                    (objMtile).Refresh();
                }
            }
            ((MetroTile)sender).Style = MetroColorStyle.Green;
            ((MetroTile)sender).Refresh();
            //strNomModulo = ((MetroTile)sender).Text;
            //strIdModulo = ((MetroTile)sender).Name;
            objMtile = (MetroTile)sender;
            int idMenu = Convert.ToInt32(objMtile.Tag);
            IdMenuClicked = idMenu;
            if (objMtile.TabIndex == 1)
            {
                List<aeMenu> menuList = SessionActivated.ListMenuGranted.Where(n => n.Level == 3 && n.IdParent == idMenu).ToList();
                int ypoint = 10;
                int xpoint = 10;
                int numByXCounter = 0;
                foreach (var item in menuList)
                {
                    BuildMenu(idMenu, item.Name, item.NameCode, ypoint, xpoint);
                    if (numByXCounter + 1 >= NumPorX)
                    {
                        xpoint = 10;
                        ypoint += 130;
                    }
                    else
                    {
                        xpoint += 150;
                    }
                    numByXCounter++;
                }
            }
            else
            {
                PlaceMenus(idMenu, NumPorX);
            }
            objMtile.TabIndex = 2;
            resize = true;
        }
        private void MetroTile_LostFocus(object sender, EventArgs e)
        {
            MetroTile metroTile = (MetroTile)sender;
            metroTile.TileImage = (Image)Properties.Resources.ResourceManager.GetObject(metroTile.Name);
        }

        private void MetroTile_GotFocus(object sender, EventArgs e)
        {
            MetroTile metroTile = (MetroTile)sender;
            metroTile.TileImage = (Image)Properties.Resources.ResourceManager.GetObject(metroTile.Name + "2");
        }
        #endregion

        #endregion

        #region Metodos
        private void CargarSplash()
        {
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
        }
        private void CargarInicial()
        {
            BuildTitle();
            tsPeriodo.Text = DateTime.Now.Year.ToString();
            userCInicio1.Nombre = SessionActivated.User.FirtsName + " " + SessionActivated.User.LastName;
            userCInicio1.Detalle = "Detalles:";
        }

        #endregion

        #region Eventos
        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmManagePermissions control = new frmManagePermissions(this);

        }
        private void frmCargaInicial_Load(object sender, EventArgs e)
        {

        }

        private void tltCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            tltCerrarSesion.TileImage = Properties.Resources.salir;
        }

        private void tltCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            tltCerrarSesion.TileImage = Properties.Resources.salir2;

        }

        private void tltCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            //CargarLogin();
        }
        private void ContenedorPrincipal_Resize(object sender, EventArgs e)
        {
            //check size
            double result = ContenedorPrincipal.Size.Width / 150;
            int x = Convert.ToInt16(Math.Floor(result));
            if (x != NumPorX && resize)
            {
                PlaceMenus(IdMenuClicked, x);
                NumPorX = x;
            }
        }
        #endregion

    }
}
 