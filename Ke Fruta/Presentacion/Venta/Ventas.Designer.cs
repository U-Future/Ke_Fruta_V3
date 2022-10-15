namespace Ke_Fruta.Venta
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.lblRealizarVenta = new System.Windows.Forms.Label();
            this.btnConcretar = new System.Windows.Forms.Button();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataViewCompras = new System.Windows.Forms.DataGridView();
            this.btnVerPendientes = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRealizarVenta
            // 
            this.lblRealizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRealizarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRealizarVenta.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizarVenta.Location = new System.Drawing.Point(0, 0);
            this.lblRealizarVenta.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblRealizarVenta.Name = "lblRealizarVenta";
            this.lblRealizarVenta.Size = new System.Drawing.Size(988, 137);
            this.lblRealizarVenta.TabIndex = 58;
            this.lblRealizarVenta.Text = "Concretar\r\nVenta";
            this.lblRealizarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConcretar
            // 
            this.btnConcretar.Enabled = false;
            this.btnConcretar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcretar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcretar.Location = new System.Drawing.Point(516, 446);
            this.btnConcretar.Name = "btnConcretar";
            this.btnConcretar.Size = new System.Drawing.Size(152, 37);
            this.btnConcretar.TabIndex = 73;
            this.btnConcretar.Text = "CONCRETAR";
            this.btnConcretar.UseVisualStyleBackColor = true;
            this.btnConcretar.Click += new System.EventHandler(this.btnConcretar_Click);
            // 
            // pbxSalir
            // 
            this.pbxSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(948, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(28, 34);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 74;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimizar.Image")));
            this.pbxMinimizar.Location = new System.Drawing.Point(914, 12);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(28, 34);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 75;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(354, 403);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(314, 37);
            this.txtID.TabIndex = 76;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(349, 370);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(161, 30);
            this.lblID.TabIndex = 77;
            this.lblID.Text = "ID COMPRA:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(354, 446);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(152, 37);
            this.btnBuscar.TabIndex = 78;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataViewCompras
            // 
            this.dataViewCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewCompras.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCompras.Location = new System.Drawing.Point(11, 140);
            this.dataViewCompras.Name = "dataViewCompras";
            this.dataViewCompras.RowHeadersWidth = 62;
            this.dataViewCompras.RowTemplate.Height = 28;
            this.dataViewCompras.Size = new System.Drawing.Size(965, 218);
            this.dataViewCompras.TabIndex = 79;
            // 
            // btnVerPendientes
            // 
            this.btnVerPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPendientes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPendientes.Location = new System.Drawing.Point(354, 489);
            this.btnVerPendientes.Name = "btnVerPendientes";
            this.btnVerPendientes.Size = new System.Drawing.Size(314, 37);
            this.btnVerPendientes.TabIndex = 80;
            this.btnVerPendientes.Text = "VER PENDIENTES";
            this.btnVerPendientes.UseVisualStyleBackColor = true;
            this.btnVerPendientes.Click += new System.EventHandler(this.btnVerPendientes_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(354, 532);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(314, 37);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(988, 583);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVerPendientes);
            this.Controls.Add(this.dataViewCompras);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.btnConcretar);
            this.Controls.Add(this.lblRealizarVenta);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRealizarVenta;
        private System.Windows.Forms.Button btnConcretar;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataViewCompras;
        private System.Windows.Forms.Button btnVerPendientes;
        private System.Windows.Forms.Button btnCancelar;
    }
}