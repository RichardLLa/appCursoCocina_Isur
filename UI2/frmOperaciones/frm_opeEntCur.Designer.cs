namespace UI2
{
    partial class frm_opeEntCur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_opeEntCur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBusquedaProduct = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(83, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 31);
            this.label6.TabIndex = 56;
            this.label6.Text = "Registrar ingreso Curso";
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloArticulos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTituloArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(23, 95);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(384, 40);
            this.lblTituloArticulos.TabIndex = 67;
            this.lblTituloArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpProducts
            // 
            this.flpProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpProducts.Location = new System.Drawing.Point(23, 138);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(384, 327);
            this.flpProducts.TabIndex = 68;
            // 
            // txtBusquedaProduct
            // 
            this.txtBusquedaProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProduct.Location = new System.Drawing.Point(68, 103);
            this.txtBusquedaProduct.Name = "txtBusquedaProduct";
            this.txtBusquedaProduct.Size = new System.Drawing.Size(326, 24);
            this.txtBusquedaProduct.TabIndex = 70;
            this.txtBusquedaProduct.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(28, 99);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 33);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(20, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.TabIndex = 71;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frm_opeEntCur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtBusquedaProduct);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTituloArticulos);
            this.Controls.Add(this.flpProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "frm_opeEntCur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.TextBox txtBusquedaProduct;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}