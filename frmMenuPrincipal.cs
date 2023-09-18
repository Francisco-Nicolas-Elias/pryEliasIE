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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void carpetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABM frmABM= new frmABM();
            frmABM.Show();
            this.Hide();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
