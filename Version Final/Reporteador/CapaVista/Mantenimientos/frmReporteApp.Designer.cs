namespace CapaVistaReporteador.Mantenimientos
{
    partial class frmReporteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteApp));
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dgvVistaDatos = new System.Windows.Forms.DataGridView();
            this.gbxInsercion = new System.Windows.Forms.GroupBox();
            this.cmbAplicativo = new System.Windows.Forms.ComboBox();
            this.lblAplicativo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsEM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.tltVentana = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCuerpo.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).BeginInit();
            this.gbxInsercion.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsEM.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.pnlInferior);
            this.pnlCuerpo.Controls.Add(this.dgvVistaDatos);
            this.pnlCuerpo.Controls.Add(this.gbxInsercion);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 90);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1029, 631);
            this.pnlCuerpo.TabIndex = 9;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.Silver;
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.ForeColor = System.Drawing.Color.Black;
            this.pnlInferior.Location = new System.Drawing.Point(0, 563);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1029, 68);
            this.pnlInferior.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(287, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(559, 29);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 20);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora";
            // 
            // dgvVistaDatos
            // 
            this.dgvVistaDatos.AllowUserToDeleteRows = false;
            this.dgvVistaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVistaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaDatos.GridColor = System.Drawing.Color.DarkGray;
            this.dgvVistaDatos.Location = new System.Drawing.Point(49, 226);
            this.dgvVistaDatos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVistaDatos.Name = "dgvVistaDatos";
            this.dgvVistaDatos.ReadOnly = true;
            this.dgvVistaDatos.RowHeadersWidth = 51;
            this.dgvVistaDatos.RowTemplate.Height = 24;
            this.dgvVistaDatos.Size = new System.Drawing.Size(935, 312);
            this.dgvVistaDatos.TabIndex = 3;
            this.dgvVistaDatos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVistaDatos_CellMouseUp);
            // 
            // gbxInsercion
            // 
            this.gbxInsercion.Controls.Add(this.cmbAplicativo);
            this.gbxInsercion.Controls.Add(this.lblAplicativo);
            this.gbxInsercion.Controls.Add(this.btnGuardar);
            this.gbxInsercion.Controls.Add(this.cmbModulo);
            this.gbxInsercion.Controls.Add(this.cmbReporte);
            this.gbxInsercion.Controls.Add(this.lblReporte);
            this.gbxInsercion.Controls.Add(this.lblModulo);
            this.gbxInsercion.Location = new System.Drawing.Point(112, 22);
            this.gbxInsercion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbxInsercion.Name = "gbxInsercion";
            this.gbxInsercion.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbxInsercion.Size = new System.Drawing.Size(824, 191);
            this.gbxInsercion.TabIndex = 2;
            this.gbxInsercion.TabStop = false;
            this.gbxInsercion.Text = "Datos Asignación Reporte a Aplicativo";
            // 
            // cmbAplicativo
            // 
            this.cmbAplicativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAplicativo.FormattingEnabled = true;
            this.cmbAplicativo.Location = new System.Drawing.Point(182, 135);
            this.cmbAplicativo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbAplicativo.Name = "cmbAplicativo";
            this.cmbAplicativo.Size = new System.Drawing.Size(348, 28);
            this.cmbAplicativo.TabIndex = 6;
            // 
            // lblAplicativo
            // 
            this.lblAplicativo.AutoSize = true;
            this.lblAplicativo.Location = new System.Drawing.Point(36, 135);
            this.lblAplicativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAplicativo.Name = "lblAplicativo";
            this.lblAplicativo.Size = new System.Drawing.Size(88, 20);
            this.lblAplicativo.TabIndex = 5;
            this.lblAplicativo.Text = "Aplicativo";
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
            this.btnGuardar.Location = new System.Drawing.Point(590, 85);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 48);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(182, 85);
            this.cmbModulo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(348, 28);
            this.cmbModulo.TabIndex = 3;
            // 
            // cmbReporte
            // 
            this.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Location = new System.Drawing.Point(182, 42);
            this.cmbReporte.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(348, 28);
            this.cmbReporte.TabIndex = 2;
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Location = new System.Drawing.Point(36, 42);
            this.lblReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(71, 20);
            this.lblReporte.TabIndex = 0;
            this.lblReporte.Text = "Reporte";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(36, 85);
            this.lblModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(69, 20);
            this.lblModulo.TabIndex = 1;
            this.lblModulo.Text = "Modulo";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSuperior.Controls.Add(this.btnAyuda);
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(6);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1029, 90);
            this.pnlSuperior.TabIndex = 8;
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(936, 0);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(92, 90);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmsEM
            // 
            this.cmsEM.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEliminar});
            this.cmsEM.Name = "cmsEM";
            this.cmsEM.Size = new System.Drawing.Size(146, 28);
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.Size = new System.Drawing.Size(145, 24);
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.Click += new System.EventHandler(this.cmsEliminar_Click);
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // tltVentana
            // 
            this.tltVentana.IsBalloon = true;
            this.tltVentana.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmReporteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 721);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "105 - Asignar Reporte a Aplicación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporteApp_FormClosing);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).EndInit();
            this.gbxInsercion.ResumeLayout(false);
            this.gbxInsercion.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsEM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.DataGridView dgvVistaDatos;
        private System.Windows.Forms.GroupBox gbxInsercion;
        private System.Windows.Forms.ComboBox cmbAplicativo;
        private System.Windows.Forms.Label lblAplicativo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.ComboBox cmbReporte;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ContextMenuStrip cmsEM;
        private System.Windows.Forms.ToolStripMenuItem cmsEliminar;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.ToolTip tltVentana;
    }
}