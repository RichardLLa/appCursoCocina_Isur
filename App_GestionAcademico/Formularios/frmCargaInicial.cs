using AE;
using BL;
using MetroFramework;
using MetroFramework.Controls;
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
    public partial class frmCargaInicial : MetroFramework.Forms.MetroForm
    {
        #region atributos
        private Dictionary<MetroTile, aeModulo> DicModulos = new Dictionary<MetroTile, aeModulo>();
        private aeSession SessionActivated = new    aeSession();
        List<userCMenu> cmenuList = new List<userCMenu>();
        #endregion
        public frmCargaInicial()
        {
            InitializeComponent();
            CargarInicial();
        }
        public frmCargaInicial(aeUser user)
        {
            blSession oAe = new blSession();
            SessionActivated = oAe.Login(user);
            InitializeComponent();
            CargarInicial();
        }
        public frmCargaInicial(int idUser)
        {
            blSession oAe = new blSession();
            SessionActivated = oAe.IniciarSesion(user);
            //InitializeComponent();
            //CargarInicial();
        }
        private void CargarInicial()
        {
            ConstruirModulosPadre();
            tsPeriodo.Text = DateTime.Now.Year.ToString();
            userCInicio1.Nombre = SessionActivated.Persona.Nombre +" "+ SessionActivated.Persona.Apellidos;
            userCInicio1.Detalle =  "Detalles:";
        }
        public void ContruirMenus()
        {
            ConstruirModulo();
            ConstruirMenu();
        }

        private void ConstruirModulosPadre()
        {
            throw new NotImplementedException();
        }

        private void ConstruirMenu()
        {
            foreach (var item in SessionActivated.Modulos)
            {
                List<aeMenu> aeMenu = new List<aeMenu>();
                for (int i = 0; i < SessionActivated.Menus.Count; i++)
                {
                    if (SessionActivated.Menus[i].IdModulo == item.IdModulo)
                    {
                        aeMenu.Add(SessionActivated.Menus[i]);
                    }
                }
                userCMenu cm = new userCMenu(aeMenu,item.IdModulo,this,this.ContenedorPrincipal);
                cm.Size = this.ContenedorPrincipal.Size;
                this.ContenedorPrincipal.Controls.Add(cm);
                cm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                cmenuList.Add(cm);
            }
        }

        private void CargarSplash()
        {
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
        }

        private void CargarSesion()
        {
            
            
        }

        void ConstruirModulo()
        {
            blModulo oBLMod = new blModulo();
            List<aeModulo> oLMod = oBLMod.GetRow(SessionActivated.User.IdUser);

            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            int alto = 0;
            for (int x = 0; x < oLMod.Count(); x++)
            {
                alto += 50;
                MetroTile metroTile = new MetroTile();

                metroTile.Text = oLMod[x].Nombre;
                metroTile.Tag = oLMod[x].IdModulo;
                metroTile.TileImage = (Image)Properties.Resources.ResourceManager.GetObject(oLMod[x].Codigo);
                metroTile.TileTextFontWeight = MetroTileTextWeight.Bold;
                metroTile.Style = MetroColorStyle.Orange;
                metroTile.Location = new Point(3, alto);
                metroTile.Size = new Size(136, 43);
                metroTile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                metroTile.Cursor = Cursors.Hand;
                metroTile.TileImageAlign = ContentAlignment.MiddleCenter;
                metroTile.TileTextFontSize = MetroTileTextSize.Medium;
                metroTile.Click += MetroTile_Click;
                metroTile.MouseEnter += MetroTile_GotFocus;
                metroTile.MouseLeave += MetroTile_LostFocus;
                toolTip.SetToolTip(metroTile, oLMod[x].Nombre);
                DicModulos.Add(metroTile,oLMod[x] );
                pnlMenuContenedor.Controls.Add(metroTile);
            }
        }

        private void MetroTile_LostFocus(object sender, EventArgs e)
        {
            MetroTile metroTile = (MetroTile)sender;
            metroTile.TileImage = (Image)Properties.Resources.ResourceManager.GetObject(DicModulos[metroTile].Codigo);
        }

        private void MetroTile_GotFocus(object sender, EventArgs e)
        {
            MetroTile metroTile = (MetroTile)sender;
            metroTile.TileImage = (Image)Properties.Resources.ResourceManager.GetObject(DicModulos[metroTile].Codigo+"2");
        }

        MetroTile objMtile = null;
        private void MetroTile_Click(object sender, EventArgs e)
        {
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
            string idModul = objMtile.Tag.ToString();
            foreach (var item in cmenuList)
            {
                if (item.IdModulo.ToString() == idModul)
                {
                    item.BringToFront();
                }
            }
            //userCInicio1.SendToBack();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmManagePermissions control = new frmManagePermissions(this);
            
        }

        private bool menuDesplazado;
        private void linkMenu_Click(object sender, EventArgs e)
        {
            if (menuDesplazado)
            {
                linkMenu.Image = Properties.Resources.kitchen;
                this.pnlMenu.Size = new Size(150, pnlMenu.Size.Height);
                MenuDesacoplar();
                tltCerrarSesion.UseTileImage = false;
                tltCerrarSesion.Text = "Cerrar Sesión";
            }
            else
            {
                this.pnlMenu.Size = new Size(60, pnlMenu.Size.Height);
                linkMenu.Image = Properties.Resources.kitchen2;
                MenuAcoplar();
                tltCerrarSesion.UseTileImage = true;
                tltCerrarSesion.Text = "";
            }
            menuDesplazado = !menuDesplazado;
        }
        private void MenuAcoplar()
        {
            for (int i = 0; i < DicModulos.Count; i++)
            {
                DicModulos.Keys.ElementAt(i).Text = "";
                DicModulos.Keys.ElementAt(i).UseTileImage = true;
                //DicModulos[DicModulos.Keys.ElementAt(i)].Text = "";
                //DicModulos[DicModulos.Keys.ElementAt(i)].UseTileImage =true;

            }
        }
        private void MenuDesacoplar()
        {
            for (int i = 0; i < DicModulos.Count; i++)
            {
                DicModulos.Keys.ElementAt(i).Text = DicModulos[DicModulos.Keys.ElementAt(i)].Nombre;
                DicModulos.Keys.ElementAt(i).UseTileImage = false;
                //DicModulos[DicModulos.Keys.ElementAt(i)].Text = DicModulos.Keys.ElementAt(i).Descripcion;
                //DicModulos[DicModulos.Keys.ElementAt(i)].UseTileImage = false;
            }
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
        private void CargarLogin()
        {
            this.Visible = false;
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                //sesion del formulario login
                this.Visible = true;
            }
            else
            {
                login.Dispose();
                this.Close();
            }
        }
    }
}
