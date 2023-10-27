namespace pryEliasIE
{
    partial class frmVentanaGrilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaGrilla));
            this.dtvMostrarArchivo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolverVentanaGrilla = new System.Windows.Forms.Button();
            this.lblExplicacionBorrar = new System.Windows.Forms.Label();
            this.btnBorrarGrilla = new System.Windows.Forms.Button();
            this.btnModificarGrilla = new System.Windows.Forms.Button();
            this.btnGrabarGrilla = new System.Windows.Forms.Button();
            this.lblExplicacionModificar = new System.Windows.Forms.Label();
            this.lblExplicacionGrabar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvMostrarArchivo
            // 
            this.dtvMostrarArchivo.AllowUserToAddRows = false;
            this.dtvMostrarArchivo.AllowUserToDeleteRows = false;
            this.dtvMostrarArchivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMostrarArchivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtvMostrarArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtvMostrarArchivo.Location = new System.Drawing.Point(0, 0);
            this.dtvMostrarArchivo.Name = "dtvMostrarArchivo";
            this.dtvMostrarArchivo.ReadOnly = true;
            this.dtvMostrarArchivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvMostrarArchivo.Size = new System.Drawing.Size(1284, 761);
            this.dtvMostrarArchivo.TabIndex = 0;
            this.dtvMostrarArchivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvMostrarArchivo_CellContentClick);
            this.dtvMostrarArchivo.DoubleClick += new System.EventHandler(this.dtvMostrarArchivo_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Entidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 97;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Apertura";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Nº de expediente";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "Juzgado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 290;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.HeaderText = "Jurisdicción";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 160;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.HeaderText = "Dirección";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 260;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Liquidador responsable";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 204;
            // 
            // btnVolverVentanaGrilla
            // 
            this.btnVolverVentanaGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverVentanaGrilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverVentanaGrilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverVentanaGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverVentanaGrilla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverVentanaGrilla.Location = new System.Drawing.Point(12, 944);
            this.btnVolverVentanaGrilla.Name = "btnVolverVentanaGrilla";
            this.btnVolverVentanaGrilla.Size = new System.Drawing.Size(131, 56);
            this.btnVolverVentanaGrilla.TabIndex = 1;
            this.btnVolverVentanaGrilla.Text = "Volver";
            this.btnVolverVentanaGrilla.UseVisualStyleBackColor = false;
            this.btnVolverVentanaGrilla.Click += new System.EventHandler(this.btnVolverVentanaGrilla_Click);
            // 
            // lblExplicacionBorrar
            // 
            this.lblExplicacionBorrar.AutoSize = true;
            this.lblExplicacionBorrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacionBorrar.Location = new System.Drawing.Point(-4, 787);
            this.lblExplicacionBorrar.Name = "lblExplicacionBorrar";
            this.lblExplicacionBorrar.Size = new System.Drawing.Size(800, 22);
            this.lblExplicacionBorrar.TabIndex = 2;
            this.lblExplicacionBorrar.Text = "Si quiere \"Borrar\" un registro debe hacer click sobre él y presionar el botón \"Bo" +
    "rrar\".";
            // 
            // btnBorrarGrilla
            // 
            this.btnBorrarGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarGrilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrarGrilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarGrilla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarGrilla.Location = new System.Drawing.Point(1144, 941);
            this.btnBorrarGrilla.Name = "btnBorrarGrilla";
            this.btnBorrarGrilla.Size = new System.Drawing.Size(118, 59);
            this.btnBorrarGrilla.TabIndex = 5;
            this.btnBorrarGrilla.Text = "Borrar";
            this.btnBorrarGrilla.UseVisualStyleBackColor = false;
            this.btnBorrarGrilla.Click += new System.EventHandler(this.btnBorrarGrilla_Click);
            // 
            // btnModificarGrilla
            // 
            this.btnModificarGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarGrilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarGrilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarGrilla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarGrilla.Location = new System.Drawing.Point(1021, 941);
            this.btnModificarGrilla.Name = "btnModificarGrilla";
            this.btnModificarGrilla.Size = new System.Drawing.Size(117, 59);
            this.btnModificarGrilla.TabIndex = 4;
            this.btnModificarGrilla.Text = "Modificar";
            this.btnModificarGrilla.UseVisualStyleBackColor = false;
            this.btnModificarGrilla.Click += new System.EventHandler(this.btnModificarGrilla_Click);
            // 
            // btnGrabarGrilla
            // 
            this.btnGrabarGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabarGrilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrabarGrilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabarGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabarGrilla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarGrilla.Location = new System.Drawing.Point(897, 941);
            this.btnGrabarGrilla.Name = "btnGrabarGrilla";
            this.btnGrabarGrilla.Size = new System.Drawing.Size(118, 59);
            this.btnGrabarGrilla.TabIndex = 3;
            this.btnGrabarGrilla.Text = "Grabar";
            this.btnGrabarGrilla.UseVisualStyleBackColor = false;
            this.btnGrabarGrilla.Click += new System.EventHandler(this.btnGrabarGrilla_Click);
            // 
            // lblExplicacionModificar
            // 
            this.lblExplicacionModificar.AutoSize = true;
            this.lblExplicacionModificar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacionModificar.Location = new System.Drawing.Point(-4, 810);
            this.lblExplicacionModificar.Name = "lblExplicacionModificar";
            this.lblExplicacionModificar.Size = new System.Drawing.Size(852, 22);
            this.lblExplicacionModificar.TabIndex = 6;
            this.lblExplicacionModificar.Text = "Si quiere \"Modificar\" un registro debe hacer click sobre él y presionar el botón " +
    "\"Modificar\".";
            // 
            // lblExplicacionGrabar
            // 
            this.lblExplicacionGrabar.AutoSize = true;
            this.lblExplicacionGrabar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacionGrabar.Location = new System.Drawing.Point(-4, 764);
            this.lblExplicacionGrabar.Name = "lblExplicacionGrabar";
            this.lblExplicacionGrabar.Size = new System.Drawing.Size(721, 22);
            this.lblExplicacionGrabar.TabIndex = 7;
            this.lblExplicacionGrabar.Text = "Si quiere \"Grabar\" un registro solo debe hacer click sobre el botón \"Grabar\".";
            // 
            // frmVentanaGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 1005);
            this.Controls.Add(this.lblExplicacionGrabar);
            this.Controls.Add(this.lblExplicacionModificar);
            this.Controls.Add(this.btnBorrarGrilla);
            this.Controls.Add(this.btnModificarGrilla);
            this.Controls.Add(this.btnGrabarGrilla);
            this.Controls.Add(this.lblExplicacionBorrar);
            this.Controls.Add(this.btnVolverVentanaGrilla);
            this.Controls.Add(this.dtvMostrarArchivo);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmVentanaGrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNE Venta de seguros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVentanaGrilla_FormClosed);
            this.Load += new System.EventHandler(this.frmVentanaGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarArchivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtvMostrarArchivo;
        private System.Windows.Forms.Button btnVolverVentanaGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lblExplicacionBorrar;
        private System.Windows.Forms.Button btnBorrarGrilla;
        private System.Windows.Forms.Button btnModificarGrilla;
        private System.Windows.Forms.Button btnGrabarGrilla;
        private System.Windows.Forms.Label lblExplicacionModificar;
        private System.Windows.Forms.Label lblExplicacionGrabar;
    }
}