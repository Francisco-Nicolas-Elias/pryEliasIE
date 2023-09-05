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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();

                frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
                frmVentanaPrincipal.ShowDialog();

                this.Close();
            }
        }
    }
}
