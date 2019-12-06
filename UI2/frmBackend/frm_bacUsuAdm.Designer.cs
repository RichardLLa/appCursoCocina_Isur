namespace UI2
{
    partial class frm_bacUsuAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bacUsuAdm));
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnMenus = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.chkEstado = new MetroFramework.Controls.MetroCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlias = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtIdUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtDocumento = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(540, 63);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 19);
            this.lblTitulo.TabIndex = 98;
            this.lblTitulo.Text = "Usuario: Titulo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(875, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 96;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(875, 341);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(50, 50);
            this.btnAceptar.TabIndex = 97;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtDocumento);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.metroTextBox4);
            this.metroPanel1.Controls.Add(this.txtApellido);
            this.metroPanel1.Controls.Add(this.btnMenus);
            this.metroPanel1.Controls.Add(this.btnRoles);
            this.metroPanel1.Controls.Add(this.chkEstado);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.txtAlias);
            this.metroPanel1.Controls.Add(this.txtNombre);
            this.metroPanel1.Controls.Add(this.txtIdUsuario);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(535, 95);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(384, 354);
            this.metroPanel1.TabIndex = 95;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnMenus
            // 
            this.btnMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenus.Image = global::UI2.Properties.Resources.config;
            this.btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenus.Location = new System.Drawing.Point(197, 301);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(91, 31);
            this.btnMenus.TabIndex = 95;
            this.btnMenus.Text = "Menus";
            this.btnMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            this.btnRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Image = global::UI2.Properties.Resources.config;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoles.Location = new System.Drawing.Point(88, 301);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(91, 31);
            this.btnRoles.TabIndex = 94;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(88, 250);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(68, 15);
            this.chkEstado.TabIndex = 88;
            this.chkEstado.Text = "Habilitar";
            this.chkEstado.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Estado:";
            // 
            // txtAlias
            // 
            // 
            // 
            // 
            this.txtAlias.CustomButton.Image = null;
            this.txtAlias.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtAlias.CustomButton.Name = "";
            this.txtAlias.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAlias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAlias.CustomButton.TabIndex = 1;
            this.txtAlias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAlias.CustomButton.UseSelectable = true;
            this.txtAlias.CustomButton.Visible = false;
            this.txtAlias.Lines = new string[0];
            this.txtAlias.Location = new System.Drawing.Point(89, 172);
            this.txtAlias.MaxLength = 32767;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.PasswordChar = '\0';
            this.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAlias.SelectedText = "";
            this.txtAlias.SelectionLength = 0;
            this.txtAlias.SelectionStart = 0;
            this.txtAlias.ShortcutsEnabled = true;
            this.txtAlias.Size = new System.Drawing.Size(91, 23);
            this.txtAlias.TabIndex = 86;
            this.txtAlias.UseSelectable = true;
            this.txtAlias.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAlias.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(89, 92);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(248, 23);
            this.txtNombre.TabIndex = 85;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdUsuario
            // 
            // 
            // 
            // 
            this.txtIdUsuario.CustomButton.Image = null;
            this.txtIdUsuario.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtIdUsuario.CustomButton.Name = "";
            this.txtIdUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdUsuario.CustomButton.TabIndex = 1;
            this.txtIdUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdUsuario.CustomButton.UseSelectable = true;
            this.txtIdUsuario.CustomButton.Visible = false;
            this.txtIdUsuario.Lines = new string[0];
            this.txtIdUsuario.Location = new System.Drawing.Point(89, 52);
            this.txtIdUsuario.MaxLength = 32767;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdUsuario.SelectedText = "";
            this.txtIdUsuario.SelectionLength = 0;
            this.txtIdUsuario.SelectionStart = 0;
            this.txtIdUsuario.ShortcutsEnabled = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(91, 23);
            this.txtIdUsuario.TabIndex = 84;
            this.txtIdUsuario.UseSelectable = true;
            this.txtIdUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 83;
            this.metroLabel1.Text = "Datos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Alias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Id Usuario:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel11});
            this.statusStrip1.Location = new System.Drawing.Point(20, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 94;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel1.Text = "Usuario Creador:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel2.Text = "[Usuario]";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel3.Text = "Fecha Creacion:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel4.Text = "[Fecha]";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel8.Text = "Usuario Modificador:";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel9.Text = "[Usuario]";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel10.Text = "Fecha Modificacion:";
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel11.Text = "[Fecha]";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Direccion,
            this.Column1,
            this.Telefono});
            this.dtgUsuarios.Location = new System.Drawing.Point(23, 63);
            this.dtgUsuarios.MultiSelect = false;
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(506, 386);
            this.dtgUsuarios.TabIndex = 93;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdCliente";
            this.Codigo.HeaderText = "Id";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombres";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Apellido";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Alias";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Nro Documento";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 70;
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(89, 132);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(275, 23);
            this.metroTextBox4.TabIndex = 97;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(34, 143);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(52, 13);
            this.txtApellido.TabIndex = 96;
            this.txtApellido.Text = "Apellidos:";
            // 
            // txtDocumento
            // 
            // 
            // 
            // 
            this.txtDocumento.CustomButton.Image = null;
            this.txtDocumento.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtDocumento.CustomButton.Name = "";
            this.txtDocumento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocumento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocumento.CustomButton.TabIndex = 1;
            this.txtDocumento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocumento.CustomButton.UseSelectable = true;
            this.txtDocumento.CustomButton.Visible = false;
            this.txtDocumento.Lines = new string[0];
            this.txtDocumento.Location = new System.Drawing.Point(89, 212);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.Size = new System.Drawing.Size(91, 23);
            this.txtDocumento.TabIndex = 99;
            this.txtDocumento.UseSelectable = true;
            this.txtDocumento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocumento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Nro Documento:";
            // 
            // frm_bacUsuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 504);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgUsuarios);
            this.Name = "frm_bacUsuAdm";
            this.Text = "Usuarios";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.Button btnRoles;
        private MetroFramework.Controls.MetroCheckBox chkEstado;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtAlias;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtIdUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private MetroFramework.Controls.MetroTextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private System.Windows.Forms.Label txtApellido;
    }
}