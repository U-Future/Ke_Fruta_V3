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
            this.dataViewConSieCos = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpbxOpcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewConSieCos)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(512, 262);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(281, 38);
            this.btnConsultar.TabIndex = 55;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.Location = new System.Drawing.Point(507, 186);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(106, 30);
            this.lblConsultar.TabIndex = 54;
            this.lblConsultar.Text = "Ingrese:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(512, 219);
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
            this.gpbxOpcion.Location = new System.Drawing.Point(461, 63);
            this.gpbxOpcion.Name = "gpbxOpcion";
            this.gpbxOpcion.Size = new System.Drawing.Size(386, 107);
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
            // dataViewConSieCos
            // 
            this.dataViewConSieCos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewConSieCos.ColumnHeadersHeight = 34;
            this.dataViewConSieCos.Location = new System.Drawing.Point(241, 328);
            this.dataViewConSieCos.Name = "dataViewConSieCos";
            this.dataViewConSieCos.RowHeadersWidth = 62;
            this.dataViewConSieCos.RowTemplate.Height = 28;
            this.dataViewConSieCos.Size = new System.Drawing.Size(808, 150);
            this.dataViewConSieCos.TabIndex = 77;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.btnVolver);
            this.pnlMenu.Controls.Add(this.pbxLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(235, 540);
            this.pnlMenu.TabIndex = 78;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(234, 225);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 74;
            this.pbxLogo.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(0, 475);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(235, 38);
            this.btnVolver.TabIndex = 79;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ConSiembra_Cosecha
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1059, 540);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dataViewConSieCos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gpbxOpcion);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConSiembra_Cosecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConSiembra_Cosecha";
            this.gpbxOpcion.ResumeLayout(false);
            this.gpbxOpcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewConSieCos)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
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
        private System.Windows.Forms.DataGridView dataViewConSieCos;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}