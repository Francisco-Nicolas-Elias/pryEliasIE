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

        private void btnVolverCrearCuenta_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnCrearCuentaNuevoUsuario_Click(object sender, EventArgs e)
        {
            clsLogs objLogs = new clsLogs();

            objLogs.RegistroLogCrearCuenta();
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
    }
}
