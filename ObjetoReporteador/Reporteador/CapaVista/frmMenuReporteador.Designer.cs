namespace CapaVista
{
    partial class frmMenuReporteador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuReporteador));
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.btnAsigModulo = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAsigApp = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(147, 19);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(310, 114);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "REPORTES";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModulo.FlatAppearance.BorderSize = 0;
            this.btnModulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnModulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo.ForeColor = System.Drawing.Color.White;
            this.btnModulo.Location = new System.Drawing.Point(147, 140);
            this.btnModulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(310, 114);
            this.btnModulo.TabIndex = 1;
            this.btnModulo.Text = "MODULOS";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnApp
            // 
            this.btnApp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnApp.FlatAppearance.BorderSize = 0;
            this.btnApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp.ForeColor = System.Drawing.Color.White;
            this.btnApp.Location = new System.Drawing.Point(147, 261);
            this.btnApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(310, 114);
            this.btnApp.TabIndex = 2;
            this.btnApp.Text = "APLICACION";
            this.btnApp.UseVisualStyleBackColor = false;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // btnAsigModulo
            // 
            this.btnAsigModulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAsigModulo.FlatAppearance.BorderSize = 0;
            this.btnAsigModulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAsigModulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAsigModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsigModulo.ForeColor = System.Drawing.Color.White;
            this.btnAsigModulo.Location = new System.Drawing.Point(147, 382);
            this.btnAsigModulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsigModulo.Name = "btnAsigModulo";
            this.btnAsigModulo.Size = new System.Drawing.Size(310, 114);
            this.btnAsigModulo.TabIndex = 3;
            this.btnAsigModulo.Text = "ASIGNACION MODULO";
            this.btnAsigModulo.UseVisualStyleBackColor = false;
            this.btnAsigModulo.Click += new System.EventHandler(this.btnAsigModulo_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnAsigApp);
            this.pnlMenu.Controls.Add(this.btnApp);
            this.pnlMenu.Controls.Add(this.btnAsigModulo);
            this.pnlMenu.Controls.Add(this.btnReporte);
            this.pnlMenu.Controls.Add(this.btnModulo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(606, 669);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnAsigApp
            // 
            this.btnAsigApp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAsigApp.FlatAppearance.BorderSize = 0;
            this.btnAsigApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAsigApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAsigApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsigApp.ForeColor = System.Drawing.Color.White;
            this.btnAsigApp.Location = new System.Drawing.Point(147, 504);
            this.btnAsigApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsigApp.Name = "btnAsigApp";
            this.btnAsigApp.Size = new System.Drawing.Size(310, 114);
            this.btnAsigApp.TabIndex = 4;
            this.btnAsigApp.Text = "ASIGNACION APLICACIÓN";
            this.btnAsigApp.UseVisualStyleBackColor = false;
            this.btnAsigApp.Click += new System.EventHandler(this.btnAsigApp_Click);
            // 
            // frmMenuReporteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 669);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuReporteador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Reporteador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuReporteador_FormClosing);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnApp;
        private System.Windows.Forms.Button btnAsigModulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAsigApp;
    }
}