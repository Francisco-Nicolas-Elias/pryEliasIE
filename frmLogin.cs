﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryEliasIE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true; // Asegura que el formulario capture las teclas presionadas
            this.KeyDown += new KeyEventHandler(frmLogin_KeyDown); // Suscribe el controlador de eventos
            this.Focus(); // Establece el foco en el formulario
        }

        public static string usuario;
        public static string contraseña;
        int contador = 0;

        frmReestablecerContraseña frmReestablecerContraseña = new frmReestablecerContraseña();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
            btnReestablecerContraseña.Enabled = false;
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCrearCuenta frmCrearCuenta = new frmCrearCuenta();
            frmCrearCuenta.Show();
            this.Hide();
        }
        
        private void btnReestablecerContraseña_Click(object sender, EventArgs e)
        {
            frmReestablecerContraseña frmReestablecerContraseña = new frmReestablecerContraseña();

            frmReestablecerContraseña.txtUsuarioReestablecerContraseña.Text = txtUsuario.Text;
            frmReestablecerContraseña.txtUsuarioReestablecerContraseña.ReadOnly = true;

            frmReestablecerContraseña.Show();
            
            this.Hide();
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            clsLogin login = new clsLogin();
            login.BuscarUsuario();

            clsLogs objLogs = new clsLogs();


            
            //objLogs.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);       

            //Si el usuario y contraseña son correctos, ingresa
            if (clsLogin.acceso == true)
            {
                objLogs.RegistroLogInicioSesionExitoso();
                

                this.Hide();
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
            }
            else
            {
                objLogs.RegistroLogInicioSesionFallido();

                contador = contador + 1;
                MessageBox.Show("Usuario o contraeña incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (contador == 2)
                {
                    MessageBox.Show("Le queda un solo intento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Si intenta ingresar 3 veces y no es correcta la cuenta se bloquea el botón de ingreso
                if (contador > 2)
                {
                    btnIngresar.Enabled = false;
                    MessageBox.Show("Ingreso bloqueado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contador = 0;
                }
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario cuando se presiona la tecla Escape
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pctOcultarContraseña_Click(object sender, EventArgs e)
        {
            pctOcultarConstraseña.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void pctMostrarConstraseña_Click(object sender, EventArgs e)
        {
            pctMostrarContraseña.BringToFront();
            txtContraseña.PasswordChar = '\0';         
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" & txtContraseña.Text != "")
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }

            if (txtUsuario.Text != "")
            {
                btnReestablecerContraseña.Enabled = true;
            }
            else
            {
                btnReestablecerContraseña.Enabled = false;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" & txtContraseña.Text != "")
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                btnIngresar_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar == 13)
            {
                txtContraseña.Focus();
                e.Handled = true;
            }
        }
    }
}
