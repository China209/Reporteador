namespace CapaVistaReporteador.Mantenimientos
{
    partial class frmAplicativo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAplicativo));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.gbxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvVistaDatos = new System.Windows.Forms.DataGridView();
            this.cmsEM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInferior.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.gbxIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).BeginInit();
            this.cmsEM.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSuperior.Controls.Add(this.btnAyuda);
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1274, 72);
            this.pnlSuperior.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1191, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(83, 72);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.Silver;
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.ForeColor = System.Drawing.Color.Black;
            this.pnlInferior.Location = new System.Drawing.Point(0, 667);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1274, 50);
            this.pnlInferior.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(521, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(707, 15);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.btnRefrescar);
            this.pnlCuerpo.Controls.Add(this.lblBuscar);
            this.pnlCuerpo.Controls.Add(this.cmbBuscar);
            this.pnlCuerpo.Controls.Add(this.gbxIngresoDatos);
            this.pnlCuerpo.Controls.Add(this.dgvVistaDatos);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 72);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1274, 595);
            this.pnlCuerpo.TabIndex = 2;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefrescar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefrescar.Location = new System.Drawing.Point(401, 216);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(220, 34);
            this.btnRefrescar.TabIndex = 16;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(740, 223);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 20);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Buscar";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(829, 220);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(401, 28);
            this.cmbBuscar.TabIndex = 14;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // gbxIngresoDatos
            // 
            this.gbxIngresoDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxIngresoDatos.BackColor = System.Drawing.Color.White;
            this.gbxIngresoDatos.Controls.Add(this.cmbModulo);
            this.gbxIngresoDatos.Controls.Add(this.lblModulo);
            this.gbxIngresoDatos.Controls.Add(this.txtDescripcion);
            this.gbxIngresoDatos.Controls.Add(this.txtNombre);
            this.gbxIngresoDatos.Controls.Add(this.lblDescripcion);
            this.gbxIngresoDatos.Controls.Add(this.lblNombre);
            this.gbxIngresoDatos.Controls.Add(this.btnModificar);
            this.gbxIngresoDatos.Controls.Add(this.btnGuardar);
            this.gbxIngresoDatos.Location = new System.Drawing.Point(55, 24);
            this.gbxIngresoDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIngresoDatos.Name = "gbxIngresoDatos";
            this.gbxIngresoDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIngresoDatos.Size = new System.Drawing.Size(1175, 164);
            this.gbxIngresoDatos.TabIndex = 5;
            this.gbxIngresoDatos.TabStop = false;
            this.gbxIngresoDatos.Text = "Datos de Aplicativo";
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(138, 106);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(223, 28);
            this.cmbModulo.TabIndex = 7;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(43, 106);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(69, 20);
            this.lblModulo.TabIndex = 6;
            this.lblModulo.Text = "Modulo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(579, 42);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(229, 27);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 27);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(424, 45);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(878, 92);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(220, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(878, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 34);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvVistaDatos
            // 
            this.dgvVistaDatos.AllowUserToAddRows = false;
            this.dgvVistaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaDatos.GridColor = System.Drawing.Color.DarkGray;
            this.dgvVistaDatos.Location = new System.Drawing.Point(55, 285);
            this.dgvVistaDatos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVistaDatos.Name = "dgvVistaDatos";
            this.dgvVistaDatos.RowHeadersWidth = 51;
            this.dgvVistaDatos.RowTemplate.Height = 24;
            this.dgvVistaDatos.Size = new System.Drawing.Size(1175, 263);
            this.dgvVistaDatos.TabIndex = 4;
            this.dgvVistaDatos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistaDatos_CellMouseUp);
            // 
            // cmsEM
            // 
            this.cmsEM.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEliminar,
            this.cmsModificar});
            this.cmsEM.Name = "cmsEM";
            this.cmsEM.Size = new System.Drawing.Size(158, 52);
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(157, 24);
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.Click += new System.EventHandler(this.cmsEliminar_Click);
            // 
            // cmsModificar
            // 
            this.cmsModificar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsModificar.Name = "cmsModificar";
            this.cmsModificar.Size = new System.Drawing.Size(157, 24);
            this.cmsModificar.Text = "Actualizar";
            this.cmsModificar.Click += new System.EventHandler(this.cmsModificar_Click);
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            this.ttMensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmAplicativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 717);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAplicativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAplicativo_FormClosing);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.gbxIngresoDatos.ResumeLayout(false);
            this.gbxIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).EndInit();
            this.cmsEM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.ContextMenuStrip cmsEM;
        private System.Windows.Forms.ToolStripMenuItem cmsEliminar;
        private System.Windows.Forms.ToolStripMenuItem cmsModificar;
        private System.Windows.Forms.GroupBox gbxIngresoDatos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvVistaDatos;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}