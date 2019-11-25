namespace UI2.frmOperaciones
{
    partial class frm_BusquedaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BusquedaProveedor));
            this.dtgclientes = new System.Windows.Forms.DataGridView();
            this.btnseleccionarcliente = new System.Windows.Forms.Button();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgclientes
            // 
            this.dtgclientes.AllowUserToAddRows = false;
            this.dtgclientes.AllowUserToDeleteRows = false;
            this.dtgclientes.BackgroundColor = System.Drawing.Color.White;
            this.dtgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Direccion,
            this.Telefono});
            this.dtgclientes.Location = new System.Drawing.Point(23, 81);
            this.dtgclientes.MultiSelect = false;
            this.dtgclientes.Name = "dtgclientes";
            this.dtgclientes.ReadOnly = true;
            this.dtgclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgclientes.Size = new System.Drawing.Size(805, 218);
            this.dtgclientes.TabIndex = 46;
            // 
            // btnseleccionarcliente
            // 
            this.btnseleccionarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnseleccionarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionarcliente.Image = ((System.Drawing.Image)(resources.GetObject("btnseleccionarcliente.Image")));
            this.btnseleccionarcliente.Location = new System.Drawing.Point(302, 305);
            this.btnseleccionarcliente.Name = "btnseleccionarcliente";
            this.btnseleccionarcliente.Size = new System.Drawing.Size(77, 39);
            this.btnseleccionarcliente.TabIndex = 45;
            this.btnseleccionarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnseleccionarcliente.UseVisualStyleBackColor = true;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscarcliente.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarcliente.Image")));
            this.btnbuscarcliente.Location = new System.Drawing.Point(757, 54);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(20, 20);
            this.btnbuscarcliente.TabIndex = 44;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            // 
            // txttelefono
            // 
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefono.Location = new System.Drawing.Point(582, 54);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(99, 20);
            this.txttelefono.TabIndex = 43;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(123, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 20);
            this.txtNombre.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Apellidos y nombre";
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(467, 305);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(78, 39);
            this.btncancelar.TabIndex = 47;
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdCliente";
            this.Codigo.HeaderText = "Id";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "RazonSocial";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Apellidos";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 250;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefonos";
            this.Telefono.HeaderText = "Nro Documento";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // frm_BusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 369);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtgclientes);
            this.Controls.Add(this.btnseleccionarcliente);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_BusquedaProveedor";
            this.Text = "Busqueda Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgclientes;
        private System.Windows.Forms.Button btnseleccionarcliente;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}