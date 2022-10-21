namespace Ke_Fruta
{
    partial class Productor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productor));
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.menuProductor = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criteriosDeFertilizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.menuProductor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(0, 38);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(800, 107);
            this.lblBienvenido.TabIndex = 13;
            this.lblBienvenido.Text = "BIENVENIDO";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuProductor
            // 
            this.menuProductor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProductor.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuProductor.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuProductor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuProductor.Location = new System.Drawing.Point(0, 0);
            this.menuProductor.Name = "menuProductor";
            this.menuProductor.Size = new System.Drawing.Size(800, 38);
            this.menuProductor.TabIndex = 15;
            this.menuProductor.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misDatosToolStripMenuItem,
            this.criteriosDeFertilizaciónToolStripMenuItem,
            this.tiendaToolStripMenuItem,
            this.venderToolStripMenuItem,
            this.tiendaToolStripMenuItem1,
            this.salirToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // misDatosToolStripMenuItem
            // 
            this.misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            this.misDatosToolStripMenuItem.Size = new System.Drawing.Size(398, 38);
            this.misDatosToolStripMenuItem.Text = "Mis Datos";
            this.misDatosToolStripMenuItem.Click += new System.EventHandler(this.misDatosToolStripMenuItem_Click);
            // 
            // criteriosDeFertilizaciónToolStripMenuItem
            // 
            this.criteriosDeFertilizaciónToolStripMenuItem.Name = "criteriosDeFertilizaciónToolStripMenuItem";
            this.criteriosDeFertilizaciónToolStripMenuItem.Size = new System.Drawing.Size(398, 38);
            this.criteriosDeFertilizaciónToolStripMenuItem.Text = "Criterios de Fertilización";
            this.criteriosDeFertilizaciónToolStripMenuItem.Click += new System.EventHandler(this.criteriosDeFertilizaciónToolStripMenuItem_Click);
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(398, 38);
            this.tiendaToolStripMenuItem.Text = "Gestionar Insumos";
            this.tiendaToolStripMenuItem.Click += new System.EventHandler(this.tiendaToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(398, 38);
            this.venderToolStripMenuItem.Text = "Vender";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // tiendaToolStripMenuItem1
            // 
            this.tiendaToolStripMenuItem1.Name = "tiendaToolStripMenuItem1";
            this.tiendaToolStripMenuItem1.Size = new System.Drawing.Size(398, 38);
            this.tiendaToolStripMenuItem1.Text = "Tienda";
            this.tiendaToolStripMenuItem1.Click += new System.EventHandler(this.tiendaToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(398, 38);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pbxImg
            // 
            this.pbxImg.BackColor = System.Drawing.Color.White;
            this.pbxImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxImg.Image")));
            this.pbxImg.Location = new System.Drawing.Point(282, 180);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(236, 235);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 16;
            this.pbxImg.TabStop = false;
            // 
            // Productor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.pbxImg);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.menuProductor);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuProductor;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Productor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productor";
            this.menuProductor.ResumeLayout(false);
            this.menuProductor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.MenuStrip menuProductor;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criteriosDeFertilizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbxImg;
    }
}