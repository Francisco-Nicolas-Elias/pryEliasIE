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
            this.btnMostrarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvMostrarArchivo
            // 
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
            this.dtvMostrarArchivo.Location = new System.Drawing.Point(12, 12);
            this.dtvMostrarArchivo.Name = "dtvMostrarArchivo";
            this.dtvMostrarArchivo.Size = new System.Drawing.Size(942, 517);
            this.dtvMostrarArchivo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Entidad";
            this.Column2.Name = "Column2";
            this.Column2.Width = 97;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Apertura";
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Nº de expediente";
            this.Column4.Name = "Column4";
            this.Column4.Width = 157;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Juzgado";
            this.Column5.Name = "Column5";
            this.Column5.Width = 105;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Jurisdicción";
            this.Column6.Name = "Column6";
            this.Column6.Width = 131;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "Dirección";
            this.Column7.Name = "Column7";
            this.Column7.Width = 111;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.HeaderText = "Liquidador responsable";
            this.Column8.Name = "Column8";
            this.Column8.Width = 204;
            // 
            // btnVolverVentanaGrilla
            // 
            this.btnVolverVentanaGrilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverVentanaGrilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverVentanaGrilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverVentanaGrilla.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverVentanaGrilla.Location = new System.Drawing.Point(12, 596);
            this.btnVolverVentanaGrilla.Name = "btnVolverVentanaGrilla";
            this.btnVolverVentanaGrilla.Size = new System.Drawing.Size(131, 56);
            this.btnVolverVentanaGrilla.TabIndex = 1;
            this.btnVolverVentanaGrilla.Text = "Volver";
            this.btnVolverVentanaGrilla.UseVisualStyleBackColor = false;
            this.btnVolverVentanaGrilla.Click += new System.EventHandler(this.btnVolverVentanaGrilla_Click);
            // 
            // btnMostrarGrilla
            // 
            this.btnMostrarGrilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMostrarGrilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarGrilla.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarGrilla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarGrilla.Location = new System.Drawing.Point(960, 464);
            this.btnMostrarGrilla.Name = "btnMostrarGrilla";
            this.btnMostrarGrilla.Size = new System.Drawing.Size(132, 56);
            this.btnMostrarGrilla.TabIndex = 2;
            this.btnMostrarGrilla.Text = "Mostrar";
            this.btnMostrarGrilla.UseVisualStyleBackColor = false;
            this.btnMostrarGrilla.Click += new System.EventHandler(this.btnMostrarGrilla_Click);
            // 
            // frmVentanaGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 664);
            this.Controls.Add(this.btnMostrarGrilla);
            this.Controls.Add(this.btnVolverVentanaGrilla);
            this.Controls.Add(this.dtvMostrarArchivo);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmVentanaGrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNE Venta de seguros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarArchivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvMostrarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnVolverVentanaGrilla;
        private System.Windows.Forms.Button btnMostrarGrilla;
    }
}