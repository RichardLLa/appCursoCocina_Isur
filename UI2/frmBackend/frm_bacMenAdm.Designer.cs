namespace UI2
{
    partial class frm_bacMenAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bacMenAdm));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.chkEstado = new MetroFramework.Controls.MetroCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAplicacion = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.tctIdMenu = new MetroFramework.Controls.MetroTextBox();
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbMenus = new MetroFramework.Controls.MetroComboBox();
            this.cmbModulos = new MetroFramework.Controls.MetroComboBox();
            this.lbxMenus = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPadre = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(407, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 98;
            this.metroLabel3.Text = "Menu Titulo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(801, 392);
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
            this.btnAceptar.Location = new System.Drawing.Point(801, 336);
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
            this.metroPanel1.Controls.Add(this.cmbPadre);
            this.metroPanel1.Controls.Add(this.txtCodigo);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.btnRoles);
            this.metroPanel1.Controls.Add(this.btnUsuarios);
            this.metroPanel1.Controls.Add(this.chkEstado);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.txtIdAplicacion);
            this.metroPanel1.Controls.Add(this.txtNombre);
            this.metroPanel1.Controls.Add(this.tctIdMenu);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(407, 96);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(438, 348);
            this.metroPanel1.TabIndex = 95;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRoles
            // 
            this.btnRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Image = global::UI2.Properties.Resources.config;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoles.Location = new System.Drawing.Point(225, 295);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(91, 31);
            this.btnRoles.TabIndex = 95;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = global::UI2.Properties.Resources.config;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.Location = new System.Drawing.Point(116, 295);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(91, 31);
            this.btnUsuarios.TabIndex = 94;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(85, 236);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(68, 15);
            this.chkEstado.TabIndex = 88;
            this.chkEstado.Text = "Habilitar";
            this.chkEstado.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Estado";
            // 
            // txtIdAplicacion
            // 
            // 
            // 
            // 
            this.txtIdAplicacion.CustomButton.Image = null;
            this.txtIdAplicacion.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtIdAplicacion.CustomButton.Name = "";
            this.txtIdAplicacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdAplicacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdAplicacion.CustomButton.TabIndex = 1;
            this.txtIdAplicacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdAplicacion.CustomButton.UseSelectable = true;
            this.txtIdAplicacion.CustomButton.Visible = false;
            this.txtIdAplicacion.Lines = new string[0];
            this.txtIdAplicacion.Location = new System.Drawing.Point(85, 144);
            this.txtIdAplicacion.MaxLength = 32767;
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.PasswordChar = '\0';
            this.txtIdAplicacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdAplicacion.SelectedText = "";
            this.txtIdAplicacion.SelectionLength = 0;
            this.txtIdAplicacion.SelectionStart = 0;
            this.txtIdAplicacion.ShortcutsEnabled = true;
            this.txtIdAplicacion.Size = new System.Drawing.Size(91, 23);
            this.txtIdAplicacion.TabIndex = 86;
            this.txtIdAplicacion.UseSelectable = true;
            this.txtIdAplicacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdAplicacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(85, 98);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(329, 23);
            this.txtNombre.TabIndex = 85;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tctIdMenu
            // 
            // 
            // 
            // 
            this.tctIdMenu.CustomButton.Image = null;
            this.tctIdMenu.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.tctIdMenu.CustomButton.Name = "";
            this.tctIdMenu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tctIdMenu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tctIdMenu.CustomButton.TabIndex = 1;
            this.tctIdMenu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tctIdMenu.CustomButton.UseSelectable = true;
            this.tctIdMenu.CustomButton.Visible = false;
            this.tctIdMenu.Lines = new string[0];
            this.tctIdMenu.Location = new System.Drawing.Point(85, 52);
            this.tctIdMenu.MaxLength = 32767;
            this.tctIdMenu.Name = "tctIdMenu";
            this.tctIdMenu.PasswordChar = '\0';
            this.tctIdMenu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tctIdMenu.SelectedText = "";
            this.tctIdMenu.SelectionLength = 0;
            this.tctIdMenu.SelectionStart = 0;
            this.tctIdMenu.ShortcutsEnabled = true;
            this.tctIdMenu.Size = new System.Drawing.Size(91, 23);
            this.tctIdMenu.TabIndex = 84;
            this.tctIdMenu.UseSelectable = true;
            this.tctIdMenu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tctIdMenu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.label3.Location = new System.Drawing.Point(8, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Id Aplicación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Id Menu";
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
            this.statusStrip1.Location = new System.Drawing.Point(20, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(831, 22);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 102;
            this.metroLabel2.Text = "Menu";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(35, 63);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 103;
            this.metroLabel4.Text = "Módulo";
            // 
            // cmbMenus
            // 
            this.cmbMenus.FormattingEnabled = true;
            this.cmbMenus.ItemHeight = 23;
            this.cmbMenus.Location = new System.Drawing.Point(108, 104);
            this.cmbMenus.Name = "cmbMenus";
            this.cmbMenus.Size = new System.Drawing.Size(293, 29);
            this.cmbMenus.TabIndex = 100;
            this.cmbMenus.UseSelectable = true;
            // 
            // cmbModulos
            // 
            this.cmbModulos.FormattingEnabled = true;
            this.cmbModulos.ItemHeight = 23;
            this.cmbModulos.Location = new System.Drawing.Point(108, 58);
            this.cmbModulos.Name = "cmbModulos";
            this.cmbModulos.Size = new System.Drawing.Size(293, 29);
            this.cmbModulos.TabIndex = 101;
            this.cmbModulos.UseSelectable = true;
            // 
            // lbxMenus
            // 
            this.lbxMenus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxMenus.FormattingEnabled = true;
            this.lbxMenus.Location = new System.Drawing.Point(35, 154);
            this.lbxMenus.Name = "lbxMenus";
            this.lbxMenus.Size = new System.Drawing.Size(366, 290);
            this.lbxMenus.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Menu Padre:";
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(271, 52);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(143, 23);
            this.txtCodigo.TabIndex = 99;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 98;
            this.label6.Text = "Código:";
            // 
            // cmbPadre
            // 
            this.cmbPadre.FormattingEnabled = true;
            this.cmbPadre.ItemHeight = 23;
            this.cmbPadre.Location = new System.Drawing.Point(85, 188);
            this.cmbPadre.Name = "cmbPadre";
            this.cmbPadre.Size = new System.Drawing.Size(180, 29);
            this.cmbPadre.TabIndex = 104;
            this.cmbPadre.UseSelectable = true;
            // 
            // frm_bacMenAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 498);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbMenus);
            this.Controls.Add(this.cmbModulos);
            this.Controls.Add(this.lbxMenus);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frm_bacMenAdm";
            this.Text = "Administración Menus";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnUsuarios;
        private MetroFramework.Controls.MetroCheckBox chkEstado;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtIdAplicacion;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox tctIdMenu;
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbMenus;
        private MetroFramework.Controls.MetroComboBox cmbModulos;
        private System.Windows.Forms.ListBox lbxMenus;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cmbPadre;
    }
}