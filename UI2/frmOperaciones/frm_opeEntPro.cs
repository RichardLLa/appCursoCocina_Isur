using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BL;
using AE;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.IO;

namespace UI2
{
    public partial class frm_opeEntPro : MetroForm
    {
        private blProduct oBL;
        static string _error = null;
        public frm_opeEntPro()
        {
            InitializeComponent();
            CargarProductos();
            dtgDetailsOperation.AutoGenerateColumns = false;
            //dgwProductos.DataSource = detalles;
            oBL = new blProduct();
        }
        #region Variables
        //private bool _isPress;
        private aeProduct productSelected = new aeProduct();
        private List<aeDeatailOperation> detalles = new List<aeDeatailOperation>();
        double Cantidad = 0;
        #endregion
        #region Metodos
        private void AlterarProducto()
        {
            productSelected.UnitPrice = Convert.ToInt32(txtPrecio.Text);
        }

        #endregion
        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusquedaProduct.Visible)
            {
                int Nro0 = 1;
                List<aeProduct> oLista = oBL.GetRowsSearch(ref _error, txtBusquedaProduct.Text);
                flpProducts.Controls.Clear();
                foreach (var item in oLista)
                {
                    AddButtonProducts(Nro0, item.Name, item.CodeCategory, item.IdProduct);
                    Nro0++;
                }
            }
            else
            {
                txtBusquedaProduct.Text = string.Empty;
                txtBusquedaProduct.Visible = true;
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(46) && !txt.Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void btnAgregarEliminar_Click(object sender, EventArgs e)
        {
            if (isValidate())
            {
                AlterarProducto();
                aeDeatailOperation oRow = new aeDeatailOperation(productSelected.Name, productSelected.IdProduct,
                    Cantidad, productSelected.UnitPrice);
                detalles.Add(oRow);
                dtgDetailsOperation.Rows.Add("", productSelected.Name, productSelected.IdProduct, Cantidad, 
                    productSelected.UnitPrice,txtTotal.Text);
                dtgDetailsOperation.Refresh();
                SumarTotal();
            }
        }

        private void SumarTotal()
        {
            double suma = 0;
            foreach (var item in detalles)
            {
                suma = item.UnitPrice * item.Quantity;
            }
        }

        private bool isValidate()
        {
            if (lblDescripcion.Text == string.Empty) return false;
            if (txtPrecio.Text == string.Empty) return false;
            if (txtCantidad.Text == string.Empty) return false;
            return true;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            try
            {
                Cantidad = Convert.ToDouble(txtCantidad.Text);
                txtTotal.Text = (productSelected.UnitPrice * Cantidad).ToString();
                txtCantidad.Text = Cantidad.ToString();
            }
            catch (Exception ex)
            {
                productSelected.UnitPrice = 0;
                txtCantidad.Text = "0";
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrecio_Leave(null, null);
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCantidad_Leave(null, null);
            }
        }

        private void txtBusquedaProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int Nro0 = 1;
                List<aeProduct> oLista = oBL.GetRowsSearch(ref _error, txtBusquedaProduct.Text);
                flpProducts.Controls.Clear();
                foreach (var item in oLista)
                {
                    AddButtonProducts(Nro0, item.Name, item.CodeCategory, item.IdProduct);
                    Nro0++;
                }
            }
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            try
            {
                productSelected.UnitPrice = Convert.ToDouble(txtPrecio.Text);
                txtTotal.Text = (productSelected.UnitPrice * Cantidad).ToString();
                txtPrecio.Text = productSelected.UnitPrice.ToString();
            }
            catch (Exception ex)
            {
                productSelected.UnitPrice = 0;
                txtPrecio.Text = "0";
            }
        }
        #endregion
        #region Button dinamicos
        #region Variables
        private Button btnClick = null;

        #endregion
        #region Metodos
        public void CargarProductos()
        {
            blCategory blCat = new blCategory();
            int nros = 1;
            foreach (var item in blCat.GetRows(ref _error))
            {
                AddButtonCategorias(nros, item.Name, item.IdCategory, item.Code);
                nros++;
            }
        }
        private void AddButtonCategorias(int a, string Nombre, int pId, string pCode)
        {
            Button btnCategoria = new Button();
            flpCategorias.Controls.Add(btnCategoria);
            btnCategoria.Text = Nombre;
            btnCategoria.Name = "btn_" + pId;
            btnCategoria.Tag = pCode;
            btnCategoria.BackColor = Color.WhiteSmoke;
            // btnCategoria.Image = global::SIGEREB.Properties.Resources.minus;
            btnCategoria.Height = 40;
            btnCategoria.Width = 100;
            btnCategoria.FlatStyle = FlatStyle.Popup;
            btnCategoria.Click += btnCategoria_Click;
            btnCategoria.Location = new Point(55 * (a - 1) + 10, 0);
        }
        private void AddButtonProducts(int a, string pName, string pCode, int pId)
        {
            try
            {
                Button btnProduct = new Button();
                flpProducts.Controls.Add(btnProduct);
                btnProduct.Text = pName;
                btnProduct.Name = "btn_" + pId;
                btnProduct.Tag = pCode;
                Image img = (Image)Properties.Resources.ResourceManager.GetObject(pCode);
                //var oDirectory = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "img\\");
                //Image img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + Path.Combine("img",pCode));
                //foreach (string context in oDirectory)
                //{
                //    if (context.Contains(pCode))
                //    {
                //        img = Image.FromFile(context);
                //    }
                //}
                //btnProduct.Image = (Image)(new Bitmap(img, new Size(70, 70)));
                btnProduct.Image = img;
                btnProduct.ImageAlign = ContentAlignment.TopCenter;
                btnProduct.TextAlign = ContentAlignment.BottomCenter;
                btnProduct.Height = 70;
                btnProduct.Width = 85;
                btnProduct.FlatStyle = FlatStyle.Popup;
                btnProduct.MouseEnter += BtnProduct_MouseEnter;
                btnProduct.MouseLeave += BtnProduct_MouseLeave;
                btnProduct.Click += AgregarPedido_Click;
                //btnPlatos.DoubleClick += AgregarPedido_DoubleClick;
                btnProduct.Location = new Point(55 * (a - 1) + 10, 0);
            }
            catch (Exception excep)
            {
                throw new Exception(excep.Message, excep);
            }
        }


        #endregion
        #region Eventos
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            txtBusquedaProduct.Visible = false;
            var oButton = ((Button)sender);
            lblTituloArticulos.Text = oButton.Text;
            int IDCategory = Convert.ToInt32(oButton.Name.Split(new char[] { '_' }).Last());
            int Nro0 = 1;
            // FlowLayoutPanel flpArticulo = new FlowLayoutPanel();
            _error = null;
            List<aeProduct> oLista = oBL.GetRows(ref _error, IDCategory);
            flpProducts.Controls.Clear();
            foreach (var item in oLista)
            {
                AddButtonProducts(Nro0, item.Name, item.CodeCategory, item.IdProduct);
                Nro0++;
            }
        }
        private void BtnProduct_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnClick) return;
            btn.Image = (Image)Properties.Resources.ResourceManager.GetObject(btn.Tag.ToString());
        }
        private void BtnProduct_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Image = (Image)Properties.Resources.ResourceManager.GetObject(btn.Tag.ToString() + "2");
        }
        private void AgregarPedido_Click(object sender, EventArgs e)
        {
            Button oButton = ((Button)sender);
            if (btnClick != null)
            {
                btnClick.Image = (Image)Properties.Resources.ResourceManager.GetObject(btnClick.Tag.ToString());
            }
            btnClick = oButton;
            int IDProduct = Convert.ToInt32(oButton.Name.Split(new char[] { '_' }).Last());
            productSelected = oBL.GetRowById(ref _error, IDProduct);
            if (_error == null)
            {
                lblStock.Text = "Stock: " + productSelected.Stock;
                lblDescripcion.Text = productSelected.Name;
                txtPrecio.Text = productSelected.UnitPrice.ToString();
                txtCantidad.Text = "1";
                txtTotal.Text = productSelected.UnitPrice.ToString();
            }
        }


        #endregion

        #endregion


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
