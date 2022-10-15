namespace Ke_Fruta.Gestion
{
    partial class ConSiembra_Cosecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConSiembra_Cosecha));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gpbxOpcion = new System.Windows.Forms.GroupBox();
            this.rdbtnSector = new System.Windows.Forms.RadioButton();
            this.rdbtnUsuario = new System.Windows.Forms.RadioButton();
            this.lblConSieCos = new System.Windows.Forms.Label();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.dataViewConSieCos = new System.Windows.Forms.DataGridView();
            this.gpbxOpcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewConSieCos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(344, 331);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 38);
            this.btnConsultar.TabIndex = 55;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.Location = new System.Drawing.Point(264, 255);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(106, 30);
            this.lblConsultar.TabIndex = 54;
            this.lblConsultar.Text = "Ingrese:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(269, 288);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(281, 37);
            this.txtBuscar.TabIndex = 53;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // gpbxOpcion
            // 
            this.gpbxOpcion.Controls.Add(this.rdbtnSector);
            this.gpbxOpcion.Controls.Add(this.rdbtnUsuario);
            this.gpbxOpcion.Location = new System.Drawing.Point(233, 168);
            this.gpbxOpcion.Name = "gpbxOpcion";
            this.gpbxOpcion.Size = new System.Drawing.Size(383, 84);
            this.gpbxOpcion.TabIndex = 52;
            this.gpbxOpcion.TabStop = false;
            this.gpbxOpcion.Text = "Seleccione:";
            // 
            // rdbtnSector
            // 
            this.rdbtnSector.AutoSize = true;
            this.rdbtnSector.Checked = true;
            this.rdbtnSector.Location = new System.Drawing.Point(36, 36);
            this.rdbtnSector.Name = "rdbtnSector";
            this.rdbtnSector.Size = new System.Drawing.Size(144, 34);
            this.rdbtnSector.TabIndex = 9;
            this.rdbtnSector.TabStop = true;
            this.rdbtnSector.Text = "ID Sector";
            this.rdbtnSector.UseVisualStyleBackColor = true;
            // 
            // rdbtnUsuario
            // 
            this.rdbtnUsuario.AutoSize = true;
            this.rdbtnUsuario.Location = new System.Drawing.Point(213, 36);
            this.rdbtnUsuario.Name = "rdbtnUsuario";
            this.rdbtnUsuario.Size = new System.Drawing.Size(155, 34);
            this.rdbtnUsuario.TabIndex = 7;
            this.rdbtnUsuario.Text = "ID Usuario";
            this.rdbtnUsuario.UseVisualStyleBackColor = true;
            // 
            // lblConSieCos
            // 
            this.lblConSieCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblConSieCos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConSieCos.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSieCos.Location = new System.Drawing.Point(0, 0);
            this.lblConSieCos.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblConSieCos.Name = "lblConSieCos";
            this.lblConSieCos.Size = new System.Drawing.Size(831, 137);
            this.lblConSieCos.TabIndex = 57;
            this.lblConSieCos.Text = "Consulta\r\nSiembra Cosecha";
            this.lblConSieCos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSalir
            // 
            this.pbxSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(791, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(28, 34);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 75;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimizar.Image")));
            this.pbxMinimizar.Location = new System.Drawing.Point(757, 12);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(28, 34);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 76;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // dataViewConSieCos
            // 
            this.dataViewConSieCos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewConSieCos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataViewConSieCos.ColumnHeadersHeight = 34;
            this.dataViewConSieCos.Location = new System.Drawing.Point(11, 378);
            this.dataViewConSieCos.Name = "dataViewConSieCos";
            this.dataViewConSieCos.RowHeadersWidth = 62;
            this.dataViewConSieCos.RowTemplate.Height = 28;
            this.dataViewConSieCos.Size = new System.Drawing.Size(808, 150);
            this.dataViewConSieCos.TabIndex = 77;
            // 
            // ConSiembra_Cosecha
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(831, 540);
            this.Controls.Add(this.dataViewConSieCos);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.lblConSieCos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gpbxOpcion);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConSiembra_Cosecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConSiembra_Cosecha";
            this.gpbxOpcion.ResumeLayout(false);
            this.gpbxOpcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewConSieCos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gpbxOpcion;
        private System.Windows.Forms.RadioButton rdbtnSector;
        private System.Windows.Forms.RadioButton rdbtnUsuario;
        private System.Windows.Forms.Label lblConSieCos;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.DataGridView dataViewConSieCos;
    }
}