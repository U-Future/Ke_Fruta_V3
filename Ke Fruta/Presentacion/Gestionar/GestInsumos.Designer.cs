namespace Ke_Fruta.Gestionar
{
    partial class GestInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestInsumos));
            this.lblGestInsumos = new System.Windows.Forms.Label();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAddExistente = new System.Windows.Forms.Button();
            this.btnAgrMiPro = new System.Windows.Forms.Button();
            this.btnMisInsumos = new System.Windows.Forms.Button();
            this.dataViewMyInsumos = new System.Windows.Forms.DataGridView();
            this.ID_Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAgrMiPro = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAgregarAdd = new System.Windows.Forms.Button();
            this.txtCantAdd = new System.Windows.Forms.TextBox();
            this.lblCantAdd = new System.Windows.Forms.Label();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.lblIDAdd = new System.Windows.Forms.Label();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.btnQuitarDel = new System.Windows.Forms.Button();
            this.txtCantDel = new System.Windows.Forms.TextBox();
            this.lblCantDel = new System.Windows.Forms.Label();
            this.txtIDDel = new System.Windows.Forms.TextBox();
            this.lblIDDel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMyInsumos)).BeginInit();
            this.pnlAgrMiPro.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestInsumos
            // 
            this.lblGestInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblGestInsumos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGestInsumos.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestInsumos.Location = new System.Drawing.Point(0, 0);
            this.lblGestInsumos.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblGestInsumos.Name = "lblGestInsumos";
            this.lblGestInsumos.Size = new System.Drawing.Size(1102, 128);
            this.lblGestInsumos.TabIndex = 60;
            this.lblGestInsumos.Text = "Gestión de Insumos";
            this.lblGestInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSalir
            // 
            this.pbxSalir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(1062, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(28, 34);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 304;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinimizar.Image")));
            this.pbxMinimizar.Location = new System.Drawing.Point(1028, 12);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(28, 34);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 305;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpciones.Controls.Add(this.btnQuitar);
            this.pnlOpciones.Controls.Add(this.btnAddExistente);
            this.pnlOpciones.Controls.Add(this.btnAgrMiPro);
            this.pnlOpciones.Controls.Add(this.btnMisInsumos);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 128);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(234, 488);
            this.pnlOpciones.TabIndex = 313;
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(-1, 292);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(234, 38);
            this.btnQuitar.TabIndex = 72;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAddExistente
            // 
            this.btnAddExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExistente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExistente.Location = new System.Drawing.Point(-1, 248);
            this.btnAddExistente.Name = "btnAddExistente";
            this.btnAddExistente.Size = new System.Drawing.Size(234, 38);
            this.btnAddExistente.TabIndex = 71;
            this.btnAddExistente.Text = "AGREGAR EXISTENTE";
            this.btnAddExistente.UseVisualStyleBackColor = true;
            this.btnAddExistente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgrMiPro
            // 
            this.btnAgrMiPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrMiPro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrMiPro.Location = new System.Drawing.Point(-1, 158);
            this.btnAgrMiPro.Name = "btnAgrMiPro";
            this.btnAgrMiPro.Size = new System.Drawing.Size(234, 84);
            this.btnAgrMiPro.TabIndex = 70;
            this.btnAgrMiPro.Text = "AGREGAR PRODUCTO NO EXISTENTE";
            this.btnAgrMiPro.UseVisualStyleBackColor = true;
            this.btnAgrMiPro.Click += new System.EventHandler(this.btnAgrMiPro_Click);
            // 
            // btnMisInsumos
            // 
            this.btnMisInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisInsumos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisInsumos.Location = new System.Drawing.Point(-1, 114);
            this.btnMisInsumos.Name = "btnMisInsumos";
            this.btnMisInsumos.Size = new System.Drawing.Size(234, 38);
            this.btnMisInsumos.TabIndex = 69;
            this.btnMisInsumos.Text = "MIS INSUMOS";
            this.btnMisInsumos.UseVisualStyleBackColor = true;
            this.btnMisInsumos.Click += new System.EventHandler(this.btnMisInsumos_Click);
            // 
            // dataViewMyInsumos
            // 
            this.dataViewMyInsumos.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataViewMyInsumos.ColumnHeadersHeight = 34;
            this.dataViewMyInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataViewMyInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Insumo,
            this.Nombre,
            this.Tipo,
            this.KG,
            this.Cantidad});
            this.dataViewMyInsumos.Location = new System.Drawing.Point(277, 142);
            this.dataViewMyInsumos.Name = "dataViewMyInsumos";
            this.dataViewMyInsumos.RowHeadersWidth = 62;
            this.dataViewMyInsumos.RowTemplate.Height = 28;
            this.dataViewMyInsumos.Size = new System.Drawing.Size(815, 204);
            this.dataViewMyInsumos.TabIndex = 314;
            // 
            // ID_Insumo
            // 
            this.ID_Insumo.HeaderText = "ID Insumo";
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
            // pnlAgrMiPro
            // 
            this.pnlAgrMiPro.Controls.Add(this.btnAgregar);
            this.pnlAgrMiPro.Controls.Add(this.lblCantidad);
            this.pnlAgrMiPro.Controls.Add(this.txtCantidad);
            this.pnlAgrMiPro.Controls.Add(this.txtKg);
            this.pnlAgrMiPro.Controls.Add(this.lblKg);
            this.pnlAgrMiPro.Controls.Add(this.txtNombre);
            this.pnlAgrMiPro.Controls.Add(this.lblNombre);
            this.pnlAgrMiPro.Location = new System.Drawing.Point(597, 354);
            this.pnlAgrMiPro.Name = "pnlAgrMiPro";
            this.pnlAgrMiPro.Size = new System.Drawing.Size(232, 252);
            this.pnlAgrMiPro.TabIndex = 315;
            this.pnlAgrMiPro.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(38, 196);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 38);
            this.btnAgregar.TabIndex = 83;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(10, 132);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(119, 23);
            this.lblCantidad.TabIndex = 82;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(14, 158);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(203, 32);
            this.txtCantidad.TabIndex = 81;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtKg
            // 
            this.txtKg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKg.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKg.Location = new System.Drawing.Point(14, 97);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(203, 32);
            this.txtKg.TabIndex = 80;
            this.txtKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKg_KeyPress);
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(10, 71);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(44, 23);
            this.lblKg.TabIndex = 79;
            this.lblKg.Text = "KG:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(14, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 32);
            this.txtNombre.TabIndex = 78;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 23);
            this.lblNombre.TabIndex = 77;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnAgregarAdd);
            this.pnlAdd.Controls.Add(this.txtCantAdd);
            this.pnlAdd.Controls.Add(this.lblCantAdd);
            this.pnlAdd.Controls.Add(this.txtIDAdd);
            this.pnlAdd.Controls.Add(this.lblIDAdd);
            this.pnlAdd.Location = new System.Drawing.Point(494, 351);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(221, 252);
            this.pnlAdd.TabIndex = 316;
            this.pnlAdd.Visible = false;
            // 
            // btnAgregarAdd
            // 
            this.btnAgregarAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAdd.Location = new System.Drawing.Point(30, 133);
            this.btnAgregarAdd.Name = "btnAgregarAdd";
            this.btnAgregarAdd.Size = new System.Drawing.Size(160, 38);
            this.btnAgregarAdd.TabIndex = 84;
            this.btnAgregarAdd.Text = "AGREGAR";
            this.btnAgregarAdd.UseVisualStyleBackColor = true;
            this.btnAgregarAdd.Click += new System.EventHandler(this.btnAgregarAdd_Click);
            // 
            // txtCantAdd
            // 
            this.txtCantAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCantAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantAdd.Location = new System.Drawing.Point(7, 95);
            this.txtCantAdd.Name = "txtCantAdd";
            this.txtCantAdd.Size = new System.Drawing.Size(203, 32);
            this.txtCantAdd.TabIndex = 84;
            this.txtCantAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantAdd
            // 
            this.lblCantAdd.AutoSize = true;
            this.lblCantAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantAdd.Location = new System.Drawing.Point(3, 69);
            this.lblCantAdd.Name = "lblCantAdd";
            this.lblCantAdd.Size = new System.Drawing.Size(119, 23);
            this.lblCantAdd.TabIndex = 85;
            this.lblCantAdd.Text = "CANTIDAD:";
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIDAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDAdd.Location = new System.Drawing.Point(7, 34);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(203, 32);
            this.txtIDAdd.TabIndex = 84;
            this.txtIDAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDAdd
            // 
            this.lblIDAdd.AutoSize = true;
            this.lblIDAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAdd.Location = new System.Drawing.Point(3, 8);
            this.lblIDAdd.Name = "lblIDAdd";
            this.lblIDAdd.Size = new System.Drawing.Size(35, 23);
            this.lblIDAdd.TabIndex = 76;
            this.lblIDAdd.Text = "ID:";
            // 
            // pnlDel
            // 
            this.pnlDel.Controls.Add(this.btnQuitarDel);
            this.pnlDel.Controls.Add(this.txtCantDel);
            this.pnlDel.Controls.Add(this.lblCantDel);
            this.pnlDel.Controls.Add(this.txtIDDel);
            this.pnlDel.Controls.Add(this.lblIDDel);
            this.pnlDel.Location = new System.Drawing.Point(543, 352);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(221, 252);
            this.pnlDel.TabIndex = 317;
            this.pnlDel.Visible = false;
            // 
            // btnQuitarDel
            // 
            this.btnQuitarDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDel.Location = new System.Drawing.Point(30, 133);
            this.btnQuitarDel.Name = "btnQuitarDel";
            this.btnQuitarDel.Size = new System.Drawing.Size(160, 38);
            this.btnQuitarDel.TabIndex = 84;
            this.btnQuitarDel.Text = "QUITAR";
            this.btnQuitarDel.UseVisualStyleBackColor = true;
            this.btnQuitarDel.Click += new System.EventHandler(this.btnQuitarDel_Click);
            // 
            // txtCantDel
            // 
            this.txtCantDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCantDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantDel.Location = new System.Drawing.Point(7, 95);
            this.txtCantDel.Name = "txtCantDel";
            this.txtCantDel.Size = new System.Drawing.Size(203, 32);
            this.txtCantDel.TabIndex = 84;
            this.txtCantDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantDel
            // 
            this.lblCantDel.AutoSize = true;
            this.lblCantDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDel.Location = new System.Drawing.Point(3, 69);
            this.lblCantDel.Name = "lblCantDel";
            this.lblCantDel.Size = new System.Drawing.Size(119, 23);
            this.lblCantDel.TabIndex = 85;
            this.lblCantDel.Text = "CANTIDAD:";
            // 
            // txtIDDel
            // 
            this.txtIDDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIDDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDel.Location = new System.Drawing.Point(7, 34);
            this.txtIDDel.Name = "txtIDDel";
            this.txtIDDel.Size = new System.Drawing.Size(203, 32);
            this.txtIDDel.TabIndex = 84;
            this.txtIDDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDDel
            // 
            this.lblIDDel.AutoSize = true;
            this.lblIDDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDDel.Location = new System.Drawing.Point(3, 8);
            this.lblIDDel.Name = "lblIDDel";
            this.lblIDDel.Size = new System.Drawing.Size(35, 23);
            this.lblIDDel.TabIndex = 76;
            this.lblIDDel.Text = "ID:";
            // 
            // GestInsumos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1102, 616);
            this.Controls.Add(this.pnlDel);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlAgrMiPro);
            this.Controls.Add(this.dataViewMyInsumos);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.lblGestInsumos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GestInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMyInsumos)).EndInit();
            this.pnlAgrMiPro.ResumeLayout(false);
            this.pnlAgrMiPro.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlDel.ResumeLayout(false);
            this.pnlDel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGestInsumos;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAddExistente;
        private System.Windows.Forms.Button btnAgrMiPro;
        private System.Windows.Forms.Button btnMisInsumos;
        private System.Windows.Forms.DataGridView dataViewMyInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Panel pnlAgrMiPro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TextBox txtIDAdd;
        private System.Windows.Forms.Label lblIDAdd;
        private System.Windows.Forms.Button btnAgregarAdd;
        private System.Windows.Forms.TextBox txtCantAdd;
        private System.Windows.Forms.Label lblCantAdd;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.Button btnQuitarDel;
        private System.Windows.Forms.TextBox txtCantDel;
        private System.Windows.Forms.Label lblCantDel;
        private System.Windows.Forms.TextBox txtIDDel;
        private System.Windows.Forms.Label lblIDDel;
    }
}