namespace Ke_Fruta.Presentacion
{
    partial class SeleccioneApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccioneApp));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTienda = new System.Windows.Forms.Button();
            this.btnProductor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Aplicacion:";
            // 
            // btnTienda
            // 
            this.btnTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienda.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienda.Location = new System.Drawing.Point(43, 168);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(283, 95);
            this.btnTienda.TabIndex = 78;
            this.btnTienda.Text = "TIENDA";
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btnTienda_Click_1);
            // 
            // btnProductor
            // 
            this.btnProductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductor.Location = new System.Drawing.Point(356, 168);
            this.btnProductor.Name = "btnProductor";
            this.btnProductor.Size = new System.Drawing.Size(283, 95);
            this.btnProductor.TabIndex = 79;
            this.btnProductor.Text = "APLICACION";
            this.btnProductor.UseVisualStyleBackColor = true;
            this.btnProductor.Click += new System.EventHandler(this.btnProductor_Click_1);
            // 
            // SeleccioneApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(686, 339);
            this.Controls.Add(this.btnProductor);
            this.Controls.Add(this.btnTienda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SeleccioneApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccioneApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.Button btnProductor;
    }
}