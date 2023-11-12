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
    public partial class frmReestablecerContraseña : Form
    {
        public frmReestablecerContraseña()
        {
            InitializeComponent();
        }

        public static string usuarioReestablecerContraseña;
        public static string contraseñaReestablecerContraseña;
        public static string repitaContraseñaReestablecerContraseña;
        public static string contraseñasIguales;

        private void btnVolverReestablecerContraseña_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtUsuarioReestablecerContraseña.Text != "" & txtNuevaContraseña.Text != "" & txtRepitaNuevaContraseña.Text != "")
            {
                btnContraseñaReestablecida.Enabled = true;
            }
            else
            {
                btnContraseñaReestablecida.Enabled = false;
            }
        }

        private void txtNuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuarioReestablecerContraseña.Text != "" & txtNuevaContraseña.Text != "" & txtRepitaNuevaContraseña.Text != "")
            {
                btnContraseñaReestablecida.Enabled = true;
            }
            else
            {
                btnContraseñaReestablecida.Enabled = false;
            }
        }

        private void txtRepitaNuevaContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuarioReestablecerContraseña.Text != "" & txtNuevaContraseña.Text != "" & txtRepitaNuevaContraseña.Text != "")
            {
                btnContraseñaReestablecida.Enabled = true;
            }
            else
            {
                btnContraseñaReestablecida.Enabled = false;
            }
        }

        private void frmReestablecerContraseña_Load(object sender, EventArgs e)
        {
            btnContraseñaReestablecida.Enabled = false;
        }

        private void btnContraseñaReestablecida_Click(object sender, EventArgs e)
        {
            usuarioReestablecerContraseña = txtUsuarioReestablecerContraseña.Text;
            contraseñaReestablecerContraseña = txtNuevaContraseña.Text;
            repitaContraseñaReestablecerContraseña = txtRepitaNuevaContraseña.Text;

            clsLogs objLogs = new clsLogs();

            if (contraseñaReestablecerContraseña == repitaContraseñaReestablecerContraseña)
            {
                contraseñasIguales = contraseñaReestablecerContraseña;

                MessageBox.Show("Contraseña reestablecida con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                clsLogin objLogin = new clsLogin();

                objLogin.ReestablecerContraseña(usuarioReestablecerContraseña);

                objLogs.RegistroLogReestablecerContraseñaExitoso();
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                objLogs.RegistroLogReestablecerContraseñaFallido();
            }
        }

        private void pctMostrarContraseñaReestablecerContraseña_Click(object sender, EventArgs e)
        {
            pctOcultarContraseñaReestablecerContraseña.BringToFront();
            txtNuevaContraseña.PasswordChar = '\0';
        }

        private void pctOcultarContraseñaReestablecerContraseña_Click(object sender, EventArgs e)
        {
            pctMostrarContraseñaReestablecerContraseña.BringToFront();
            txtNuevaContraseña.PasswordChar = '*';
        }

        private void pctMostrarRepitaNuevaContraseñaReestablecerContraseña_Click(object sender, EventArgs e)
        {
            pctOcultarRepitaNuevaContraseñaReestablecerContraseña.BringToFront();
            txtRepitaNuevaContraseña.PasswordChar = '\0';
        }

        private void pctOcultarRepitaNuevaContraseñaReestablecerContraseña_Click(object sender, EventArgs e)
        {
            pctMostrarRepitaNuevaContraseñaReestablecerContraseña.BringToFront();
            txtRepitaNuevaContraseña.PasswordChar = '*';
        }
    }
}
