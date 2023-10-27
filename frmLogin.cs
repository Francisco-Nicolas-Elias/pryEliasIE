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
                MessageBox.Show("Usuario o Contraeña incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (contador > 2)
                {
                    btnIngresar.Enabled = false;
                    contador = 0;
                }
            }
        }
    }
}
