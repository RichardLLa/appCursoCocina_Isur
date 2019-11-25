namespace App_AcademicManagement
{
    partial class userCMenu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userCMenu));
            this.pnlMen = new System.Windows.Forms.Panel();
            this.picMen = new System.Windows.Forms.PictureBox();
            this.lblMen = new System.Windows.Forms.Label();
            this.pnlMen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMen
            // 
            this.pnlMen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMen.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMen.Controls.Add(this.picMen);
            this.pnlMen.Controls.Add(this.lblMen);
            this.pnlMen.Location = new System.Drawing.Point(417, 233);
            this.pnlMen.Name = "pnlMen";
            this.pnlMen.Size = new System.Drawing.Size(222, 119);
            this.pnlMen.TabIndex = 2;
            // 
            // picMen
            // 
            this.picMen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMen.Image = ((System.Drawing.Image)(resources.GetObject("picMen.Image")));
            this.picMen.Location = new System.Drawing.Point(158, 20);
            this.picMen.Name = "picMen";
            this.picMen.Size = new System.Drawing.Size(57, 59);
            this.picMen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMen.TabIndex = 2;
            this.picMen.TabStop = false;
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMen.ForeColor = System.Drawing.Color.White;
            this.lblMen.Location = new System.Drawing.Point(16, 13);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(92, 19);
            this.lblMen.TabIndex = 0;
            this.lblMen.Text = "Customers:";
            // 
            // userCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "userCMenu";
            this.Size = new System.Drawing.Size(689, 388);
            this.Resize += new System.EventHandler(this.userCMenu_Resize);
            this.pnlMen.ResumeLayout(false);
            this.pnlMen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMen;
        private System.Windows.Forms.PictureBox picMen;
        private System.Windows.Forms.Label lblMen;
    }
}
