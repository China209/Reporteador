namespace CapaVista.Mantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteApp));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.dgvVistaDatos = new System.Windows.Forms.DataGridView();
            this.gbxInsercion = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmbAplicativo = new System.Windows.Forms.ComboBox();
            this.lblAplicativo = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).BeginInit();
            this.gbxInsercion.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSuperior.Size = new System.Drawing.Size(926, 90);
            this.pnlSuperior.TabIndex = 5;
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(843, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(83, 90);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.dgvVistaDatos);
            this.pnlCuerpo.Controls.Add(this.gbxInsercion);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 90);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(926, 631);
            this.pnlCuerpo.TabIndex = 7;
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
            this.dgvVistaDatos.Location = new System.Drawing.Point(35, 236);
            this.dgvVistaDatos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVistaDatos.Name = "dgvVistaDatos";
            this.dgvVistaDatos.RowHeadersWidth = 51;
            this.dgvVistaDatos.RowTemplate.Height = 24;
            this.dgvVistaDatos.Size = new System.Drawing.Size(857, 369);
            this.dgvVistaDatos.TabIndex = 3;
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
            this.gbxInsercion.Location = new System.Drawing.Point(101, 22);
            this.gbxInsercion.Name = "gbxInsercion";
            this.gbxInsercion.Size = new System.Drawing.Size(741, 191);
            this.gbxInsercion.TabIndex = 2;
            this.gbxInsercion.TabStop = false;
            this.gbxInsercion.Text = "Datos Asignación Reporte a Aplicativo";
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
            this.btnGuardar.Location = new System.Drawing.Point(531, 85);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 47);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(164, 85);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(313, 30);
            this.cmbModulo.TabIndex = 3;
            // 
            // cmbReporte
            // 
            this.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Location = new System.Drawing.Point(164, 42);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(313, 30);
            this.cmbReporte.TabIndex = 2;
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Location = new System.Drawing.Point(33, 42);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(87, 23);
            this.lblReporte.TabIndex = 0;
            this.lblReporte.Text = "Reporte";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(33, 85);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(83, 23);
            this.lblModulo.TabIndex = 1;
            this.lblModulo.Text = "Modulo";
            // 
            // cmbAplicativo
            // 
            this.cmbAplicativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAplicativo.FormattingEnabled = true;
            this.cmbAplicativo.Location = new System.Drawing.Point(164, 135);
            this.cmbAplicativo.Name = "cmbAplicativo";
            this.cmbAplicativo.Size = new System.Drawing.Size(313, 30);
            this.cmbAplicativo.TabIndex = 6;
            // 
            // lblAplicativo
            // 
            this.lblAplicativo.AutoSize = true;
            this.lblAplicativo.Location = new System.Drawing.Point(33, 135);
            this.lblAplicativo.Name = "lblAplicativo";
            this.lblAplicativo.Size = new System.Drawing.Size(107, 23);
            this.lblAplicativo.TabIndex = 5;
            this.lblAplicativo.Text = "Aplicativo";
            // 
            // frmReporteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 721);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "frmReporteApp";
            this.Text = "frmReporteApp";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).EndInit();
            this.gbxInsercion.ResumeLayout(false);
            this.gbxInsercion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.DataGridView dgvVistaDatos;
        private System.Windows.Forms.GroupBox gbxInsercion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.ComboBox cmbReporte;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.ComboBox cmbAplicativo;
        private System.Windows.Forms.Label lblAplicativo;
    }
}