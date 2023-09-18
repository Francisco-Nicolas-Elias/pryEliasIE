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
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();

            dtvMostrarArchivo.Rows.Clear();
        }
    }
}
