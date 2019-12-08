namespace UI2
{
    partial class frm_ManageRole
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDesabilitar = new System.Windows.Forms.Button();
            this.Habilitar = new System.Windows.Forms.Button();
            this.lbxRolesNoActivos = new System.Windows.Forms.ListBox();
            this.lbxRolesActivos = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.button5);
            this.metroPanel2.Controls.Add(this.btnDesabilitar);
            this.metroPanel2.Controls.Add(this.Habilitar);
            this.metroPanel2.Controls.Add(this.lbxRolesNoActivos);
            this.metroPanel2.Controls.Add(this.lbxRolesActivos);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 90);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(559, 369);
            this.metroPanel2.TabIndex = 95;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(326, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 95;
            this.metroLabel2.Text = "No Activos";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 94;
            this.metroLabel1.Text = "Activos";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::UI2.Properties.Resources.Atras;
            this.button5.Location = new System.Drawing.Point(19, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 31);
            this.button5.TabIndex = 93;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDesabilitar
            // 
            this.btnDesabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesabilitar.Image = global::UI2.Properties.Resources.back2;
            this.btnDesabilitar.Location = new System.Drawing.Point(264, 148);
            this.btnDesabilitar.Name = "btnDesabilitar";
            this.btnDesabilitar.Size = new System.Drawing.Size(26, 31);
            this.btnDesabilitar.TabIndex = 92;
            this.btnDesabilitar.UseVisualStyleBackColor = true;
            this.btnDesabilitar.Click += new System.EventHandler(this.btnDesabilitar_Click);
            // 
            // Habilitar
            // 
            this.Habilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Habilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Habilitar.Image = global::UI2.Properties.Resources.back;
            this.Habilitar.Location = new System.Drawing.Point(264, 216);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(26, 31);
            this.Habilitar.TabIndex = 91;
            this.Habilitar.UseVisualStyleBackColor = true;
            this.Habilitar.Click += new System.EventHandler(this.Habilitar_Click);
            // 
            // lbxRolesNoActivos
            // 
            this.lbxRolesNoActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxRolesNoActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRolesNoActivos.FormattingEnabled = true;
            this.lbxRolesNoActivos.ItemHeight = 18;
            this.lbxRolesNoActivos.Location = new System.Drawing.Point(326, 94);
            this.lbxRolesNoActivos.Name = "lbxRolesNoActivos";
            this.lbxRolesNoActivos.Size = new System.Drawing.Size(210, 220);
            this.lbxRolesNoActivos.TabIndex = 87;
            // 
            // lbxRolesActivos
            // 
            this.lbxRolesActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxRolesActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRolesActivos.FormattingEnabled = true;
            this.lbxRolesActivos.ItemHeight = 18;
            this.lbxRolesActivos.Location = new System.Drawing.Point(19, 94);
            this.lbxRolesActivos.Name = "lbxRolesActivos";
            this.lbxRolesActivos.Size = new System.Drawing.Size(210, 220);
            this.lbxRolesActivos.TabIndex = 84;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 100;
            this.metroLabel3.Text = "Titulin";
            // 
            // frm_ManageRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 496);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frm_ManageRole";
            this.Text = "Administración de Roles";
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDesabilitar;
        private System.Windows.Forms.Button Habilitar;
        private System.Windows.Forms.ListBox lbxRolesNoActivos;
        private System.Windows.Forms.ListBox lbxRolesActivos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}