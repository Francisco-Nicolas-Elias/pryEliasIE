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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnVolverVentanaPrincipal = new System.Windows.Forms.Button();
            this.trvMostrar = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstMostrar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnVolverVentanaPrincipal);
            this.splitContainer1.Panel1.Controls.Add(this.trvMostrar);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstMostrar);
            this.splitContainer1.Size = new System.Drawing.Size(1221, 662);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnVolverVentanaPrincipal
            // 
            this.btnVolverVentanaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverVentanaPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolverVentanaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverVentanaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverVentanaPrincipal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverVentanaPrincipal.Location = new System.Drawing.Point(13, 595);
            this.btnVolverVentanaPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVolverVentanaPrincipal.Name = "btnVolverVentanaPrincipal";
            this.btnVolverVentanaPrincipal.Size = new System.Drawing.Size(151, 55);
            this.btnVolverVentanaPrincipal.TabIndex = 1;
            this.btnVolverVentanaPrincipal.Text = "Volver";
            this.btnVolverVentanaPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverVentanaPrincipal.Click += new System.EventHandler(this.btnVolverVentanaPrincipal_Click);
            // 
            // trvMostrar
            // 
            this.trvMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMostrar.ImageIndex = 0;
            this.trvMostrar.ImageList = this.imageList1;
            this.trvMostrar.Location = new System.Drawing.Point(0, 0);
            this.trvMostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trvMostrar.Name = "trvMostrar";
            this.trvMostrar.SelectedImageIndex = 0;
            this.trvMostrar.Size = new System.Drawing.Size(407, 662);
            this.trvMostrar.TabIndex = 0;
            this.trvMostrar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carpeta.png");
            this.imageList1.Images.SetKeyName(1, "documento.png");
            // 
            // lstMostrar
            // 
            this.lstMostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMostrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMostrar.HideSelection = false;
            this.lstMostrar.Location = new System.Drawing.Point(0, 0);
            this.lstMostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(810, 662);
            this.lstMostrar.SmallImageList = this.imageList1;
            this.lstMostrar.TabIndex = 0;
            this.lstMostrar.UseCompatibleStateImageBehavior = false;
            this.lstMostrar.View = System.Windows.Forms.View.Details;
            this.lstMostrar.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lstMostrar.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Última modificación";
            this.columnHeader3.Width = 210;
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::pryEliasIE.Properties.Resources.fondo_de_ventanas_mejor_calidad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 662);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNE Venta de seguros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVentanaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView trvMostrar;
        private System.Windows.Forms.ListView lstMostrar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnVolverVentanaPrincipal;
    }
}