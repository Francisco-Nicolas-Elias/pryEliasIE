namespace pryEliasIE
{
    partial class frmElClub
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
            this.dtvDatosElClub = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblBuscarClientePorID = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBuscarClientePorApellido = new System.Windows.Forms.Label();
            this.txtBuscarClientePorApellido = new System.Windows.Forms.TextBox();
            this.btnBuscarClientePorApellido = new System.Windows.Forms.Button();
            this.btnVolverElClub = new System.Windows.Forms.Button();
            this.lblCambiarEstadoActivo = new System.Windows.Forms.Label();
            this.txtCambiarEstadoActivo = new System.Windows.Forms.TextBox();
            this.btnCambiarEstadoActivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatosElClub)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvDatosElClub
            // 
            this.dtvDatosElClub.AllowUserToAddRows = false;
            this.dtvDatosElClub.AllowUserToDeleteRows = false;
            this.dtvDatosElClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatosElClub.Location = new System.Drawing.Point(12, 12);
            this.dtvDatosElClub.Name = "dtvDatosElClub";
            this.dtvDatosElClub.ReadOnly = true;
            this.dtvDatosElClub.Size = new System.Drawing.Size(882, 198);
            this.dtvDatosElClub.TabIndex = 1;
            this.dtvDatosElClub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDatosElClub_CellContentClick);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(12, 267);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(50, 26);
            this.txtBuscarCliente.TabIndex = 2;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(11, 303);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(100, 35);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblBuscarClientePorID
            // 
            this.lblBuscarClientePorID.AutoSize = true;
            this.lblBuscarClientePorID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClientePorID.Location = new System.Drawing.Point(7, 238);
            this.lblBuscarClientePorID.Name = "lblBuscarClientePorID";
            this.lblBuscarClientePorID.Size = new System.Drawing.Size(197, 19);
            this.lblBuscarClientePorID.TabIndex = 4;
            this.lblBuscarClientePorID.Text = "Buscar cliente por su ID:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1051, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(27, 17);
            this.lblEstadoConexion.Text = "----";
            // 
            // lblBuscarClientePorApellido
            // 
            this.lblBuscarClientePorApellido.AutoSize = true;
            this.lblBuscarClientePorApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClientePorApellido.Location = new System.Drawing.Point(296, 238);
            this.lblBuscarClientePorApellido.Name = "lblBuscarClientePorApellido";
            this.lblBuscarClientePorApellido.Size = new System.Drawing.Size(242, 19);
            this.lblBuscarClientePorApellido.TabIndex = 6;
            this.lblBuscarClientePorApellido.Text = "Buscar cliente por su Apellido:";
            // 
            // txtBuscarClientePorApellido
            // 
            this.txtBuscarClientePorApellido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClientePorApellido.Location = new System.Drawing.Point(300, 267);
            this.txtBuscarClientePorApellido.Name = "txtBuscarClientePorApellido";
            this.txtBuscarClientePorApellido.Size = new System.Drawing.Size(143, 26);
            this.txtBuscarClientePorApellido.TabIndex = 7;
            this.txtBuscarClientePorApellido.TextChanged += new System.EventHandler(this.txtBuscarClientePorApellido_TextChanged);
            // 
            // btnBuscarClientePorApellido
            // 
            this.btnBuscarClientePorApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarClientePorApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClientePorApellido.Location = new System.Drawing.Point(300, 299);
            this.btnBuscarClientePorApellido.Name = "btnBuscarClientePorApellido";
            this.btnBuscarClientePorApellido.Size = new System.Drawing.Size(100, 35);
            this.btnBuscarClientePorApellido.TabIndex = 8;
            this.btnBuscarClientePorApellido.Text = "Buscar";
            this.btnBuscarClientePorApellido.UseVisualStyleBackColor = true;
            this.btnBuscarClientePorApellido.Click += new System.EventHandler(this.btnBuscarClientePorApellido_Click);
            // 
            // btnVolverElClub
            // 
            this.btnVolverElClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverElClub.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverElClub.Location = new System.Drawing.Point(11, 373);
            this.btnVolverElClub.Name = "btnVolverElClub";
            this.btnVolverElClub.Size = new System.Drawing.Size(99, 45);
            this.btnVolverElClub.TabIndex = 9;
            this.btnVolverElClub.Text = "Volver";
            this.btnVolverElClub.UseVisualStyleBackColor = true;
            this.btnVolverElClub.Click += new System.EventHandler(this.btnVolverElClub_Click);
            // 
            // lblCambiarEstadoActivo
            // 
            this.lblCambiarEstadoActivo.AutoSize = true;
            this.lblCambiarEstadoActivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarEstadoActivo.Location = new System.Drawing.Point(576, 238);
            this.lblCambiarEstadoActivo.Name = "lblCambiarEstadoActivo";
            this.lblCambiarEstadoActivo.Size = new System.Drawing.Size(452, 19);
            this.lblCambiarEstadoActivo.TabIndex = 10;
            this.lblCambiarEstadoActivo.Text = "Ingresar ID del cliente que quiere cambiar el estado activo:";
            // 
            // txtCambiarEstadoActivo
            // 
            this.txtCambiarEstadoActivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambiarEstadoActivo.Location = new System.Drawing.Point(580, 267);
            this.txtCambiarEstadoActivo.Name = "txtCambiarEstadoActivo";
            this.txtCambiarEstadoActivo.Size = new System.Drawing.Size(143, 26);
            this.txtCambiarEstadoActivo.TabIndex = 11;
            this.txtCambiarEstadoActivo.TextChanged += new System.EventHandler(this.txtCambiarEstadoActivo_TextChanged);
            // 
            // btnCambiarEstadoActivo
            // 
            this.btnCambiarEstadoActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstadoActivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoActivo.Location = new System.Drawing.Point(580, 299);
            this.btnCambiarEstadoActivo.Name = "btnCambiarEstadoActivo";
            this.btnCambiarEstadoActivo.Size = new System.Drawing.Size(100, 35);
            this.btnCambiarEstadoActivo.TabIndex = 12;
            this.btnCambiarEstadoActivo.Text = "Cambiar";
            this.btnCambiarEstadoActivo.UseVisualStyleBackColor = true;
            this.btnCambiarEstadoActivo.Click += new System.EventHandler(this.btnCambiarEstadoActivo_Click);
            // 
            // frmElClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 460);
            this.Controls.Add(this.btnCambiarEstadoActivo);
            this.Controls.Add(this.txtCambiarEstadoActivo);
            this.Controls.Add(this.lblCambiarEstadoActivo);
            this.Controls.Add(this.btnVolverElClub);
            this.Controls.Add(this.btnBuscarClientePorApellido);
            this.Controls.Add(this.txtBuscarClientePorApellido);
            this.Controls.Add(this.lblBuscarClientePorApellido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblBuscarClientePorID);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dtvDatosElClub);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmElClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL CLUB ♥";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmElClub_FormClosed);
            this.Load += new System.EventHandler(this.frmElClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatosElClub)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtvDatosElClub;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscarClientePorID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.Label lblBuscarClientePorApellido;
        private System.Windows.Forms.TextBox txtBuscarClientePorApellido;
        private System.Windows.Forms.Button btnVolverElClub;
        public System.Windows.Forms.Button btnBuscarCliente;
        public System.Windows.Forms.Button btnBuscarClientePorApellido;
        private System.Windows.Forms.Label lblCambiarEstadoActivo;
        private System.Windows.Forms.TextBox txtCambiarEstadoActivo;
        private System.Windows.Forms.Button btnCambiarEstadoActivo;
    }
}