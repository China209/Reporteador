using CapaControladorReporteador.ControladoresReporteador;
using CapaModeloReporteador.Reporteador_Nav;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Drawing;
using System.Windows.Forms;

 // Se podra manejar todo que tiene que ver con la visualizacion del reporte desde 
 //agregarle zoom hasta buscar una palabra en especifico
 // Si la ruta del reporte no es correcta del igual forma se desplegara el navegador del reporte
 // Visualiza de acuerdo con los reportes asignados al modulo

namespace CapaVistaReporteador.ReportesModulos
{
    public partial class frmMostraModulos : Form
    {
        ReportDocument rdocReporte = new ReportDocument();
        public frmMostraModulos(string Ruta)
        {
            InitializeComponent();
            if (Ruta!="")
            {
                MostrarReporte(Ruta);
                lbxListCRVReport.DataSource = System.Enum.GetValues(typeof(clsCeWinCRVReportOptions));
                lbxListCRVReport.DataSource = System.Enum.GetValues(typeof(clsCeWinCRVToolbarOptions));
                cmbSelectBackColor.DataSource = System.Enum.GetValues(typeof(KnownColor));
                
            }
            else
            {
                MessageBox.Show("Error no existe la ruta, verifique que este reporte este asociado a una aplicación", "");
                DeshabilitarComponentes();
            }
            tltVentana.SetToolTip(btnGoToPage, "Buscar la página del reporte y le direcciona hacia ella");
            tltVentana.SetToolTip(btnRedisplay, "Muestra las opciones de la barra de tareas del reporte");
            tltVentana.SetToolTip(btnSearch, "Búsqueda de palabra dentro del reporte");
            tltVentana.SetToolTip(btnUpdateZoomFactor, "Zoom del reporte");
        }

        private void MostrarReporte(string Ruta)
        {
            try
            {
                rdocReporte = new ReportDocument();
                rdocReporte.Load(Ruta);
                crptReporteContenedor.ReportSource = rdocReporte;
                crptReporteContenedor.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Path de ruta inválido, revise la localización del reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DeshabilitarComponentes();
            }
        }

        private void DeshabilitarComponentes()
        {
            txtPageNumber.Enabled = false;
            txtSearchText.Enabled = false;
            txtZoomFactor.Enabled = false;
            btnGoToPage.Enabled = false;
            btnRedisplay.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdateZoomFactor.Enabled = false;
            lbxListCRVReport.Enabled = false;
            cmbSelectBackColor.Enabled = false;
        }

        private void btnRedisplay_Click(object sender, System.EventArgs e)
        {
            crptReporteContenedor.ShowPageNavigateButtons = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Page_Navigation_Button));
            crptReporteContenedor.ShowGotoPageButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Go_to_Page_Button));
            crptReporteContenedor.ShowCloseButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Close_View_Button));
            crptReporteContenedor.ShowPrintButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Print_Button));
            crptReporteContenedor.ShowRefreshButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Refresh_Button));
            crptReporteContenedor.ShowExportButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Export_Button));
            crptReporteContenedor.ShowGroupTreeButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Group_Tree_Button));
            crptReporteContenedor.ShowZoomButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Zoom_Button));
            crptReporteContenedor.ShowTextSearchButton = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVToolbarOptions.Search_Button));

            crptReporteContenedor.DisplayToolbar = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVReportOptions.Toolbar));
            crptReporteContenedor.DisplayGroupTree = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVReportOptions.Group_Tree));
            crptReporteContenedor.DisplayStatusBar = lbxListCRVReport.GetSelected(Convert.ToInt32(clsCeWinCRVReportOptions.Status_Bar));

            crptReporteContenedor.BackColor = Color.FromName(cmbSelectBackColor.SelectedItem.ToString());

            KnownColor selectedKnownColor = (KnownColor)cmbSelectBackColor.SelectedItem;
            if (selectedKnownColor != KnownColor.Transparent)
            {
                crptReporteContenedor.BackColor = System.Drawing.Color.FromKnownColor(selectedKnownColor);
            }
        }

        private void btnGoToPage_Click(object sender, EventArgs e)
        {
            if (txtPageNumber.Text != "")
            {
                crptReporteContenedor.ShowNthPage(Convert.ToInt32(txtPageNumber.Text));
                txtPageNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese el número de página al que desea ir", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPageNumber.Focus();
            }
            
        }

        private void btnUpdateZoomFactor_Click(object sender, EventArgs e)
        {
            if (txtZoomFactor.Text != "")
            {
                crptReporteContenedor.Zoom(Convert.ToInt32(txtZoomFactor.Text));
                txtZoomFactor.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese el número de zoom", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPageNumber.Focus();
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchText.Text != "")
            {
                bool searchResult = crptReporteContenedor.SearchForText(txtSearchText.Text);
                if (searchResult)
                {
                    lblMessage.Text = clsMessageConstants.SUCCESS;
                    txtSearchText.Text = "";
                }
                else
                {
                    lblMessage.Text = clsMessageConstants.FAILURE;
                    txtSearchText.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese el dato que desea buscar", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPageNumber.Focus();
            }
            

        }

        private void frmReporteadorNavegador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtPageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }

        private void txtZoomFactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }
    }
}
