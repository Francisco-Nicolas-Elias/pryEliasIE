﻿using System;
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

        Int32 i = 0;

        private void btnVolverVentanaGrilla_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();

            dtvMostrarArchivo.Rows.Clear();
        }

        private void btnMostrarGrilla_Click(object sender, EventArgs e)
        {
            while (i < 1000)
            {
                dtvMostrarArchivo.Rows.Add();

                i = i + 1;

            }
        }
    }
}