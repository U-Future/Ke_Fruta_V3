namespace Ke_Fruta.Gestion
{
    partial class RegistrarSieCos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarSieCos));
            this.lblRegSieCos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSectorID = new System.Windows.Forms.Label();
            this.txtBuscarSec = new System.Windows.Forms.TextBox();
            this.lblFechaSiembra = new System.Windows.Forms.Label();
            this.lblFechaCosecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.gpboxFechas = new System.Windows.Forms.GroupBox();
            this.gpboxCultivo = new System.Windows.Forms.GroupBox();
            this.rdbtnCebada = new System.Windows.Forms.RadioButton();
            this.rdbtnPapa = new System.Windows.Forms.RadioButton();
            this.rdbtnZapallo = new System.Windows.Forms.RadioButton();
            this.rdbtnLimon = new System.Windows.Forms.RadioButton();
            this.rdbtnNaranja = new System.Windows.Forms.RadioButton();
            this.rdbtnManzana = new System.Windows.Forms.RadioButton();
            this.rdbtnTrigo = new System.Windows.Forms.RadioButton();
            this.dtimepickerCosecha = new System.Windows.Forms.DateTimePicker();
            this.dtimepickerSiembra = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.gpboxFechas.SuspendLayout();
            this.gpboxCultivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegSieCos
            // 
            this.lblRegSieCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRegSieCos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRegSieCos.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegSieCos.Location = new System.Drawing.Point(0, 0);
            this.lblRegSieCos.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblRegSieCos.Name = "lblRegSieCos";
            this.lblRegSieCos.Size = new System.Drawing.Size(950, 137);
            this.lblRegSieCos.TabIndex = 19;
            this.lblRegSieCos.Text = "Registrar\r\nSiembra y Cosecha";
            this.lblRegSieCos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(392, 227);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 38);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSectorID
            // 
            this.lblSectorID.AutoSize = true;
            this.lblSectorID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectorID.Location = new System.Drawing.Point(302, 151);
            this.lblSectorID.Name = "lblSectorID";
            this.lblSectorID.Size = new System.Drawing.Size(126, 30);
            this.lblSectorID.TabIndex = 52;
            this.lblSectorID.Text = "ID Sector:";
            // 
            // txtBuscarSec
            // 
            this.txtBuscarSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBuscarSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarSec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSec.Location = new System.Drawing.Point(307, 184);
            this.txtBuscarSec.Name = "txtBuscarSec";
            this.txtBuscarSec.Size = new System.Drawing.Size(318, 37);
            this.txtBuscarSec.TabIndex = 51;
            this.txtBuscarSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarSec_KeyPress);
            // 
            // lblFechaSiembra
            // 
            this.lblFechaSiembra.AutoSize = true;
            this.lblFechaSiembra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSiembra.Location = new System.Drawing.Point(182, 29);
            this.lblFechaSiembra.Name = "lblFechaSiembra";
            this.lblFechaSiembra.Size = new System.Drawing.Size(192, 30);
            this.lblFechaSiembra.TabIndex = 56;
            this.lblFechaSiembra.Text = "Fecha Siembra";
            // 
            // lblFechaCosecha
            // 
            this.lblFechaCosecha.AutoSize = true;
            this.lblFechaCosecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCosecha.Location = new System.Drawing.Point(152, 132);
            this.lblFechaCosecha.Name = "lblFechaCosecha";
            this.lblFechaCosecha.Size = new System.Drawing.Size(204, 30);
            this.lblFechaCosecha.TabIndex = 57;
            this.lblFechaCosecha.Text = "Fecha Cosecha";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(394, 240);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(149, 38);
            this.btnRegistrar.TabIndex = 60;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimizar.Image")));
            this.pbxMinimizar.Location = new System.Drawing.Point(878, 12);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(28, 34);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 73;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxSalir
            // 
            this.pbxSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(912, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(28, 34);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 74;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // gpboxFechas
            // 
            this.gpboxFechas.Controls.Add(this.gpboxCultivo);
            this.gpboxFechas.Controls.Add(this.dtimepickerCosecha);
            this.gpboxFechas.Controls.Add(this.dtimepickerSiembra);
            this.gpboxFechas.Controls.Add(this.lblFechaSiembra);
            this.gpboxFechas.Controls.Add(this.btnRegistrar);
            this.gpboxFechas.Controls.Add(this.lblFechaCosecha);
            this.gpboxFechas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpboxFechas.Enabled = false;
            this.gpboxFechas.Location = new System.Drawing.Point(0, 265);
            this.gpboxFechas.Name = "gpboxFechas";
            this.gpboxFechas.Size = new System.Drawing.Size(950, 292);
            this.gpboxFechas.TabIndex = 75;
            this.gpboxFechas.TabStop = false;
            // 
            // gpboxCultivo
            // 
            this.gpboxCultivo.Controls.Add(this.rdbtnCebada);
            this.gpboxCultivo.Controls.Add(this.rdbtnPapa);
            this.gpboxCultivo.Controls.Add(this.rdbtnZapallo);
            this.gpboxCultivo.Controls.Add(this.rdbtnLimon);
            this.gpboxCultivo.Controls.Add(this.rdbtnNaranja);
            this.gpboxCultivo.Controls.Add(this.rdbtnManzana);
            this.gpboxCultivo.Controls.Add(this.rdbtnTrigo);
            this.gpboxCultivo.Location = new System.Drawing.Point(508, 45);
            this.gpboxCultivo.Name = "gpboxCultivo";
            this.gpboxCultivo.Size = new System.Drawing.Size(434, 171);
            this.gpboxCultivo.TabIndex = 63;
            this.gpboxCultivo.TabStop = false;
            this.gpboxCultivo.Text = "Cultivo:";
            // 
            // rdbtnCebada
            // 
            this.rdbtnCebada.AutoSize = true;
            this.rdbtnCebada.Location = new System.Drawing.Point(122, 116);
            this.rdbtnCebada.Name = "rdbtnCebada";
            this.rdbtnCebada.Size = new System.Drawing.Size(138, 34);
            this.rdbtnCebada.TabIndex = 6;
            this.rdbtnCebada.Text = "Cebada";
            this.rdbtnCebada.UseVisualStyleBackColor = true;
            // 
            // rdbtnPapa
            // 
            this.rdbtnPapa.AutoSize = true;
            this.rdbtnPapa.Location = new System.Drawing.Point(6, 76);
            this.rdbtnPapa.Name = "rdbtnPapa";
            this.rdbtnPapa.Size = new System.Drawing.Size(196, 34);
            this.rdbtnPapa.TabIndex = 5;
            this.rdbtnPapa.Text = "Papa Rosada";
            this.rdbtnPapa.UseVisualStyleBackColor = true;
            // 
            // rdbtnZapallo
            // 
            this.rdbtnZapallo.AutoSize = true;
            this.rdbtnZapallo.Location = new System.Drawing.Point(208, 76);
            this.rdbtnZapallo.Name = "rdbtnZapallo";
            this.rdbtnZapallo.Size = new System.Drawing.Size(210, 34);
            this.rdbtnZapallo.TabIndex = 4;
            this.rdbtnZapallo.Text = "Zapallo Criollo";
            this.rdbtnZapallo.UseVisualStyleBackColor = true;
            // 
            // rdbtnLimon
            // 
            this.rdbtnLimon.AutoSize = true;
            this.rdbtnLimon.Checked = true;
            this.rdbtnLimon.Location = new System.Drawing.Point(6, 36);
            this.rdbtnLimon.Name = "rdbtnLimon";
            this.rdbtnLimon.Size = new System.Drawing.Size(110, 34);
            this.rdbtnLimon.TabIndex = 3;
            this.rdbtnLimon.TabStop = true;
            this.rdbtnLimon.Text = "Limon";
            this.rdbtnLimon.UseVisualStyleBackColor = true;
            // 
            // rdbtnNaranja
            // 
            this.rdbtnNaranja.AutoSize = true;
            this.rdbtnNaranja.Location = new System.Drawing.Point(122, 36);
            this.rdbtnNaranja.Name = "rdbtnNaranja";
            this.rdbtnNaranja.Size = new System.Drawing.Size(131, 34);
            this.rdbtnNaranja.TabIndex = 2;
            this.rdbtnNaranja.Text = "Naranja";
            this.rdbtnNaranja.UseVisualStyleBackColor = true;
            // 
            // rdbtnManzana
            // 
            this.rdbtnManzana.AutoSize = true;
            this.rdbtnManzana.Location = new System.Drawing.Point(259, 36);
            this.rdbtnManzana.Name = "rdbtnManzana";
            this.rdbtnManzana.Size = new System.Drawing.Size(149, 34);
            this.rdbtnManzana.TabIndex = 1;
            this.rdbtnManzana.Text = "Manzana";
            this.rdbtnManzana.UseVisualStyleBackColor = true;
            // 
            // rdbtnTrigo
            // 
            this.rdbtnTrigo.AutoSize = true;
            this.rdbtnTrigo.Location = new System.Drawing.Point(6, 116);
            this.rdbtnTrigo.Name = "rdbtnTrigo";
            this.rdbtnTrigo.Size = new System.Drawing.Size(94, 34);
            this.rdbtnTrigo.TabIndex = 0;
            this.rdbtnTrigo.Text = "Trigo";
            this.rdbtnTrigo.UseVisualStyleBackColor = true;
            // 
            // dtimepickerCosecha
            // 
            this.dtimepickerCosecha.Location = new System.Drawing.Point(11, 165);
            this.dtimepickerCosecha.Name = "dtimepickerCosecha";
            this.dtimepickerCosecha.Size = new System.Drawing.Size(491, 37);
            this.dtimepickerCosecha.TabIndex = 62;
            // 
            // dtimepickerSiembra
            // 
            this.dtimepickerSiembra.Location = new System.Drawing.Point(11, 62);
            this.dtimepickerSiembra.Name = "dtimepickerSiembra";
            this.dtimepickerSiembra.Size = new System.Drawing.Size(491, 37);
            this.dtimepickerSiembra.TabIndex = 61;
            // 
            // RegistrarSieCos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(950, 557);
            this.Controls.Add(this.gpboxFechas);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSectorID);
            this.Controls.Add(this.lblRegSieCos);
            this.Controls.Add(this.txtBuscarSec);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrarSieCos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarSieCos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.gpboxFechas.ResumeLayout(false);
            this.gpboxFechas.PerformLayout();
            this.gpboxCultivo.ResumeLayout(false);
            this.gpboxCultivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegSieCos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSectorID;
        private System.Windows.Forms.TextBox txtBuscarSec;
        private System.Windows.Forms.Label lblFechaSiembra;
        private System.Windows.Forms.Label lblFechaCosecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.GroupBox gpboxFechas;
        private System.Windows.Forms.DateTimePicker dtimepickerCosecha;
        private System.Windows.Forms.DateTimePicker dtimepickerSiembra;
        private System.Windows.Forms.GroupBox gpboxCultivo;
        private System.Windows.Forms.RadioButton rdbtnCebada;
        private System.Windows.Forms.RadioButton rdbtnPapa;
        private System.Windows.Forms.RadioButton rdbtnZapallo;
        private System.Windows.Forms.RadioButton rdbtnLimon;
        private System.Windows.Forms.RadioButton rdbtnNaranja;
        private System.Windows.Forms.RadioButton rdbtnManzana;
        private System.Windows.Forms.RadioButton rdbtnTrigo;
    }
}