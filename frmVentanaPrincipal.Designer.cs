namespace pryEliasIE
{
    partial class frmVentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.fbdVentanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.lblDireccionDeArchivo = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnGrabarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCarpeta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(12, 12);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(105, 41);
            this.btnSeleccionarCarpeta.TabIndex = 0;
            this.btnSeleccionarCarpeta.Text = "Seleccionar carpeta";
            this.btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            // 
            // lblDireccionDeArchivo
            // 
            this.lblDireccionDeArchivo.AutoSize = true;
            this.lblDireccionDeArchivo.Location = new System.Drawing.Point(13, 79);
            this.lblDireccionDeArchivo.Name = "lblDireccionDeArchivo";
            this.lblDireccionDeArchivo.Size = new System.Drawing.Size(104, 16);
            this.lblDireccionDeArchivo.TabIndex = 1;
            this.lblDireccionDeArchivo.Text = "Dirección de archivo";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 117);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(185, 189);
            this.treeView1.TabIndex = 2;
            // 
            // btnGrabarArchivo
            // 
            this.btnGrabarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabarArchivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabarArchivo.Location = new System.Drawing.Point(12, 312);
            this.btnGrabarArchivo.Name = "btnGrabarArchivo";
            this.btnGrabarArchivo.Size = new System.Drawing.Size(84, 41);
            this.btnGrabarArchivo.TabIndex = 3;
            this.btnGrabarArchivo.Text = "Grabar Archivo";
            this.btnGrabarArchivo.UseVisualStyleBackColor = true;
            this.btnGrabarArchivo.Click += new System.EventHandler(this.btnGrabarArchivo_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 365);
            this.Controls.Add(this.btnGrabarArchivo);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblDireccionDeArchivo);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentanaPrincipal";
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdVentanaCarpetas;
        private System.Windows.Forms.Button btnSeleccionarCarpeta;
        private System.Windows.Forms.Label lblDireccionDeArchivo;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnGrabarArchivo;
    }
}