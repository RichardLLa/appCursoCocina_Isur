namespace App_AcademicManagement
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.PnlLogin = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.txtPasword = new MetroFramework.Controls.MetroTextBox();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mLinkIngresar = new MetroFramework.Controls.MetroLink();
            this.pnlRegister = new MetroFramework.Controls.MetroPanel();
            this.txtPassNewRepeat = new MetroFramework.Controls.MetroTextBox();
            this.picNewPassRepeat = new System.Windows.Forms.PictureBox();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txtPassNew = new MetroFramework.Controls.MetroTextBox();
            this.txtUserNew = new MetroFramework.Controls.MetroTextBox();
            this.picNewPass = new System.Windows.Forms.PictureBox();
            this.picNewUser = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mLinkRegister = new MetroFramework.Controls.MetroLink();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tabLogin = new MetroFramework.Controls.MetroTabControl();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLogin.Controls.Add(this.metroLink1);
            this.PnlLogin.Controls.Add(this.txtPasword);
            this.PnlLogin.Controls.Add(this.txtUser);
            this.PnlLogin.Controls.Add(this.picPass);
            this.PnlLogin.Controls.Add(this.picUser);
            this.PnlLogin.Controls.Add(this.metroPanel4);
            this.PnlLogin.Controls.Add(this.metroPanel3);
            this.PnlLogin.Controls.Add(this.pictureBox1);
            this.PnlLogin.Controls.Add(this.mLinkIngresar);
            this.PnlLogin.HorizontalScrollbarBarColor = true;
            this.PnlLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.PnlLogin.HorizontalScrollbarSize = 10;
            this.PnlLogin.Location = new System.Drawing.Point(23, 63);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(329, 413);
            this.PnlLogin.TabIndex = 2;
            this.PnlLogin.VerticalScrollbarBarColor = true;
            this.PnlLogin.VerticalScrollbarHighlightOnWheel = false;
            this.PnlLogin.VerticalScrollbarSize = 10;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(96, 286);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(151, 23);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.Text = "Olvidé mi contraseña";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // txtPasword
            // 
            // 
            // 
            // 
            this.txtPasword.CustomButton.Image = null;
            this.txtPasword.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtPasword.CustomButton.Name = "";
            this.txtPasword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasword.CustomButton.TabIndex = 1;
            this.txtPasword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasword.CustomButton.UseSelectable = true;
            this.txtPasword.CustomButton.Visible = false;
            this.txtPasword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPasword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPasword.Lines = new string[0];
            this.txtPasword.Location = new System.Drawing.Point(83, 244);
            this.txtPasword.MaxLength = 32767;
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.PasswordChar = '*';
            this.txtPasword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasword.SelectedText = "";
            this.txtPasword.SelectionLength = 0;
            this.txtPasword.SelectionStart = 0;
            this.txtPasword.ShortcutsEnabled = true;
            this.txtPasword.Size = new System.Drawing.Size(211, 23);
            this.txtPasword.TabIndex = 8;
            this.txtPasword.UseSelectable = true;
            this.txtPasword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasword.Enter += new System.EventHandler(this.txtPasword_Enter);
            this.txtPasword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasword_KeyDown);
            this.txtPasword.Leave += new System.EventHandler(this.txtPasword_Leave);
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUser.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(83, 183);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(211, 23);
            this.txtUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.TabIndex = 7;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // picPass
            // 
            this.picPass.Image = global::App_AcademicManagement.Properties.Resources.pass;
            this.picPass.Location = new System.Drawing.Point(46, 235);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(35, 37);
            this.picPass.TabIndex = 4;
            this.picPass.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::App_AcademicManagement.Properties.Resources.user;
            this.picUser.Location = new System.Drawing.Point(46, 177);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(32, 32);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUser.TabIndex = 3;
            this.picUser.TabStop = false;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(46, 267);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(250, 5);
            this.metroPanel4.TabIndex = 6;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(46, 206);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(250, 5);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mLinkIngresar
            // 
            this.mLinkIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLinkIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mLinkIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mLinkIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mLinkIngresar.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mLinkIngresar.Image = global::App_AcademicManagement.Properties.Resources.login2;
            this.mLinkIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mLinkIngresar.ImageSize = 70;
            this.mLinkIngresar.Location = new System.Drawing.Point(96, 315);
            this.mLinkIngresar.Name = "mLinkIngresar";
            this.mLinkIngresar.NoFocusImage = global::App_AcademicManagement.Properties.Resources.login;
            this.mLinkIngresar.Size = new System.Drawing.Size(126, 71);
            this.mLinkIngresar.TabIndex = 0;
            this.mLinkIngresar.Text = "Login";
            this.mLinkIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mLinkIngresar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mLinkIngresar.UseSelectable = true;
            this.mLinkIngresar.Click += new System.EventHandler(this.mLinkIngresar_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegister.Controls.Add(this.txtPassNewRepeat);
            this.pnlRegister.Controls.Add(this.picNewPassRepeat);
            this.pnlRegister.Controls.Add(this.metroPanel5);
            this.pnlRegister.Controls.Add(this.txtPassNew);
            this.pnlRegister.Controls.Add(this.txtUserNew);
            this.pnlRegister.Controls.Add(this.picNewPass);
            this.pnlRegister.Controls.Add(this.picNewUser);
            this.pnlRegister.Controls.Add(this.metroPanel1);
            this.pnlRegister.Controls.Add(this.metroPanel2);
            this.pnlRegister.Controls.Add(this.pictureBox6);
            this.pnlRegister.Controls.Add(this.mLinkRegister);
            this.pnlRegister.HorizontalScrollbarBarColor = true;
            this.pnlRegister.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRegister.HorizontalScrollbarSize = 10;
            this.pnlRegister.Location = new System.Drawing.Point(372, 63);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(329, 413);
            this.pnlRegister.TabIndex = 3;
            this.pnlRegister.VerticalScrollbarBarColor = true;
            this.pnlRegister.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRegister.VerticalScrollbarSize = 10;
            // 
            // txtPassNewRepeat
            // 
            // 
            // 
            // 
            this.txtPassNewRepeat.CustomButton.Image = null;
            this.txtPassNewRepeat.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtPassNewRepeat.CustomButton.Name = "";
            this.txtPassNewRepeat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassNewRepeat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassNewRepeat.CustomButton.TabIndex = 1;
            this.txtPassNewRepeat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassNewRepeat.CustomButton.UseSelectable = true;
            this.txtPassNewRepeat.CustomButton.Visible = false;
            this.txtPassNewRepeat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassNewRepeat.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPassNewRepeat.Lines = new string[0];
            this.txtPassNewRepeat.Location = new System.Drawing.Point(78, 264);
            this.txtPassNewRepeat.MaxLength = 32767;
            this.txtPassNewRepeat.Name = "txtPassNewRepeat";
            this.txtPassNewRepeat.PasswordChar = '*';
            this.txtPassNewRepeat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassNewRepeat.SelectedText = "";
            this.txtPassNewRepeat.SelectionLength = 0;
            this.txtPassNewRepeat.SelectionStart = 0;
            this.txtPassNewRepeat.ShortcutsEnabled = true;
            this.txtPassNewRepeat.Size = new System.Drawing.Size(211, 23);
            this.txtPassNewRepeat.TabIndex = 18;
            this.txtPassNewRepeat.UseSelectable = true;
            this.txtPassNewRepeat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassNewRepeat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassNewRepeat.Enter += new System.EventHandler(this.txtPassNewRepeat_Enter);
            this.txtPassNewRepeat.Leave += new System.EventHandler(this.txtPassNewRepeat_Leave);
            // 
            // picNewPassRepeat
            // 
            this.picNewPassRepeat.Image = global::App_AcademicManagement.Properties.Resources.pass;
            this.picNewPassRepeat.Location = new System.Drawing.Point(41, 255);
            this.picNewPassRepeat.Name = "picNewPassRepeat";
            this.picNewPassRepeat.Size = new System.Drawing.Size(35, 37);
            this.picNewPassRepeat.TabIndex = 16;
            this.picNewPassRepeat.TabStop = false;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(41, 287);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(250, 5);
            this.metroPanel5.TabIndex = 17;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // txtPassNew
            // 
            // 
            // 
            // 
            this.txtPassNew.CustomButton.Image = null;
            this.txtPassNew.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtPassNew.CustomButton.Name = "";
            this.txtPassNew.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassNew.CustomButton.TabIndex = 1;
            this.txtPassNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassNew.CustomButton.UseSelectable = true;
            this.txtPassNew.CustomButton.Visible = false;
            this.txtPassNew.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassNew.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPassNew.Lines = new string[0];
            this.txtPassNew.Location = new System.Drawing.Point(78, 217);
            this.txtPassNew.MaxLength = 32767;
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = '*';
            this.txtPassNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassNew.SelectedText = "";
            this.txtPassNew.SelectionLength = 0;
            this.txtPassNew.SelectionStart = 0;
            this.txtPassNew.ShortcutsEnabled = true;
            this.txtPassNew.Size = new System.Drawing.Size(211, 23);
            this.txtPassNew.TabIndex = 15;
            this.txtPassNew.UseSelectable = true;
            this.txtPassNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassNew.Enter += new System.EventHandler(this.txtPassNew_Enter);
            this.txtPassNew.Leave += new System.EventHandler(this.txtPassNew_Leave);
            // 
            // txtUserNew
            // 
            // 
            // 
            // 
            this.txtUserNew.CustomButton.Image = null;
            this.txtUserNew.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtUserNew.CustomButton.Name = "";
            this.txtUserNew.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserNew.CustomButton.TabIndex = 1;
            this.txtUserNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserNew.CustomButton.UseSelectable = true;
            this.txtUserNew.CustomButton.Visible = false;
            this.txtUserNew.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserNew.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUserNew.Lines = new string[0];
            this.txtUserNew.Location = new System.Drawing.Point(78, 174);
            this.txtUserNew.MaxLength = 32767;
            this.txtUserNew.Name = "txtUserNew";
            this.txtUserNew.PasswordChar = '\0';
            this.txtUserNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserNew.SelectedText = "";
            this.txtUserNew.SelectionLength = 0;
            this.txtUserNew.SelectionStart = 0;
            this.txtUserNew.ShortcutsEnabled = true;
            this.txtUserNew.Size = new System.Drawing.Size(211, 23);
            this.txtUserNew.TabIndex = 14;
            this.txtUserNew.UseSelectable = true;
            this.txtUserNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserNew.Enter += new System.EventHandler(this.txtUserNew_Enter);
            this.txtUserNew.Leave += new System.EventHandler(this.txtUserNew_Leave);
            // 
            // picNewPass
            // 
            this.picNewPass.Image = global::App_AcademicManagement.Properties.Resources.pass;
            this.picNewPass.Location = new System.Drawing.Point(41, 208);
            this.picNewPass.Name = "picNewPass";
            this.picNewPass.Size = new System.Drawing.Size(35, 37);
            this.picNewPass.TabIndex = 11;
            this.picNewPass.TabStop = false;
            // 
            // picNewUser
            // 
            this.picNewUser.Image = global::App_AcademicManagement.Properties.Resources.user;
            this.picNewUser.Location = new System.Drawing.Point(41, 165);
            this.picNewUser.Name = "picNewUser";
            this.picNewUser.Size = new System.Drawing.Size(32, 32);
            this.picNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNewUser.TabIndex = 10;
            this.picNewUser.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(41, 240);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(250, 5);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(41, 197);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(250, 5);
            this.metroPanel2.TabIndex = 12;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::App_AcademicManagement.Properties.Resources.userLogo2;
            this.pictureBox6.Location = new System.Drawing.Point(79, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(142, 140);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // mLinkRegister
            // 
            this.mLinkRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mLinkRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mLinkRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mLinkRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mLinkRegister.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mLinkRegister.Image = global::App_AcademicManagement.Properties.Resources.register;
            this.mLinkRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mLinkRegister.ImageSize = 70;
            this.mLinkRegister.Location = new System.Drawing.Point(90, 315);
            this.mLinkRegister.Name = "mLinkRegister";
            this.mLinkRegister.Size = new System.Drawing.Size(149, 71);
            this.mLinkRegister.TabIndex = 0;
            this.mLinkRegister.Text = "Register";
            this.mLinkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mLinkRegister.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mLinkRegister.UseSelectable = true;
            this.mLinkRegister.Click += new System.EventHandler(this.mLinkRegister_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(112, 1);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Sing in";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(112, 4);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Log in";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tabLogin
            // 
            this.tabLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabLogin.Controls.Add(this.metroTabPage1);
            this.tabLogin.Controls.Add(this.metroTabPage2);
            this.tabLogin.Location = new System.Drawing.Point(113, 481);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 1;
            this.tabLogin.Size = new System.Drawing.Size(120, 43);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.UseSelectable = true;
            this.tabLogin.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(988, 533);
            this.Controls.Add(this.tabLogin);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPassRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mLinkIngresar;
        private MetroFramework.Controls.MetroPanel PnlLogin;
        private MetroFramework.Controls.MetroPanel pnlRegister;
        private MetroFramework.Controls.MetroLink mLinkRegister;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl tabLogin;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picUser;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtPasword;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroTextBox txtPassNew;
        private MetroFramework.Controls.MetroTextBox txtUserNew;
        private System.Windows.Forms.PictureBox picNewPass;
        private System.Windows.Forms.PictureBox picNewUser;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MetroFramework.Controls.MetroTextBox txtPassNewRepeat;
        private System.Windows.Forms.PictureBox picNewPassRepeat;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.ErrorProvider errProvider;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

