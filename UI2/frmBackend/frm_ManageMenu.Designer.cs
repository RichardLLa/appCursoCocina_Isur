namespace UI2
{
    partial class frm_ManageMenu
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.chkMenu = new MetroFramework.Controls.MetroCheckBox();
            this.chkModulo = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboMenu = new MetroFramework.Controls.MetroComboBox();
            this.cboModulo = new MetroFramework.Controls.MetroComboBox();
            this.lbxPermisosNoActivos = new System.Windows.Forms.ListBox();
            this.lbxPermisosActivos = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.chkMenu);
            this.metroPanel2.Controls.Add(this.chkModulo);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.cboMenu);
            this.metroPanel2.Controls.Add(this.cboModulo);
            this.metroPanel2.Controls.Add(this.btnSalir);
            this.metroPanel2.Controls.Add(this.btnDeshabilitar);
            this.metroPanel2.Controls.Add(this.btnHabilitar);
            this.metroPanel2.Controls.Add(this.lbxPermisosNoActivos);
            this.metroPanel2.Controls.Add(this.lbxPermisosActivos);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 91);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(561, 412);
            this.metroPanel2.TabIndex = 97;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // chkMenu
            // 
            this.chkMenu.AutoSize = true;
            this.chkMenu.Location = new System.Drawing.Point(285, 104);
            this.chkMenu.Name = "chkMenu";
            this.chkMenu.Size = new System.Drawing.Size(78, 15);
            this.chkMenu.TabIndex = 97;
            this.chkMenu.Text = "Habilitado";
            this.chkMenu.UseSelectable = true;
            // 
            // chkModulo
            // 
            this.chkModulo.AutoSize = true;
            this.chkModulo.Location = new System.Drawing.Point(285, 58);
            this.chkModulo.Name = "chkModulo";
            this.chkModulo.Size = new System.Drawing.Size(78, 15);
            this.chkModulo.TabIndex = 97;
            this.chkModulo.Text = "Habilitado";
            this.chkModulo.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 95;
            this.metroLabel2.Text = "Menu";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 95;
            this.metroLabel1.Text = "Módulo";
            // 
            // cboMenu
            // 
            this.cboMenu.FormattingEnabled = true;
            this.cboMenu.ItemHeight = 23;
            this.cboMenu.Location = new System.Drawing.Point(95, 95);
            this.cboMenu.Name = "cboMenu";
            this.cboMenu.Size = new System.Drawing.Size(172, 29);
            this.cboMenu.TabIndex = 94;
            this.cboMenu.UseSelectable = true;
            // 
            // cboModulo
            // 
            this.cboModulo.FormattingEnabled = true;
            this.cboModulo.ItemHeight = 23;
            this.cboModulo.Location = new System.Drawing.Point(95, 49);
            this.cboModulo.Name = "cboModulo";
            this.cboModulo.Size = new System.Drawing.Size(172, 29);
            this.cboModulo.TabIndex = 94;
            this.cboModulo.UseSelectable = true;
            // 
            // lbxPermisosNoActivos
            // 
            this.lbxPermisosNoActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxPermisosNoActivos.FormattingEnabled = true;
            this.lbxPermisosNoActivos.Location = new System.Drawing.Point(329, 145);
            this.lbxPermisosNoActivos.Name = "lbxPermisosNoActivos";
            this.lbxPermisosNoActivos.Size = new System.Drawing.Size(210, 225);
            this.lbxPermisosNoActivos.TabIndex = 87;
            // 
            // lbxPermisosActivos
            // 
            this.lbxPermisosActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxPermisosActivos.FormattingEnabled = true;
            this.lbxPermisosActivos.Location = new System.Drawing.Point(22, 145);
            this.lbxPermisosActivos.Name = "lbxPermisosActivos";
            this.lbxPermisosActivos.Size = new System.Drawing.Size(210, 225);
            this.lbxPermisosActivos.TabIndex = 84;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 99;
            this.metroLabel3.Text = "Titulin";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::UI2.Properties.Resources.Atras;
            this.btnSalir.Location = new System.Drawing.Point(22, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 31);
            this.btnSalir.TabIndex = 93;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Image = global::UI2.Properties.Resources.back2;
            this.btnDeshabilitar.Location = new System.Drawing.Point(267, 221);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(26, 31);
            this.btnDeshabilitar.TabIndex = 92;
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.Image = global::UI2.Properties.Resources.back;
            this.btnHabilitar.Location = new System.Drawing.Point(267, 289);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(26, 31);
            this.btnHabilitar.TabIndex = 91;
            this.btnHabilitar.UseVisualStyleBackColor = true;
            // 
            // frm_ManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 577);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ManageMenu";
            this.Text = "Administrar Menus";
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroCheckBox chkMenu;
        private MetroFramework.Controls.MetroCheckBox chkModulo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboMenu;
        private MetroFramework.Controls.MetroComboBox cboModulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.ListBox lbxPermisosNoActivos;
        private System.Windows.Forms.ListBox lbxPermisosActivos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}