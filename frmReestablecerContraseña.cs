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
            clsLogs objLogs = new clsLogs();

            objLogs.RegistroLogReestablecerContraseña();

        }
    }
}
