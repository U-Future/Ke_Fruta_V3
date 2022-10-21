namespace Ke_Fruta.Presentacion.Gestionar
{
    partial class AgregarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProductos));
            this.lblAgregarProductos = new System.Windows.Forms.Label();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.gpboxDesea = new System.Windows.Forms.GroupBox();
            this.rdbtnQuitar = new System.Windows.Forms.RadioButton();
            this.rdbtnAgregar = new System.Windows.Forms.RadioButton();
            this.btnDone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gpboxAgregarProducto = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblKG = new System.Windows.Forms.Label();
            this.numUpDownKG = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpboxAgregar = new System.Windows.Forms.GroupBox();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataViewProductos = new System.Windows.Forms.DataGridView();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.btnBajaProducto = new System.Windows.Forms.Button();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            this.gpboxDesea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCantidad)).BeginInit();
            this.gpboxAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownKG)).BeginInit();
            this.gpboxAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarProductos
            // 
            this.lblAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAgregarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAgregarProductos.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProductos.Location = new System.Drawing.Point(0, 0);
            this.lblAgregarProductos.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblAgregarProductos.Name = "lblAgregarProductos";
            this.lblAgregarProductos.Size = new System.Drawing.Size(1218, 128);
            this.lblAgregarProductos.TabIndex = 61;
            this.lblAgregarProductos.Text = "Agregar Productos";
            this.lblAgregarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSalir
            // 
            this.pbxSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(1178, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(28, 34);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 305;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimizar.Image")));
            this.pbxMinimizar.Location = new System.Drawing.Point(1144, 12);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(28, 34);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 306;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // gpboxDesea
            // 
            this.gpboxDesea.Controls.Add(this.rdbtnQuitar);
            this.gpboxDesea.Controls.Add(this.rdbtnAgregar);
            this.gpboxDesea.Location = new System.Drawing.Point(25, 109);
            this.gpboxDesea.Name = "gpboxDesea";
            this.gpboxDesea.Size = new System.Drawing.Size(241, 69);
            this.gpboxDesea.TabIndex = 317;
            this.gpboxDesea.TabStop = false;
            this.gpboxDesea.Text = "Desea:";
            // 
            // rdbtnQuitar
            // 
            this.rdbtnQuitar.AutoSize = true;
            this.rdbtnQuitar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnQuitar.Location = new System.Drawing.Point(140, 29);
            this.rdbtnQuitar.Name = "rdbtnQuitar";
            this.rdbtnQuitar.Size = new System.Drawing.Size(94, 27);
            this.rdbtnQuitar.TabIndex = 1;
            this.rdbtnQuitar.Text = "Quitar";
            this.rdbtnQuitar.UseVisualStyleBackColor = true;
            // 
            // rdbtnAgregar
            // 
            this.rdbtnAgregar.AutoSize = true;
            this.rdbtnAgregar.Checked = true;
            this.rdbtnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAgregar.Location = new System.Drawing.Point(6, 29);
            this.rdbtnAgregar.Name = "rdbtnAgregar";
            this.rdbtnAgregar.Size = new System.Drawing.Size(115, 27);
            this.rdbtnAgregar.TabIndex = 0;
            this.rdbtnAgregar.TabStop = true;
            this.rdbtnAgregar.Text = "Agregar";
            this.rdbtnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(151, 184);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(134, 38);
            this.btnDone.TabIndex = 316;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 315;
            this.label2.Text = "Cantidad:";
            // 
            // numUpDownCantidad
            // 
            this.numUpDownCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numUpDownCantidad.Location = new System.Drawing.Point(11, 66);
            this.numUpDownCantidad.Name = "numUpDownCantidad";
            this.numUpDownCantidad.Size = new System.Drawing.Size(274, 32);
            this.numUpDownCantidad.TabIndex = 314;
            this.numUpDownCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Location = new System.Drawing.Point(6, 163);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(187, 30);
            this.lblInsumo.TabIndex = 313;
            this.lblInsumo.Text = "ID PRODUCTO:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(11, 196);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(279, 37);
            this.txtID.TabIndex = 312;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // gpboxAgregarProducto
            // 
            this.gpboxAgregarProducto.Controls.Add(this.btnCancelar);
            this.gpboxAgregarProducto.Controls.Add(this.btnAgregar);
            this.gpboxAgregarProducto.Controls.Add(this.lblKG);
            this.gpboxAgregarProducto.Controls.Add(this.numUpDownKG);
            this.gpboxAgregarProducto.Controls.Add(this.txtPrecio);
            this.gpboxAgregarProducto.Controls.Add(this.lblPrecio);
            this.gpboxAgregarProducto.Controls.Add(this.txtFabricante);
            this.gpboxAgregarProducto.Controls.Add(this.lblFabricante);
            this.gpboxAgregarProducto.Controls.Add(this.cboxTipo);
            this.gpboxAgregarProducto.Controls.Add(this.lblTipo);
            this.gpboxAgregarProducto.Controls.Add(this.txtNom);
            this.gpboxAgregarProducto.Controls.Add(this.lblNombre);
            this.gpboxAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxAgregarProducto.Location = new System.Drawing.Point(433, 66);
            this.gpboxAgregarProducto.Name = "gpboxAgregarProducto";
            this.gpboxAgregarProducto.Size = new System.Drawing.Size(307, 472);
            this.gpboxAgregarProducto.TabIndex = 319;
            this.gpboxAgregarProducto.TabStop = false;
            this.gpboxAgregarProducto.Text = "Agregar Producto:";
            this.gpboxAgregarProducto.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(83, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 38);
            this.btnCancelar.TabIndex = 329;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(83, 351);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 38);
            this.btnAgregar.TabIndex = 318;
            this.btnAgregar.Text = "DONE";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(59, 281);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(50, 25);
            this.lblKG.TabIndex = 328;
            this.lblKG.Text = "KG:";
            // 
            // numUpDownKG
            // 
            this.numUpDownKG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numUpDownKG.Location = new System.Drawing.Point(63, 307);
            this.numUpDownKG.Name = "numUpDownKG";
            this.numUpDownKG.Size = new System.Drawing.Size(183, 34);
            this.numUpDownKG.TabIndex = 327;
            this.numUpDownKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(63, 246);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(183, 34);
            this.txtPrecio.TabIndex = 326;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(59, 220);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(84, 25);
            this.lblPrecio.TabIndex = 325;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFabricante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFabricante.Location = new System.Drawing.Point(63, 185);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(183, 34);
            this.txtFabricante.TabIndex = 324;
            this.txtFabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFabricante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFabricante_KeyPress);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(59, 159);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(134, 25);
            this.lblFabricante.TabIndex = 323;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // cboxTipo
            // 
            this.cboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "",
            "Fertilizante",
            "Herbicida",
            "Fungicida",
            "Semilla"});
            this.cboxTipo.Location = new System.Drawing.Point(63, 125);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(183, 33);
            this.cboxTipo.TabIndex = 322;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(59, 99);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(62, 25);
            this.lblTipo.TabIndex = 321;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(63, 64);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(183, 34);
            this.txtNom.TabIndex = 320;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(58, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 25);
            this.lblNombre.TabIndex = 314;
            this.lblNombre.Text = "Nombre:";
            // 
            // gpboxAgregar
            // 
            this.gpboxAgregar.Controls.Add(this.btnCancelar1);
            this.gpboxAgregar.Controls.Add(this.label2);
            this.gpboxAgregar.Controls.Add(this.gpboxDesea);
            this.gpboxAgregar.Controls.Add(this.btnDone);
            this.gpboxAgregar.Controls.Add(this.numUpDownCantidad);
            this.gpboxAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxAgregar.Location = new System.Drawing.Point(811, 380);
            this.gpboxAgregar.Name = "gpboxAgregar";
            this.gpboxAgregar.Size = new System.Drawing.Size(295, 244);
            this.gpboxAgregar.TabIndex = 329;
            this.gpboxAgregar.TabStop = false;
            this.gpboxAgregar.Text = "Agregar";
            this.gpboxAgregar.Visible = false;
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar1.Location = new System.Drawing.Point(11, 184);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(134, 38);
            this.btnCancelar1.TabIndex = 318;
            this.btnCancelar1.Text = "CANCELAR";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(11, 239);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(279, 38);
            this.btnBuscar.TabIndex = 320;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataViewProductos
            // 
            this.dataViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewProductos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataViewProductos.ColumnHeadersHeight = 34;
            this.dataViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataViewProductos.Location = new System.Drawing.Point(308, 163);
            this.dataViewProductos.Name = "dataViewProductos";
            this.dataViewProductos.RowHeadersWidth = 62;
            this.dataViewProductos.RowTemplate.Height = 28;
            this.dataViewProductos.Size = new System.Drawing.Size(897, 186);
            this.dataViewProductos.TabIndex = 330;
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTodo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.Location = new System.Drawing.Point(11, 283);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(279, 38);
            this.btnListarTodo.TabIndex = 331;
            this.btnListarTodo.Text = "LISTAR PRODUCTOS";
            this.btnListarTodo.UseVisualStyleBackColor = true;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click_1);
            // 
            // btnBajaProducto
            // 
            this.btnBajaProducto.Enabled = false;
            this.btnBajaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaProducto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaProducto.Location = new System.Drawing.Point(11, 371);
            this.btnBajaProducto.Name = "btnBajaProducto";
            this.btnBajaProducto.Size = new System.Drawing.Size(279, 38);
            this.btnBajaProducto.TabIndex = 332;
            this.btnBajaProducto.Text = "BAJA";
            this.btnBajaProducto.UseVisualStyleBackColor = true;
            this.btnBajaProducto.Click += new System.EventHandler(this.btnBajaProducto_Click);
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProducto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.Location = new System.Drawing.Point(11, 327);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(279, 38);
            this.btnAltaProducto.TabIndex = 333;
            this.btnAltaProducto.Text = "ALTA";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1218, 636);
            this.Controls.Add(this.btnAltaProducto);
            this.Controls.Add(this.btnBajaProducto);
            this.Controls.Add(this.btnListarTodo);
            this.Controls.Add(this.dataViewProductos);
            this.Controls.Add(this.gpboxAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpboxAgregarProducto);
            this.Controls.Add(this.lblInsumo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.lblAgregarProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AgregarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            this.gpboxDesea.ResumeLayout(false);
            this.gpboxDesea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCantidad)).EndInit();
            this.gpboxAgregarProducto.ResumeLayout(false);
            this.gpboxAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownKG)).EndInit();
            this.gpboxAgregar.ResumeLayout(false);
            this.gpboxAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarProductos;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.GroupBox gpboxDesea;
        private System.Windows.Forms.RadioButton rdbtnQuitar;
        private System.Windows.Forms.RadioButton rdbtnAgregar;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownCantidad;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gpboxAgregarProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.NumericUpDown numUpDownKG;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpboxAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.DataGridView dataViewProductos;
        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.Button btnBajaProducto;
        private System.Windows.Forms.Button btnAltaProducto;
    }
}