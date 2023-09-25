namespace pryEliasIE
{
    partial class frmABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABM));
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnVolverABM = new System.Windows.Forms.Button();
            this.gbDatosProveedores = new System.Windows.Forms.GroupBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.lblApertura = new System.Windows.Forms.Label();
            this.txtLiquidadorResponsable = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtJuzgado = new System.Windows.Forms.TextBox();
            this.txtNumeroDeExpediente = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLiquidadorResponsable = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.lblNumeroDeExpediente = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbDatosProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(493, 391);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(117, 59);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolverABM
            // 
            this.btnVolverABM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverABM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverABM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverABM.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverABM.Location = new System.Drawing.Point(3, 390);
            this.btnVolverABM.Name = "btnVolverABM";
            this.btnVolverABM.Size = new System.Drawing.Size(118, 59);
            this.btnVolverABM.TabIndex = 18;
            this.btnVolverABM.Text = "Volver";
            this.btnVolverABM.UseVisualStyleBackColor = false;
            this.btnVolverABM.Click += new System.EventHandler(this.btnVolverABM_Click);
            // 
            // gbDatosProveedores
            // 
            this.gbDatosProveedores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDatosProveedores.Controls.Add(this.txtApertura);
            this.gbDatosProveedores.Controls.Add(this.lblApertura);
            this.gbDatosProveedores.Controls.Add(this.txtLiquidadorResponsable);
            this.gbDatosProveedores.Controls.Add(this.txtDireccion);
            this.gbDatosProveedores.Controls.Add(this.txtJurisdiccion);
            this.gbDatosProveedores.Controls.Add(this.txtJuzgado);
            this.gbDatosProveedores.Controls.Add(this.txtNumeroDeExpediente);
            this.gbDatosProveedores.Controls.Add(this.txtEntidad);
            this.gbDatosProveedores.Controls.Add(this.txtNumero);
            this.gbDatosProveedores.Controls.Add(this.lblLiquidadorResponsable);
            this.gbDatosProveedores.Controls.Add(this.lblDireccion);
            this.gbDatosProveedores.Controls.Add(this.lblJurisdiccion);
            this.gbDatosProveedores.Controls.Add(this.lblJuzgado);
            this.gbDatosProveedores.Controls.Add(this.lblNumeroDeExpediente);
            this.gbDatosProveedores.Controls.Add(this.lblEntidad);
            this.gbDatosProveedores.Controls.Add(this.lblNumero);
            this.gbDatosProveedores.Location = new System.Drawing.Point(3, 22);
            this.gbDatosProveedores.Name = "gbDatosProveedores";
            this.gbDatosProveedores.Size = new System.Drawing.Size(607, 358);
            this.gbDatosProveedores.TabIndex = 21;
            this.gbDatosProveedores.TabStop = false;
            // 
            // txtApertura
            // 
            this.txtApertura.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApertura.Location = new System.Drawing.Point(295, 92);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(100, 32);
            this.txtApertura.TabIndex = 36;
            this.txtApertura.TextChanged += new System.EventHandler(this.txtApertura_TextChanged);
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblApertura.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.Location = new System.Drawing.Point(10, 100);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(105, 24);
            this.lblApertura.TabIndex = 35;
            this.lblApertura.Text = "Apertura:";
            // 
            // txtLiquidadorResponsable
            // 
            this.txtLiquidadorResponsable.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquidadorResponsable.Location = new System.Drawing.Point(295, 297);
            this.txtLiquidadorResponsable.Name = "txtLiquidadorResponsable";
            this.txtLiquidadorResponsable.Size = new System.Drawing.Size(279, 32);
            this.txtLiquidadorResponsable.TabIndex = 34;
            this.txtLiquidadorResponsable.TextChanged += new System.EventHandler(this.txtLiquidadorResponsable_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(295, 256);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(279, 32);
            this.txtDireccion.TabIndex = 33;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJurisdiccion.Location = new System.Drawing.Point(295, 215);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(279, 32);
            this.txtJurisdiccion.TabIndex = 32;
            this.txtJurisdiccion.TextChanged += new System.EventHandler(this.txtJurisdiccion_TextChanged);
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuzgado.Location = new System.Drawing.Point(295, 174);
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.Size = new System.Drawing.Size(279, 32);
            this.txtJuzgado.TabIndex = 31;
            this.txtJuzgado.TextChanged += new System.EventHandler(this.txtJuzgado_TextChanged);
            // 
            // txtNumeroDeExpediente
            // 
            this.txtNumeroDeExpediente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDeExpediente.Location = new System.Drawing.Point(295, 133);
            this.txtNumeroDeExpediente.Name = "txtNumeroDeExpediente";
            this.txtNumeroDeExpediente.Size = new System.Drawing.Size(129, 32);
            this.txtNumeroDeExpediente.TabIndex = 30;
            this.txtNumeroDeExpediente.TextChanged += new System.EventHandler(this.txtNumeroDeExpediente_TextChanged);
            // 
            // txtEntidad
            // 
            this.txtEntidad.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.Location = new System.Drawing.Point(295, 51);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(279, 32);
            this.txtEntidad.TabIndex = 29;
            this.txtEntidad.TextChanged += new System.EventHandler(this.txtEntidad_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(295, 10);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(59, 32);
            this.txtNumero.TabIndex = 28;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // lblLiquidadorResponsable
            // 
            this.lblLiquidadorResponsable.AutoSize = true;
            this.lblLiquidadorResponsable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLiquidadorResponsable.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquidadorResponsable.Location = new System.Drawing.Point(10, 305);
            this.lblLiquidadorResponsable.Name = "lblLiquidadorResponsable";
            this.lblLiquidadorResponsable.Size = new System.Drawing.Size(256, 24);
            this.lblLiquidadorResponsable.TabIndex = 27;
            this.lblLiquidadorResponsable.Text = "Liquidador responsable:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(10, 264);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(112, 24);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblJurisdiccion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurisdiccion.Location = new System.Drawing.Point(10, 223);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(140, 24);
            this.lblJurisdiccion.TabIndex = 25;
            this.lblJurisdiccion.Text = "Jurisdicción:";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblJuzgado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuzgado.Location = new System.Drawing.Point(10, 182);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(104, 24);
            this.lblJuzgado.TabIndex = 24;
            this.lblJuzgado.Text = "Juzgado:";
            // 
            // lblNumeroDeExpediente
            // 
            this.lblNumeroDeExpediente.AutoSize = true;
            this.lblNumeroDeExpediente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumeroDeExpediente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeExpediente.Location = new System.Drawing.Point(10, 141);
            this.lblNumeroDeExpediente.Name = "lblNumeroDeExpediente";
            this.lblNumeroDeExpediente.Size = new System.Drawing.Size(187, 24);
            this.lblNumeroDeExpediente.TabIndex = 23;
            this.lblNumeroDeExpediente.Text = "Nº de expediente:";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEntidad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(10, 59);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(94, 24);
            this.lblEntidad.TabIndex = 22;
            this.lblEntidad.Text = "Entidad:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(10, 18);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(39, 24);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Nº:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(432, 391);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 59);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // frmABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEliasIE.Properties.Resources.fondo_de_ventanas_mejor_calidad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 460);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.gbDatosProveedores);
            this.Controls.Add(this.btnVolverABM);
            this.Controls.Add(this.btnGrabar);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNE Venta de seguros ";
            this.Load += new System.EventHandler(this.frmABM_Load);
            this.gbDatosProveedores.ResumeLayout(false);
            this.gbDatosProveedores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolverABM;
        private System.Windows.Forms.GroupBox gbDatosProveedores;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblLiquidadorResponsable;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.Label lblNumeroDeExpediente;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtApertura;
        public System.Windows.Forms.TextBox txtLiquidadorResponsable;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtJurisdiccion;
        public System.Windows.Forms.TextBox txtJuzgado;
        public System.Windows.Forms.TextBox txtNumeroDeExpediente;
        public System.Windows.Forms.TextBox txtEntidad;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.Button btnGrabar;
        public System.Windows.Forms.Button btnModificar;
    }
}