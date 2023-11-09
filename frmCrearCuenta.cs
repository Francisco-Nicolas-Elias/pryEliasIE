using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEliasIE
{
    public partial class frmCrearCuenta : Form
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        public static string usuarioCrearCuenta;
        public static string contraseñaCrearCuenta;
        public static string repitaContraseñaCrearCuenta;
        public static string perfilCrearCuenta;
        public static string lasContraseñasSonIguales;

        private void btnVolverCrearCuenta_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnCrearCuentaNuevoUsuario_Click(object sender, EventArgs e)
        {
            usuarioCrearCuenta = txtNuevoUsuario.Text;
            contraseñaCrearCuenta = txtNuevaContraseñaUsuarioNuevo.Text;
            repitaContraseñaCrearCuenta = txtRepitaNuevaContraseñaUsuarioNuevo.Text;
            perfilCrearCuenta = txtPerfil.Text;

            clsLogs objLogs = new clsLogs();

            if (contraseñaCrearCuenta == repitaContraseñaCrearCuenta)
            {
                lasContraseñasSonIguales = contraseñaCrearCuenta;

                MessageBox.Show("Cuenta creada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                clsLogin objLogin = new clsLogin();

                objLogin.CrearCuenta();

         
                objLogs.RegistroLogCrearCuentaExitoso();
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                objLogs.RegistroLogCrearCuentaFallido();
            }

            
        }

        private void txtNuevoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevoUsuario.Text != "" & txtNuevaContraseñaUsuarioNuevo.Text != "" & txtRepitaNuevaContraseñaUsuarioNuevo.Text != "" & txtPerfil.Text != "")
            {
                btnCrearCuentaNuevoUsuario.Enabled = true;
            }
            else
            {
                btnCrearCuentaNuevoUsuario.Enabled = false;
            }
        }

        private void txtNuevaContraseñaUsuarioNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevoUsuario.Text != "" & txtNuevaContraseñaUsuarioNuevo.Text != "" & txtRepitaNuevaContraseñaUsuarioNuevo.Text != "" & txtPerfil.Text != "")
            {
                btnCrearCuentaNuevoUsuario.Enabled = true;
            }
            else
            {
                btnCrearCuentaNuevoUsuario.Enabled = false;
            }
        }

        private void txtRepitaNuevaContraseñaUsuarioNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevoUsuario.Text != "" & txtNuevaContraseñaUsuarioNuevo.Text != "" & txtRepitaNuevaContraseñaUsuarioNuevo.Text != "" & txtPerfil.Text != "")
            {
                btnCrearCuentaNuevoUsuario.Enabled = true;
            }
            else
            {
                btnCrearCuentaNuevoUsuario.Enabled = false;
            }
        }

        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {
            if (txtNuevoUsuario.Text != "" & txtNuevaContraseñaUsuarioNuevo.Text != "" & txtRepitaNuevaContraseñaUsuarioNuevo.Text != "" & txtPerfil.Text != "")
            {
                btnCrearCuentaNuevoUsuario.Enabled = true;
            }
            else
            {
                btnCrearCuentaNuevoUsuario.Enabled = false;
            }
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {
            btnCrearCuentaNuevoUsuario.Enabled = false;
        }

        private void pctOcultarContraseñaCrearCuenta_Click(object sender, EventArgs e)
        {
            pctMostrarContraseñaCrearCuenta.BringToFront();
            txtNuevaContraseñaUsuarioNuevo.PasswordChar = '*';
        }

        private void pctMostrarContraseñaCrearCuenta_Click(object sender, EventArgs e)
        {
            pctOcultarContraseñaCrearCuenta.BringToFront();
            txtNuevaContraseñaUsuarioNuevo.PasswordChar = '\0';

        }

        private void pctMostrarContraseñaCrearCuentaRepitaContraseña_Click(object sender, EventArgs e)
        {
            pctOcultarContraseñaCrearCuentaRepitaContraseña.BringToFront();
            txtRepitaNuevaContraseñaUsuarioNuevo.PasswordChar = '\0';
        }

        private void pctOcultarContraseñaCrearCuentaRepitaContraseña_Click(object sender, EventArgs e)
        {
            pctMostrarContraseñaCrearCuentaRepitaContraseña.BringToFront();
            txtRepitaNuevaContraseñaUsuarioNuevo.PasswordChar = '*';
        }
    }
}
