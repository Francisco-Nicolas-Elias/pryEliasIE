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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            lblDireccionDeArchivo.Text = fbdVentanaCarpetas.SelectedPath;
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabarArchivo_Click(object sender, EventArgs e)
        {
            //Ruta del archivo

            String ruta = fbdVentanaCarpetas.SelectedPath;
            
            //Nombre del archivo

            ruta += txtNombreArchivo.Text;

            StreamWriter manejoArchivo = new StreamWriter(ruta);

            MessageBox.Show("Archivo creado" + txtNombreArchivo.Text);

        }
    }
}
