using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEliasIE
{
    public partial class frmElClub : Form
    {
        clsLogin objBaseDatos;
        public frmElClub()
        {
            InitializeComponent();
        }

        int id = 0;

        private void frmElClub_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsLogin();

            objBaseDatos.ConectarBDElClub();

            lblEstadoConexion.Text = objBaseDatos.estadoConexion;

            lblEstadoConexion.BackColor = Color.Green;

            //objBaseDatos.TraerDatosElClub(); //Al final no la uso


            objBaseDatos.TraerDatosElClub(dtvDatosElClub);

            btnBuscarCliente.Enabled = false;

            btnBuscarClientePorApellido.Enabled = false;
        }

        private void dtvDatosElClub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            clsLogs objLogs = new clsLogs();

            objLogs.RegistroLogBuscarClientePorId();


            objBaseDatos.BuscarPorCodigoDatosElClub(int.Parse(txtBuscarCliente.Text));

            txtBuscarCliente.Clear();
        }

        private void btnBuscarClientePorApellido_Click(object sender, EventArgs e)
        {
            clsLogs objLogs = new clsLogs();

            objLogs.RegistroLogBuscarClientePorApellido();


            objBaseDatos.BuscarPorApellidoDatosElClub(txtBuscarClientePorApellido.Text);

            txtBuscarClientePorApellido.Clear();
        }

        private void frmElClub_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnVolverElClub_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscarCliente.Text != "")
            {
                btnBuscarCliente.Enabled = true;
            }
            else
            {
                btnBuscarCliente.Enabled = false;
            }
        }

        private void txtBuscarClientePorApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarClientePorApellido.Text != "")
            {
                btnBuscarClientePorApellido.Enabled = true;
            }
            else
            {
                btnBuscarClientePorApellido.Enabled = false;
            }
        }

        private void btnCambiarEstadoActivo_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtCambiarEstadoActivo.Text);

            clsLogin objLogin = new clsLogin();

            objLogin.ModificarEstadoActivo(id);

            txtCambiarEstadoActivo.Clear();
        }

        private void txtCambiarEstadoActivo_TextChanged(object sender, EventArgs e)
        {
            if (txtCambiarEstadoActivo.Text != "")
            {
                btnCambiarEstadoActivo.Enabled = true;
            }
            else
            {
                btnCambiarEstadoActivo.Enabled = false;
            }
        }
    }
}
