﻿using System;
using BL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AE;
using MetroFramework;
using System.IO;

namespace App_AcademicManagement
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        private blSesion oBlsesion = new blSesion();
        private aeUser User = new aeUser();
        public frmLogin()
        {
            InitializeComponent();
            Diseñar();
        }
        void Diseñar()
        {
            tabLogin.SelectedIndex = 0;
            this.Size = new Size(370, 505);
            this.pnlRegister.Location = PnlLogin.Location;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errProvider.Clear();
            if (!RegisterPanel)
            {
                RegisterPanel = true;
                mLinkRegister.Text = "Register";
                this.mLinkRegister.Location = new System.Drawing.Point(90, 315);
                this.mLinkRegister.Name = "mLinkRegister";
                this.mLinkRegister.Size = new System.Drawing.Size(149, 71);
            }
            
            if (this.tabLogin.SelectedIndex == 1)
            {
                this.PnlLogin.SendToBack();
            }
            else
            {
                this.pnlRegister.SendToBack();
            }
            CleanFields();
        }

        private void mLinkRegister_Click(object sender, EventArgs e)
        {
            if (isValidate())
            {
                aeControlError v = new aeControlError();
                aeUser oAeUser = new aeUser();
                blUser oBlUser = new blUser();
                oAeUser.Usuario = txtUserNew.Text;
                oAeUser.Contraseña = Encriptar(txtPassNew.Text);
                if (RegisterPanel)
                {
                    try
                    {
                        oBlUser.CreateUser(oAeUser);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        oBlUser.CambiarContraseña(oAeUser);
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                this.tabLogin.SelectedIndex = 0;
                CleanFields();
            }
        }
        private bool isValidate()
        {
            if (txtUserNew.Text == string.Empty)
            {
                errProvider.Clear();
                errProvider.SetError(txtUserNew, "Empty name");
                txtUserNew.Focus();
                return false;
            }
            if (txtPassNew.Text == string.Empty)
            {
                errProvider.Clear();
                errProvider.SetError(txtPassNew, "Empty password");
                txtPassNew.Focus();
                return false;
            }
            if (txtPassNew.Text != txtPassNewRepeat.Text)
            {
                errProvider.Clear();
                errProvider.SetError(txtPassNewRepeat, "Password does not match");
                txtPassNewRepeat.Focus();
                return false;
            }
            errProvider.Clear();
            return true;
        }
        private void CleanFields()
        {
            txtUserNew.Text = "";
            txtPassNew.Text = "";
            txtPassNewRepeat.Text = "";
            txtUser.Text = "";
            txtPasword.Text = "";
        }
        private void mLinkIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                errProvider.Clear();
                errProvider.SetError(txtUser, "Usuario vacio");
                txtUser.Focus();
                return ;
            }
            if (txtPasword.Text == string.Empty)
            {
                errProvider.Clear();
                errProvider.SetError(txtPasword, "Contraseña vacia");
                txtPasword.Focus();
                return;
            }
            if (txtUser.Text == string.Empty) return;
            if (ValidarUsuario())
            {

               this.DialogResult = DialogResult.OK;
                this.Visible = false;
                txtPasword.Text = string.Empty;
                frmCargaInicial program = new frmCargaInicial(User);
                program.ShowDialog();
                this.Visible = true;
                program.Close();
                program.Dispose();
            }
        }

        private bool ValidarUsuario()
        {
            try
            {
                User.Usuario = txtUser.Text;
                //Encriptar pass
                User.Contraseña = Encriptar(txtPasword.Text);
                User = oBlsesion.ValidateUser(User);
                return true;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
        

        private string Encriptar(string KeyText)
        {
            string key = KeyText.Trim();
            string keyEncriptado = string.Empty;
            int intKey = 100;
            for (int i = 0; i < key.Length ; i++)
            {
                intKey = (intKey + Encoding.ASCII.GetBytes(key.Substring(i,1))[0]);
            }
            intKey = intKey % 31;
            int envertido = 1;
            int iLength = 0;
            string strTemporal;
            for (int i = 0; i < key.Length; i++)
            {
                envertido = envertido * -1;
                intKey = intKey == 0 ? 19 : intKey;
                iLength = (intKey + Encoding.ASCII.GetBytes(key.Substring(i, 1))[0])+ (intKey * envertido);
                strTemporal = iLength.ToString("X").PadLeft(2, '0');
                keyEncriptado = keyEncriptado + strTemporal.Substring(strTemporal.Length - 2, 2);
                intKey--;
            }
            return keyEncriptado;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            this.picUser.Image = Properties.Resources.user2;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            this.picUser.Image = Properties.Resources.user;
        }

        private void txtPasword_Enter(object sender, EventArgs e)
        {
            this.picPass.Image = Properties.Resources.pass2;

        }

        private void txtPasword_Leave(object sender, EventArgs e)
        {
            this.picPass.Image = Properties.Resources.pass;

        }

        private void txtUserNew_Enter(object sender, EventArgs e)
        {
            this.picNewUser.Image = Properties.Resources.user2;

        }

        private void txtUserNew_Leave(object sender, EventArgs e)
        {
            this.picNewUser.Image = Properties.Resources.user;

        }

        private void txtPassNew_Enter(object sender, EventArgs e)
        {
            this.picNewPass.Image = Properties.Resources.pass2;

        }

        private void txtPassNew_Leave(object sender, EventArgs e)
        {
            this.picNewPass.Image = Properties.Resources.pass;

        }

        private void txtPassNewRepeat_Enter(object sender, EventArgs e)
        {
            this.picNewPassRepeat.Image = Properties.Resources.pass2;

        }

        private void txtPassNewRepeat_Leave(object sender, EventArgs e)
        {
            this.picNewPassRepeat.Image = Properties.Resources.pass;

        }

        bool RegisterPanel = true;
        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.tabLogin.SelectedIndex = 1;
            RegisterPanel = false;
            this.mLinkRegister.Text = "Cambiar contraseña";
            this.mLinkRegister.Location = new System.Drawing.Point(41, 315);
            this.mLinkRegister.Size = new System.Drawing.Size(248, 71);
            this.PnlLogin.SendToBack();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tabLogin.SelectedIndex == 0)
            {
                mLinkIngresar_Click(null, null);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
