namespace Ke_Fruta
{
    partial class Administrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrativo));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.menuAdministrativo = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSiembraYCosechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSiembraOCosechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.menuAdministrativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(0, 40);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(800, 107);
            this.lblBienvenido.TabIndex = 12;
            this.lblBienvenido.Text = "BIENVENIDO";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxImg
            // 
            this.pbxImg.BackColor = System.Drawing.Color.White;
            this.pbxImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxImg.Image")));
            this.pbxImg.Location = new System.Drawing.Point(266, 193);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(236, 235);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 13;
            this.pbxImg.TabStop = false;
            // 
            // menuAdministrativo
            // 
            this.menuAdministrativo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuAdministrativo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuAdministrativo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuAdministrativo.Location = new System.Drawing.Point(0, 0);
            this.menuAdministrativo.Name = "menuAdministrativo";
            this.menuAdministrativo.Size = new System.Drawing.Size(800, 40);
            this.menuAdministrativo.TabIndex = 14;
            this.menuAdministrativo.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMCToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.agregarProductoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aBMCToolStripMenuItem
            // 
            this.aBMCToolStripMenuItem.Name = "aBMCToolStripMenuItem";
            this.aBMCToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.aBMCToolStripMenuItem.Text = "ABMC";
            this.aBMCToolStripMenuItem.Click += new System.EventHandler(this.aBMCToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarSiembraYCosechaToolStripMenuItem,
            this.consultarSiembraOCosechaToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // registrarSiembraYCosechaToolStripMenuItem
            // 
            this.registrarSiembraYCosechaToolStripMenuItem.Name = "registrarSiembraYCosechaToolStripMenuItem";
            this.registrarSiembraYCosechaToolStripMenuItem.Size = new System.Drawing.Size(472, 38);
            this.registrarSiembraYCosechaToolStripMenuItem.Text = "Registrar Siembra y Cosecha";
            this.registrarSiembraYCosechaToolStripMenuItem.Click += new System.EventHandler(this.registrarSiembraYCosechaToolStripMenuItem_Click);
            // 
            // consultarSiembraOCosechaToolStripMenuItem
            // 
            this.consultarSiembraOCosechaToolStripMenuItem.Name = "consultarSiembraOCosechaToolStripMenuItem";
            this.consultarSiembraOCosechaToolStripMenuItem.Size = new System.Drawing.Size(472, 38);
            this.consultarSiembraOCosechaToolStripMenuItem.Text = "Consultar Siembra o Cosecha";
            this.consultarSiembraOCosechaToolStripMenuItem.Click += new System.EventHandler(this.consultarSiembraOCosechaToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Administrativo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.pbxImg);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuAdministrativo);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuAdministrativo;
            this.Name = "Administrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.menuAdministrativo.ResumeLayout(false);
            this.menuAdministrativo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.MenuStrip menuAdministrativo;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSiembraYCosechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarSiembraOCosechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
    }
}