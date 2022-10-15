namespace Ke_Fruta.Presentacion.ProductorActividades
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.lblVender = new System.Windows.Forms.Label();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCargarPro = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dataViewMisProductos = new System.Windows.Forms.DataGridView();
            this.ID_Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMisProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVender
            // 
            this.lblVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblVender.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVender.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVender.Location = new System.Drawing.Point(0, 0);
            this.lblVender.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblVender.Name = "lblVender";
            this.lblVender.Size = new System.Drawing.Size(838, 123);
            this.lblVender.TabIndex = 60;
            this.lblVender.Text = "Vender";
            this.lblVender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSalir
            // 
            this.pbxSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(799, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(28, 34);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 62;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimizar.Image")));
            this.pbxMinimizar.Location = new System.Drawing.Point(765, 12);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(28, 34);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 63;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // btnVender
            // 
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(366, 624);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(117, 37);
            this.btnVender.TabIndex = 72;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(232, 422);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(383, 37);
            this.txtID.TabIndex = 74;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(227, 389);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 30);
            this.lblID.TabIndex = 73;
            this.lblID.Text = "ID:";
            // 
            // btnCargarPro
            // 
            this.btnCargarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPro.Location = new System.Drawing.Point(232, 349);
            this.btnCargarPro.Name = "btnCargarPro";
            this.btnCargarPro.Size = new System.Drawing.Size(383, 37);
            this.btnCargarPro.TabIndex = 76;
            this.btnCargarPro.Text = "CARGAR MIS PRODUCTOS";
            this.btnCargarPro.UseVisualStyleBackColor = true;
            this.btnCargarPro.Click += new System.EventHandler(this.btnCargarPro_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(232, 495);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(383, 37);
            this.txtCantidad.TabIndex = 77;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(227, 462);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(145, 30);
            this.lblCantidad.TabIndex = 78;
            this.lblCantidad.Text = "CANTIDAD:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(227, 535);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(109, 30);
            this.lblPrecio.TabIndex = 80;
            this.lblPrecio.Text = "PRECIO:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(232, 568);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(383, 37);
            this.txtPrecio.TabIndex = 79;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataViewMisProductos
            // 
            this.dataViewMisProductos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataViewMisProductos.ColumnHeadersHeight = 34;
            this.dataViewMisProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataViewMisProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Insumo,
            this.Nombre,
            this.Tipo,
            this.KG,
            this.Cantidad});
            this.dataViewMisProductos.Location = new System.Drawing.Point(11, 126);
            this.dataViewMisProductos.Name = "dataViewMisProductos";
            this.dataViewMisProductos.RowHeadersWidth = 62;
            this.dataViewMisProductos.RowTemplate.Height = 28;
            this.dataViewMisProductos.Size = new System.Drawing.Size(816, 214);
            this.dataViewMisProductos.TabIndex = 81;
            // 
            // ID_Insumo
            // 
            this.ID_Insumo.HeaderText = "ID";
            this.ID_Insumo.MinimumWidth = 8;
            this.ID_Insumo.Name = "ID_Insumo";
            this.ID_Insumo.ReadOnly = true;
            this.ID_Insumo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // KG
            // 
            this.KG.HeaderText = "KG";
            this.KG.MinimumWidth = 8;
            this.KG.Name = "KG";
            this.KG.ReadOnly = true;
            this.KG.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(838, 673);
            this.Controls.Add(this.dataViewMisProductos);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCargarPro);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.lblVender);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMisProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVender;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCargarPro;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dataViewMisProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}