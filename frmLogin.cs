using System;
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnReestablecerContraseña_Click(object sender, EventArgs e)
        {
            frmReestablecerContraseña frmReestablecerContraseña = new frmReestablecerContraseña();
            frmReestablecerContraseña.Show();
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            clsLogin login = new clsLogin();
            login.BuscarUsuario();

            if (clsLogin.acceso == true)
            {
                this.Hide();
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
            }
            else
            {
                contador = contador + 1;
                MessageBox.Show("Usuario o contraeña incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (contador == 2)
                {
                    MessageBox.Show("Le queda un solo intento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
                this.Close(); // Cierra el formulario cuando se presiona la tecla Escape.
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
