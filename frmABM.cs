using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryEliasIE
{
    public partial class frmABM : Form
    {
        public frmABM()
        {
            InitializeComponent();
        }

        private void frmABM_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverABM_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNumeroDeExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();   
            txtDireccion.Clear();
            txtLiquidadorResponsable.Clear();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNumeroDeExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidadorResponsable.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNumeroDeExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidadorResponsable.Clear();
        }
    }
}
