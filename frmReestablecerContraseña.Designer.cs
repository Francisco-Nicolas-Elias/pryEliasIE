namespace pryEliasIE
{
    partial class frmReestablecerContraseña
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
            this.lblUsuarioReestablecerContraseña = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.txtUsuarioReestablecerContraseña = new System.Windows.Forms.TextBox();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.pctLogoCrearContraseña = new System.Windows.Forms.PictureBox();
            this.btnContraseñaReestablecida = new System.Windows.Forms.Button();
            this.btnVolverReestablecerContraseña = new System.Windows.Forms.Button();
            this.txtRepitaNuevaContraseña = new System.Windows.Forms.TextBox();
            this.lblRepitaNuevaContraseña = new System.Windows.Forms.Label();
            this.pctMostrarContraseñaReestablecerContraseña = new System.Windows.Forms.PictureBox();
            this.pctOcultarContraseñaReestablecerContraseña = new System.Windows.Forms.PictureBox();
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña = new System.Windows.Forms.PictureBox();
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoCrearContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrarContraseñaReestablecerContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOcultarContraseñaReestablecerContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarioReestablecerContraseña
            // 
            this.lblUsuarioReestablecerContraseña.AutoSize = true;
            this.lblUsuarioReestablecerContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioReestablecerContraseña.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioReestablecerContraseña.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioReestablecerContraseña.Location = new System.Drawing.Point(12, 24);
            this.lblUsuarioReestablecerContraseña.Name = "lblUsuarioReestablecerContraseña";
            this.lblUsuarioReestablecerContraseña.Size = new System.Drawing.Size(76, 19);
            this.lblUsuarioReestablecerContraseña.TabIndex = 0;
            this.lblUsuarioReestablecerContraseña.Text = "Usuario:";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaContraseña.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(12, 61);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(157, 19);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Nueva contraseña:";
            // 
            // txtUsuarioReestablecerContraseña
            // 
            this.txtUsuarioReestablecerContraseña.Enabled = false;
            this.txtUsuarioReestablecerContraseña.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioReestablecerContraseña.Location = new System.Drawing.Point(223, 18);
            this.txtUsuarioReestablecerContraseña.Name = "txtUsuarioReestablecerContraseña";
            this.txtUsuarioReestablecerContraseña.ReadOnly = true;
            this.txtUsuarioReestablecerContraseña.Size = new System.Drawing.Size(150, 25);
            this.txtUsuarioReestablecerContraseña.TabIndex = 2;
            this.txtUsuarioReestablecerContraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraseña.Location = new System.Drawing.Point(223, 55);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(150, 25);
            this.txtNuevaContraseña.TabIndex = 3;
            this.txtNuevaContraseña.TextChanged += new System.EventHandler(this.txtNuevaContraseña_TextChanged);
            // 
            // pctLogoCrearContraseña
            // 
            this.pctLogoCrearContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.pctLogoCrearContraseña.Image = global::pryEliasIE.Properties.Resources.LogoSistemaDeSeguros;
            this.pctLogoCrearContraseña.Location = new System.Drawing.Point(418, 12);
            this.pctLogoCrearContraseña.Name = "pctLogoCrearContraseña";
            this.pctLogoCrearContraseña.Size = new System.Drawing.Size(190, 189);
            this.pctLogoCrearContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctLogoCrearContraseña.TabIndex = 4;
            this.pctLogoCrearContraseña.TabStop = false;
            // 
            // btnContraseñaReestablecida
            // 
            this.btnContraseñaReestablecida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContraseñaReestablecida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContraseñaReestablecida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContraseñaReestablecida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContraseñaReestablecida.Location = new System.Drawing.Point(16, 145);
            this.btnContraseñaReestablecida.Name = "btnContraseñaReestablecida";
            this.btnContraseñaReestablecida.Size = new System.Drawing.Size(357, 42);
            this.btnContraseñaReestablecida.TabIndex = 5;
            this.btnContraseñaReestablecida.Text = "Reestablecer contraseña";
            this.btnContraseñaReestablecida.UseVisualStyleBackColor = false;
            this.btnContraseñaReestablecida.Click += new System.EventHandler(this.btnContraseñaReestablecida_Click);
            // 
            // btnVolverReestablecerContraseña
            // 
            this.btnVolverReestablecerContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverReestablecerContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverReestablecerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverReestablecerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverReestablecerContraseña.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverReestablecerContraseña.Location = new System.Drawing.Point(12, 233);
            this.btnVolverReestablecerContraseña.Name = "btnVolverReestablecerContraseña";
            this.btnVolverReestablecerContraseña.Size = new System.Drawing.Size(105, 50);
            this.btnVolverReestablecerContraseña.TabIndex = 6;
            this.btnVolverReestablecerContraseña.Text = "Volver";
            this.btnVolverReestablecerContraseña.UseVisualStyleBackColor = false;
            this.btnVolverReestablecerContraseña.Click += new System.EventHandler(this.btnVolverReestablecerContraseña_Click);
            // 
            // txtRepitaNuevaContraseña
            // 
            this.txtRepitaNuevaContraseña.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepitaNuevaContraseña.Location = new System.Drawing.Point(223, 92);
            this.txtRepitaNuevaContraseña.Name = "txtRepitaNuevaContraseña";
            this.txtRepitaNuevaContraseña.PasswordChar = '*';
            this.txtRepitaNuevaContraseña.Size = new System.Drawing.Size(150, 25);
            this.txtRepitaNuevaContraseña.TabIndex = 8;
            this.txtRepitaNuevaContraseña.TextChanged += new System.EventHandler(this.txtRepitaNuevaContraseña_TextChanged);
            // 
            // lblRepitaNuevaContraseña
            // 
            this.lblRepitaNuevaContraseña.AutoSize = true;
            this.lblRepitaNuevaContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblRepitaNuevaContraseña.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepitaNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.lblRepitaNuevaContraseña.Location = new System.Drawing.Point(12, 98);
            this.lblRepitaNuevaContraseña.Name = "lblRepitaNuevaContraseña";
            this.lblRepitaNuevaContraseña.Size = new System.Drawing.Size(210, 19);
            this.lblRepitaNuevaContraseña.TabIndex = 7;
            this.lblRepitaNuevaContraseña.Text = "Repita nueva contraseña:";
            // 
            // pctMostrarContraseñaReestablecerContraseña
            // 
            this.pctMostrarContraseñaReestablecerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMostrarContraseñaReestablecerContraseña.Image = global::pryEliasIE.Properties.Resources.foto_mostrar_contraseña;
            this.pctMostrarContraseñaReestablecerContraseña.Location = new System.Drawing.Point(379, 59);
            this.pctMostrarContraseñaReestablecerContraseña.Name = "pctMostrarContraseñaReestablecerContraseña";
            this.pctMostrarContraseñaReestablecerContraseña.Size = new System.Drawing.Size(25, 21);
            this.pctMostrarContraseñaReestablecerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMostrarContraseñaReestablecerContraseña.TabIndex = 18;
            this.pctMostrarContraseñaReestablecerContraseña.TabStop = false;
            this.pctMostrarContraseñaReestablecerContraseña.Click += new System.EventHandler(this.pctMostrarContraseñaReestablecerContraseña_Click);
            // 
            // pctOcultarContraseñaReestablecerContraseña
            // 
            this.pctOcultarContraseñaReestablecerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctOcultarContraseñaReestablecerContraseña.Image = global::pryEliasIE.Properties.Resources.foto_ocultar_contraseña;
            this.pctOcultarContraseñaReestablecerContraseña.Location = new System.Drawing.Point(379, 59);
            this.pctOcultarContraseñaReestablecerContraseña.Name = "pctOcultarContraseñaReestablecerContraseña";
            this.pctOcultarContraseñaReestablecerContraseña.Size = new System.Drawing.Size(25, 21);
            this.pctOcultarContraseñaReestablecerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOcultarContraseñaReestablecerContraseña.TabIndex = 19;
            this.pctOcultarContraseñaReestablecerContraseña.TabStop = false;
            this.pctOcultarContraseñaReestablecerContraseña.Click += new System.EventHandler(this.pctOcultarContraseñaReestablecerContraseña_Click);
            // 
            // pctMostrarRepitaNuevaContraseñaReestablecerContraseña
            // 
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.Image = global::pryEliasIE.Properties.Resources.foto_mostrar_contraseña;
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.Location = new System.Drawing.Point(379, 96);
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.Name = "pctMostrarRepitaNuevaContraseñaReestablecerContraseña";
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.Size = new System.Drawing.Size(25, 21);
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.TabIndex = 20;
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.TabStop = false;
            this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña.Click += new System.EventHandler(this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña_Click);
            // 
            // pctOcultarRepitaNuevaContraseñaReestablecerContraseña
            // 
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.Image = global::pryEliasIE.Properties.Resources.foto_ocultar_contraseña;
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.Location = new System.Drawing.Point(379, 96);
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.Name = "pctOcultarRepitaNuevaContraseñaReestablecerContraseña";
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.Size = new System.Drawing.Size(25, 21);
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.TabIndex = 21;
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.TabStop = false;
            this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña.Click += new System.EventHandler(this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña_Click);
            // 
            // frmReestablecerContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::pryEliasIE.Properties.Resources.fondo_de_ventanas_mejor_calidad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 301);
            this.Controls.Add(this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña);
            this.Controls.Add(this.pctMostrarContraseñaReestablecerContraseña);
            this.Controls.Add(this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña);
            this.Controls.Add(this.pctOcultarContraseñaReestablecerContraseña);
            this.Controls.Add(this.txtRepitaNuevaContraseña);
            this.Controls.Add(this.lblRepitaNuevaContraseña);
            this.Controls.Add(this.btnVolverReestablecerContraseña);
            this.Controls.Add(this.btnContraseñaReestablecida);
            this.Controls.Add(this.pctLogoCrearContraseña);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.txtUsuarioReestablecerContraseña);
            this.Controls.Add(this.lblNuevaContraseña);
            this.Controls.Add(this.lblUsuarioReestablecerContraseña);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmReestablecerContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNE Venta de seguros";
            this.Load += new System.EventHandler(this.frmReestablecerContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoCrearContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrarContraseñaReestablecerContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOcultarContraseñaReestablecerContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrarRepitaNuevaContraseñaReestablecerContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctOcultarRepitaNuevaContraseñaReestablecerContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioReestablecerContraseña;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.PictureBox pctLogoCrearContraseña;
        private System.Windows.Forms.Button btnContraseñaReestablecida;
        private System.Windows.Forms.Button btnVolverReestablecerContraseña;
        private System.Windows.Forms.TextBox txtRepitaNuevaContraseña;
        private System.Windows.Forms.Label lblRepitaNuevaContraseña;
        public System.Windows.Forms.TextBox txtUsuarioReestablecerContraseña;
        private System.Windows.Forms.PictureBox pctMostrarContraseñaReestablecerContraseña;
        private System.Windows.Forms.PictureBox pctOcultarContraseñaReestablecerContraseña;
        private System.Windows.Forms.PictureBox pctMostrarRepitaNuevaContraseñaReestablecerContraseña;
        private System.Windows.Forms.PictureBox pctOcultarRepitaNuevaContraseñaReestablecerContraseña;
    }
}