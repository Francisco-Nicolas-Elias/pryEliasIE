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
    public partial class frmVentanaGrilla : Form
    {
        public frmVentanaGrilla()
        {
            InitializeComponent();
        }
        private void btnVolverVentanaGrilla_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.Show();
            this.Close();

            dtvMostrarArchivo.Rows.Clear();
        }

        private void btnMostrarGrilla_Click(object sender, EventArgs e)
        {
            
        }

        private void frmVentanaGrilla_Load(object sender, EventArgs e)
        {

        }

        private void dtvMostrarArchivo_DoubleClick(object sender, EventArgs e)
        {
            frmABM frmABM = new frmABM();
            frmABM.Show();
            this.Hide();
        }
    }
}
