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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSectorID = new System.Windows.Forms.Label();
            this.txtBuscarSec = new System.Windows.Forms.TextBox();
            this.lblFechaSiembra = new System.Windows.Forms.Label();
            this.lblFechaCosecha = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.gpboxFechas.SuspendLayout();
            this.gpboxCultivo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(636, 187);
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
            this.lblSectorID.Location = new System.Drawing.Point(546, 111);
            this.lblSectorID.Name = "lblSectorID";
            this.lblSectorID.Size = new System.Drawing.Size(126, 30);
            this.lblSectorID.TabIndex = 52;
            this.lblSectorID.Text = "ID Sector:";
            // 
            // txtBuscarSec
            // 
            this.txtBuscarSec.BackColor = System.Drawing.Color.White;
            this.txtBuscarSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarSec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarSec.Location = new System.Drawing.Point(551, 144);
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
            // gpboxFechas
            // 
            this.gpboxFechas.Controls.Add(this.gpboxCultivo);
            this.gpboxFechas.Controls.Add(this.dtimepickerCosecha);
            this.gpboxFechas.Controls.Add(this.dtimepickerSiembra);
            this.gpboxFechas.Controls.Add(this.lblFechaSiembra);
            this.gpboxFechas.Controls.Add(this.btnRegistrar);
            this.gpboxFechas.Controls.Add(this.lblFechaCosecha);
            this.gpboxFechas.Enabled = false;
            this.gpboxFechas.Location = new System.Drawing.Point(242, 259);
            this.gpboxFechas.Name = "gpboxFechas";
            this.gpboxFechas.Size = new System.Drawing.Size(954, 286);
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
            this.gpboxCultivo.Location = new System.Drawing.Point(520, 36);
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Controls.Add(this.btnVolver);
            this.pnlMenu.Controls.Add(this.pbxLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(236, 557);
            this.pnlMenu.TabIndex = 76;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(0, 493);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(236, 38);
            this.btnVolver.TabIndex = 76;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(234, 225);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 75;
            this.pbxLogo.TabStop = false;
            // 
            // RegistrarSieCos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1208, 557);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.gpboxFechas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblSectorID);
            this.Controls.Add(this.txtBuscarSec);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrarSieCos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarSieCos";
            this.gpboxFechas.ResumeLayout(false);
            this.gpboxFechas.PerformLayout();
            this.gpboxCultivo.ResumeLayout(false);
            this.gpboxCultivo.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSectorID;
        private System.Windows.Forms.TextBox txtBuscarSec;
        private System.Windows.Forms.Label lblFechaSiembra;
        private System.Windows.Forms.Label lblFechaCosecha;
        private System.Windows.Forms.Button btnRegistrar;
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
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}