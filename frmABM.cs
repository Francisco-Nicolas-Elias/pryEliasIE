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

        public static string rutaArchivoAbm;

        private void frmABM_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverABM_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.Show();
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nuevaLinea = txtNumero.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtNumeroDeExpediente.Text + ";" + txtJuzgado.Text + ";" + txtJurisdiccion.Text + ";" + txtDireccion.Text + ";" + txtLiquidadorResponsable.Text + ";";

            // Agregar la nueva línea al archivo
            File.AppendAllText(rutaArchivoAbm, nuevaLinea + Environment.NewLine);

            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNumeroDeExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidadorResponsable.Clear();

            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.Show();
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {              
                btnGrabar.Enabled = true;               
            }
            else
            {
                btnGrabar.Enabled = false;              
            }
        }

        private void txtEntidad_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtApertura_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtNumeroDeExpediente_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtJuzgado_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtJurisdiccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtLiquidadorResponsable_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumeroDeExpediente.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNumeroDeExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidadorResponsable.Clear();

            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.Show();
            this.Close();
        }
    }
}
