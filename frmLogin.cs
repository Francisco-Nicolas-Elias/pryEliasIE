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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnReestablecerContraseña_Click(object sender, EventArgs e)
        {
            frmReestablecerContraseña frmReestablecerContraseña = new frmReestablecerContraseña();
            frmReestablecerContraseña.Show();
            this.Close();
        }
    }
}
