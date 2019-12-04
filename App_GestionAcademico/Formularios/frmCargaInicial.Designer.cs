namespace App_AcademicManagement
{
    partial class frmCargaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new MetroFramework.Controls.MetroPanel();
            this.pnlMenuContenedor = new MetroFramework.Controls.MetroPanel();
            this.pnlMenuContenedor2 = new MetroFramework.Controls.MetroPanel();
            this.tltCerrarSesion = new MetroFramework.Controls.MetroTile();
            this.linkMenu = new MetroFramework.Controls.MetroLink();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPeriodo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContenedorPrincipal = new MetroFramework.Controls.MetroPanel();
            this.userCInicio1 = new App_AcademicManagement.UserCInicio();
            this.pnlContenedorTitulo = new MetroFramework.Controls.MetroPanel();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuContenedor.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ContenedorPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlMenuContenedor);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.HorizontalScrollbarBarColor = true;
            this.pnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenu.HorizontalScrollbarSize = 10;
            this.pnlMenu.Location = new System.Drawing.Point(20, 93);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(150, 335);
            this.pnlMenu.Style = MetroFramework.MetroColorStyle.White;
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlMenu.VerticalScrollbarBarColor = true;
            this.pnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenu.VerticalScrollbarSize = 10;
            // 
            // pnlMenuContenedor
            // 
            this.pnlMenuContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuContenedor.Controls.Add(this.pnlMenuContenedor2);
            this.pnlMenuContenedor.Controls.Add(this.tltCerrarSesion);
            this.pnlMenuContenedor.Controls.Add(this.linkMenu);
            this.pnlMenuContenedor.HorizontalScrollbarBarColor = true;
            this.pnlMenuContenedor.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenuContenedor.HorizontalScrollbarSize = 10;
            this.pnlMenuContenedor.Location = new System.Drawing.Point(3, 3);
            this.pnlMenuContenedor.Name = "pnlMenuContenedor";
            this.pnlMenuContenedor.Size = new System.Drawing.Size(144, 329);
            this.pnlMenuContenedor.Style = MetroFramework.MetroColorStyle.Silver;
            this.pnlMenuContenedor.TabIndex = 2;
            this.pnlMenuContenedor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnlMenuContenedor.VerticalScrollbarBarColor = true;
            this.pnlMenuContenedor.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenuContenedor.VerticalScrollbarSize = 10;
            // 
            // pnlMenuContenedor2
            // 
            this.pnlMenuContenedor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuContenedor2.HorizontalScrollbarBarColor = true;
            this.pnlMenuContenedor2.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenuContenedor2.HorizontalScrollbarSize = 10;
            this.pnlMenuContenedor2.Location = new System.Drawing.Point(0, 52);
            this.pnlMenuContenedor2.Name = "pnlMenuContenedor2";
            this.pnlMenuContenedor2.Size = new System.Drawing.Size(144, 223);
            this.pnlMenuContenedor2.TabIndex = 4;
            this.pnlMenuContenedor2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnlMenuContenedor2.VerticalScrollbarBarColor = true;
            this.pnlMenuContenedor2.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenuContenedor2.VerticalScrollbarSize = 10;
            // 
            // tltCerrarSesion
            // 
            this.tltCerrarSesion.ActiveControl = null;
            this.tltCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tltCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tltCerrarSesion.Location = new System.Drawing.Point(3, 281);
            this.tltCerrarSesion.Name = "tltCerrarSesion";
            this.tltCerrarSesion.Size = new System.Drawing.Size(136, 43);
            this.tltCerrarSesion.Style = MetroFramework.MetroColorStyle.Silver;
            this.tltCerrarSesion.TabIndex = 8;
            this.tltCerrarSesion.Text = "Cerrar Sesión";
            this.tltCerrarSesion.TileImage = global::App_AcademicManagement.Properties.Resources.salir2;
            this.tltCerrarSesion.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tltCerrarSesion.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tltCerrarSesion.UseSelectable = true;
            this.tltCerrarSesion.Click += new System.EventHandler(this.tltCerrarSesion_Click);
            this.tltCerrarSesion.MouseEnter += new System.EventHandler(this.tltCerrarSesion_MouseEnter);
            this.tltCerrarSesion.MouseLeave += new System.EventHandler(this.tltCerrarSesion_MouseLeave);
            // 
            // linkMenu
            // 
            this.linkMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkMenu.Image = global::App_AcademicManagement.Properties.Resources.kitchen;
            this.linkMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkMenu.ImageSize = 32;
            this.linkMenu.Location = new System.Drawing.Point(6, 3);
            this.linkMenu.Name = "linkMenu";
            this.linkMenu.NoFocusImage = global::App_AcademicManagement.Properties.Resources.kitchen3;
            this.linkMenu.Size = new System.Drawing.Size(127, 43);
            this.linkMenu.TabIndex = 3;
            this.linkMenu.Text = "Menu";
            this.linkMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkMenu.UseSelectable = true;
            this.linkMenu.Click += new System.EventHandler(this.linkMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNombre,
            this.tsPeriodo});
            this.statusStrip1.Location = new System.Drawing.Point(20, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(711, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsNombre
            // 
            this.tsNombre.Name = "tsNombre";
            this.tsNombre.Size = new System.Drawing.Size(0, 17);
            // 
            // tsPeriodo
            // 
            this.tsPeriodo.Name = "tsPeriodo";
            this.tsPeriodo.Size = new System.Drawing.Size(0, 17);
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.Controls.Add(this.userCInicio1);
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.HorizontalScrollbarBarColor = true;
            this.ContenedorPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.ContenedorPrincipal.HorizontalScrollbarSize = 10;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(170, 93);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.Size = new System.Drawing.Size(561, 335);
            this.ContenedorPrincipal.TabIndex = 6;
            this.ContenedorPrincipal.VerticalScrollbarBarColor = true;
            this.ContenedorPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.ContenedorPrincipal.VerticalScrollbarSize = 10;
            this.ContenedorPrincipal.Resize += new System.EventHandler(this.ContenedorPrincipal_Resize);
            // 
            // userCInicio1
            // 
            this.userCInicio1.Detalle = null;
            this.userCInicio1.Location = new System.Drawing.Point(72, 82);
            this.userCInicio1.Name = "userCInicio1";
            this.userCInicio1.Nombre = null;
            this.userCInicio1.Size = new System.Drawing.Size(419, 152);
            this.userCInicio1.TabIndex = 2;
            // 
            // pnlContenedorTitulo
            // 
            this.pnlContenedorTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContenedorTitulo.HorizontalScrollbarBarColor = true;
            this.pnlContenedorTitulo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContenedorTitulo.HorizontalScrollbarSize = 10;
            this.pnlContenedorTitulo.Location = new System.Drawing.Point(20, 60);
            this.pnlContenedorTitulo.Name = "pnlContenedorTitulo";
            this.pnlContenedorTitulo.Size = new System.Drawing.Size(711, 33);
            this.pnlContenedorTitulo.TabIndex = 0;
            this.pnlContenedorTitulo.VerticalScrollbarBarColor = true;
            this.pnlContenedorTitulo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContenedorTitulo.VerticalScrollbarSize = 10;
            // 
            // frmCargaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 470);
            this.Controls.Add(this.ContenedorPrincipal);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlContenedorTitulo);
            this.IsMdiContainer = true;
            this.Name = "frmCargaInicial";
            this.Text = "Sistema Integral de Gestión Empresarial";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCargaInicial_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuContenedor.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ContenedorPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMenu;
        private MetroFramework.Controls.MetroPanel pnlMenuContenedor;
        private MetroFramework.Controls.MetroLink linkMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsNombre;
        private System.Windows.Forms.ToolStripStatusLabel tsPeriodo;
        private MetroFramework.Controls.MetroTile tltCerrarSesion;
        private MetroFramework.Controls.MetroPanel ContenedorPrincipal;
        private UserCInicio userCInicio1;
        private MetroFramework.Controls.MetroPanel pnlContenedorTitulo;
        private MetroFramework.Controls.MetroPanel pnlMenuContenedor2;
    }
}