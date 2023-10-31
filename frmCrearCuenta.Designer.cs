namespace pryEliasIE
{
    partial class frmCrearCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRepitaNuevaContraseñaUsuarioNuevo = new System.Windows.Forms.TextBox();
            this.lblRepitaNuevaContraseñaUsuarioNuevo = new System.Windows.Forms.Label();
            this.btnVolverCrearCuenta = new System.Windows.Forms.Button();
            this.btnCrearCuentaNuevoUsuario = new System.Windows.Forms.Button();
            this.pctLogoReestablecerContraseña = new System.Windows.Forms.PictureBox();
            this.txtNuevaContraseñaUsuarioNuevo = new System.Windows.Forms.TextBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblNuevaContraseñaUsuarioNuevo = new System.Windows.Forms.Label();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoReestablecerContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepitaNuevaContraseñaUsuarioNuevo
            // 
            this.txtRepitaNuevaContraseñaUsuarioNuevo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepitaNuevaContraseñaUsuarioNuevo.Location = new System.Drawing.Point(171, 102);
            this.txtRepitaNuevaContraseñaUsuarioNuevo.Name = "txtRepitaNuevaContraseñaUsuarioNuevo";
            this.txtRepitaNuevaContraseñaUsuarioNuevo.Size = new System.Drawing.Size(150, 25);
            this.txtRepitaNuevaContraseñaUsuarioNuevo.TabIndex = 17;
            this.txtRepitaNuevaContraseñaUsuarioNuevo.TextChanged += new System.EventHandler(this.txtRepitaNuevaContraseñaUsuarioNuevo_TextChanged);
            // 
            // lblRepitaNuevaContraseñaUsuarioNuevo
            // 
            this.lblRepitaNuevaContraseñaUsuarioNuevo.AutoSize = true;
            this.lblRepitaNuevaContraseñaUsuarioNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lblRepitaNuevaContraseñaUsuarioNuevo.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepitaNuevaContraseñaUsuarioNuevo.ForeColor = System.Drawing.Color.White;
            this.lblRepitaNuevaContraseñaUsuarioNuevo.Location = new System.Drawing.Point(12, 108);
            this.lblRepitaNuevaContraseñaUsuarioNuevo.Name = "lblRepitaNuevaContraseñaUsuarioNuevo";
            this.lblRepitaNuevaContraseñaUsuarioNuevo.Size = new System.Drawing.Size(158, 19);
            this.lblRepitaNuevaContraseñaUsuarioNuevo.TabIndex = 16;
            this.lblRepitaNuevaContraseñaUsuarioNuevo.Text = "Repita contraseña:";
            // 
            // btnVolverCrearCuenta
            // 
            this.btnVolverCrearCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverCrearCuenta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverCrearCuenta.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCrearCuenta.Location = new System.Drawing.Point(12, 251);
            this.btnVolverCrearCuenta.Name = "btnVolverCrearCuenta";
            this.btnVolverCrearCuenta.Size = new System.Drawing.Size(105, 50);
            this.btnVolverCrearCuenta.TabIndex = 15;
            this.btnVolverCrearCuenta.Text = "Volver";
            this.btnVolverCrearCuenta.UseVisualStyleBackColor = false;
            this.btnVolverCrearCuenta.Click += new System.EventHandler(this.btnVolverCrearCuenta_Click);
            // 
            // btnCrearCuentaNuevoUsuario
            // 
            this.btnCrearCuentaNuevoUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearCuentaNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCuentaNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearCuentaNuevoUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuentaNuevoUsuario.Location = new System.Drawing.Point(16, 169);
            this.btnCrearCuentaNuevoUsuario.Name = "btnCrearCuentaNuevoUsuario";
            this.btnCrearCuentaNuevoUsuario.Size = new System.Drawing.Size(357, 42);
            this.btnCrearCuentaNuevoUsuario.TabIndex = 14;
            this.btnCrearCuentaNuevoUsuario.Text = "Crear cuenta";
            this.btnCrearCuentaNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnCrearCuentaNuevoUsuario.Click += new System.EventHandler(this.btnCrearCuentaNuevoUsuario_Click);
            // 
            // pctLogoReestablecerContraseña
            // 
            this.pctLogoReestablecerContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.pctLogoReestablecerContraseña.Image = global::pryEliasIE.Properties.Resources.LogoSistemaDeSeguros;
            this.pctLogoReestablecerContraseña.Location = new System.Drawing.Point(393, 22);
            this.pctLogoReestablecerContraseña.Name = "pctLogoReestablecerContraseña";
            this.pctLogoReestablecerContraseña.Size = new System.Drawing.Size(190, 189);
            this.pctLogoReestablecerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogoReestablecerContraseña.TabIndex = 13;
            this.pctLogoReestablecerContraseña.TabStop = false;
            // 
            // txtNuevaContraseñaUsuarioNuevo
            // 
            this.txtNuevaContraseñaUsuarioNuevo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraseñaUsuarioNuevo.Location = new System.Drawing.Point(171, 65);
            this.txtNuevaContraseñaUsuarioNuevo.Name = "txtNuevaContraseñaUsuarioNuevo";
            this.txtNuevaContraseñaUsuarioNuevo.Size = new System.Drawing.Size(150, 25);
            this.txtNuevaContraseñaUsuarioNuevo.TabIndex = 12;
            this.txtNuevaContraseñaUsuarioNuevo.TextChanged += new System.EventHandler(this.txtNuevaContraseñaUsuarioNuevo_TextChanged);
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoUsuario.Location = new System.Drawing.Point(171, 28);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(150, 25);
            this.txtNuevoUsuario.TabIndex = 11;
            this.txtNuevoUsuario.TextChanged += new System.EventHandler(this.txtNuevoUsuario_TextChanged);
            // 
            // lblNuevaContraseñaUsuarioNuevo
            // 
            this.lblNuevaContraseñaUsuarioNuevo.AutoSize = true;
            this.lblNuevaContraseñaUsuarioNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaContraseñaUsuarioNuevo.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseñaUsuarioNuevo.ForeColor = System.Drawing.Color.White;
            this.lblNuevaContraseñaUsuarioNuevo.Location = new System.Drawing.Point(12, 71);
            this.lblNuevaContraseñaUsuarioNuevo.Name = "lblNuevaContraseñaUsuarioNuevo";
            this.lblNuevaContraseñaUsuarioNuevo.Size = new System.Drawing.Size(106, 19);
            this.lblNuevaContraseñaUsuarioNuevo.TabIndex = 10;
            this.lblNuevaContraseñaUsuarioNuevo.Text = "Contraseña:";
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoUsuario.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(12, 34);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(76, 19);
            this.lblNuevoUsuario.TabIndex = 9;
            this.lblNuevoUsuario.Text = "Usuario:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.White;
            this.lblPerfil.Location = new System.Drawing.Point(12, 147);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(55, 19);
            this.lblPerfil.TabIndex = 18;
            this.lblPerfil.Text = "Perfil:";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(171, 138);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(150, 25);
            this.txtPerfil.TabIndex = 19;
            this.txtPerfil.TextChanged += new System.EventHandler(this.txtPerfil_TextChanged);
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEliasIE.Properties.Resources.fondo_de_ventanas_mejor_calidad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 313);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.txtRepitaNuevaContraseñaUsuarioNuevo);
            this.Controls.Add(this.lblRepitaNuevaContraseñaUsuarioNuevo);
            this.Controls.Add(this.btnVolverCrearCuenta);
            this.Controls.Add(this.btnCrearCuentaNuevoUsuario);
            this.Controls.Add(this.pctLogoReestablecerContraseña);
            this.Controls.Add(this.txtNuevaContraseñaUsuarioNuevo);
            this.Controls.Add(this.txtNuevoUsuario);
            this.Controls.Add(this.lblNuevaContraseñaUsuarioNuevo);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNE Venta de seguros";
            this.Load += new System.EventHandler(this.frmCrearCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoReestablecerContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepitaNuevaContraseñaUsuarioNuevo;
        private System.Windows.Forms.Label lblRepitaNuevaContraseñaUsuarioNuevo;
        private System.Windows.Forms.Button btnVolverCrearCuenta;
        private System.Windows.Forms.Button btnCrearCuentaNuevoUsuario;
        private System.Windows.Forms.PictureBox pctLogoReestablecerContraseña;
        private System.Windows.Forms.TextBox txtNuevaContraseñaUsuarioNuevo;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label lblNuevaContraseñaUsuarioNuevo;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtPerfil;
    }
}