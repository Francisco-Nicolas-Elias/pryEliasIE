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
    public partial class frmElClub : Form
    {
        clsLogin objBaseDatos;
        public frmElClub()
        {
            InitializeComponent();
        }

        private void frmElClub_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsLogin();

            objBaseDatos.ConectarBDElClub();

            lblEstadoConexion.Text = objBaseDatos.estadoConexion;

            lblEstadoConexion.BackColor = Color.Green;

            objBaseDatos.TraerDatosElClub();


            objBaseDatos.TraerDatosElClub(dtvDatosElClub);
        }

        private void dtvDatosElClub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarPorCodigoDatosElClub(int.Parse(txtBuscarCliente.Text));

            txtBuscarCliente.Clear();
        }

        private void btnBuscarClientePorApellido_Click(object sender, EventArgs e)
        {
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
    }
}
