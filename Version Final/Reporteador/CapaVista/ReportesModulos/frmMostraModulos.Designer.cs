namespace CapaVistaReporteador.ReportesModulos
{
    partial class frmMostraModulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostraModulos));
            this.crptReporteContenedor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.lbxListCRVReport = new System.Windows.Forms.ListBox();
            this.lblToolbar = new System.Windows.Forms.Label();
            this.btnRedisplay = new System.Windows.Forms.Button();
            this.lblSelectColor = new System.Windows.Forms.Label();
            this.cmbSelectBackColor = new System.Windows.Forms.ComboBox();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.btnGoToPage = new System.Windows.Forms.Button();
            this.txtZoomFactor = new System.Windows.Forms.TextBox();
            this.btnUpdateZoomFactor = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tltVentana = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crptReporteContenedor
            // 
            this.crptReporteContenedor.ActiveViewIndex = -1;
            this.crptReporteContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptReporteContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptReporteContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crptReporteContenedor.Location = new System.Drawing.Point(0, 191);
            this.crptReporteContenedor.Margin = new System.Windows.Forms.Padding(6);
            this.crptReporteContenedor.Name = "crptReporteContenedor";
            this.crptReporteContenedor.Size = new System.Drawing.Size(1370, 558);
            this.crptReporteContenedor.TabIndex = 1;
            this.crptReporteContenedor.ToolPanelWidth = 400;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblSeleccionar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbxListCRVReport, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblToolbar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRedisplay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSelectColor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectBackColor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPageNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnGoToPage, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZoomFactor, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateZoomFactor, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMessage, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.64968F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.28662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 266);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeleccionar.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionar.Location = new System.Drawing.Point(4, 0);
            this.lblSeleccionar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(334, 106);
            this.lblSeleccionar.TabIndex = 0;
            this.lblSeleccionar.Text = "Seleccione elementos de reporte a desplegar";
            this.lblSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxListCRVReport
            // 
            this.lbxListCRVReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxListCRVReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxListCRVReport.FormattingEnabled = true;
            this.lbxListCRVReport.ItemHeight = 22;
            this.lbxListCRVReport.Location = new System.Drawing.Point(346, 4);
            this.lbxListCRVReport.Margin = new System.Windows.Forms.Padding(4);
            this.lbxListCRVReport.Name = "lbxListCRVReport";
            this.lbxListCRVReport.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxListCRVReport.Size = new System.Drawing.Size(334, 98);
            this.lbxListCRVReport.TabIndex = 1;
            // 
            // lblToolbar
            // 
            this.lblToolbar.AutoSize = true;
            this.lblToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToolbar.ForeColor = System.Drawing.Color.White;
            this.lblToolbar.Location = new System.Drawing.Point(688, 0);
            this.lblToolbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToolbar.Name = "lblToolbar";
            this.lblToolbar.Size = new System.Drawing.Size(334, 106);
            this.lblToolbar.TabIndex = 2;
            this.lblToolbar.Text = "Seleccione los elementos barra de herramientas a desplegar";
            this.lblToolbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRedisplay
            // 
            this.btnRedisplay.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRedisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedisplay.FlatAppearance.BorderSize = 0;
            this.btnRedisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnRedisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRedisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedisplay.Location = new System.Drawing.Point(4, 149);
            this.btnRedisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedisplay.Name = "btnRedisplay";
            this.btnRedisplay.Size = new System.Drawing.Size(334, 30);
            this.btnRedisplay.TabIndex = 3;
            this.btnRedisplay.Text = "Desplegar Reporte";
            this.btnRedisplay.UseVisualStyleBackColor = false;
            this.btnRedisplay.Click += new System.EventHandler(this.btnRedisplay_Click);
            // 
            // lblSelectColor
            // 
            this.lblSelectColor.AutoSize = true;
            this.lblSelectColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectColor.ForeColor = System.Drawing.Color.White;
            this.lblSelectColor.Location = new System.Drawing.Point(3, 106);
            this.lblSelectColor.Name = "lblSelectColor";
            this.lblSelectColor.Size = new System.Drawing.Size(336, 39);
            this.lblSelectColor.TabIndex = 4;
            this.lblSelectColor.Text = "Seleccione Color de Fondo";
            this.lblSelectColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSelectBackColor
            // 
            this.cmbSelectBackColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSelectBackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSelectBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectBackColor.FormattingEnabled = true;
            this.cmbSelectBackColor.Location = new System.Drawing.Point(345, 148);
            this.cmbSelectBackColor.Name = "cmbSelectBackColor";
            this.cmbSelectBackColor.Size = new System.Drawing.Size(336, 30);
            this.cmbSelectBackColor.TabIndex = 5;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPageNumber.Location = new System.Drawing.Point(3, 226);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(336, 31);
            this.txtPageNumber.TabIndex = 6;
            this.txtPageNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageNumber_KeyPress);
            // 
            // btnGoToPage
            // 
            this.btnGoToPage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGoToPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToPage.FlatAppearance.BorderSize = 0;
            this.btnGoToPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnGoToPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnGoToPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToPage.Location = new System.Drawing.Point(345, 226);
            this.btnGoToPage.Name = "btnGoToPage";
            this.btnGoToPage.Size = new System.Drawing.Size(336, 37);
            this.btnGoToPage.TabIndex = 7;
            this.btnGoToPage.Text = "Ir a Página";
            this.btnGoToPage.UseVisualStyleBackColor = false;
            this.btnGoToPage.Click += new System.EventHandler(this.btnGoToPage_Click);
            // 
            // txtZoomFactor
            // 
            this.txtZoomFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZoomFactor.Location = new System.Drawing.Point(687, 226);
            this.txtZoomFactor.Name = "txtZoomFactor";
            this.txtZoomFactor.Size = new System.Drawing.Size(336, 31);
            this.txtZoomFactor.TabIndex = 8;
            this.txtZoomFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZoomFactor_KeyPress);
            // 
            // btnUpdateZoomFactor
            // 
            this.btnUpdateZoomFactor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateZoomFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateZoomFactor.FlatAppearance.BorderSize = 0;
            this.btnUpdateZoomFactor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdateZoomFactor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnUpdateZoomFactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateZoomFactor.Location = new System.Drawing.Point(1029, 226);
            this.btnUpdateZoomFactor.Name = "btnUpdateZoomFactor";
            this.btnUpdateZoomFactor.Size = new System.Drawing.Size(338, 37);
            this.btnUpdateZoomFactor.TabIndex = 9;
            this.btnUpdateZoomFactor.Text = "% Zoom";
            this.btnUpdateZoomFactor.UseVisualStyleBackColor = false;
            this.btnUpdateZoomFactor.Click += new System.EventHandler(this.btnUpdateZoomFactor_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchText.Location = new System.Drawing.Point(3, 186);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(336, 31);
            this.txtSearchText.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(345, 186);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(336, 34);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Buscar Texto";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(687, 183);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(336, 40);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tltVentana
            // 
            this.tltVentana.IsBalloon = true;
            this.tltVentana.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmMostraModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.crptReporteContenedor);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostraModulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "103 - Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReporteadorNavegador_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptReporteContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.ListBox lbxListCRVReport;
        private System.Windows.Forms.Label lblToolbar;
        private System.Windows.Forms.Button btnRedisplay;
        private System.Windows.Forms.Label lblSelectColor;
        private System.Windows.Forms.ComboBox cmbSelectBackColor;
        private System.Windows.Forms.Button btnGoToPage;
        private System.Windows.Forms.TextBox txtZoomFactor;
        private System.Windows.Forms.Button btnUpdateZoomFactor;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ToolTip tltVentana;
    }
}