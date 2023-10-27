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
            this.KeyPreview = true; // Asegura que el formulario capture las teclas presionadas
            this.KeyDown += new KeyEventHandler(frmMenuPrincipal_KeyDown); // Suscribe el controlador de eventos
            this.Focus(); // Establece el foco en el formulario
        }

        private void carpetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Cierra el formulario cuando se presiona la tecla Escape
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmElClub frmElClub = new frmElClub();
            frmElClub.Show();
            this.Hide();
        }
    }
}
