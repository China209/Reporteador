/*
 Muestra los reportes por modulo y permite visualizarlos en una ventana emergente
 */
using CapaControladorReporteador.ControladoresReporteador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaReporteador.ReportesModulos
{
    public partial class frmReportesModulos : Form
    {
        clsControlModuloReporte controlModuloReporte = new clsControlModuloReporte();
        int IDModuloAux;
        string RutaReporte;
        public frmReportesModulos(int IDModulo)
        {
            InitializeComponent();
            this.IDModuloAux = IDModulo;
            if (IDModulo >= 1)
            {
                cargarGrid();
            }
            tltVentana.SetToolTip(dgvReportes, "Seleccione el reporte que desea ver");
        }

        private void cargarGrid()
        {
            dgvReportes.DataSource=controlModuloReporte.obtenerTodo(this.IDModuloAux);
        }

        private void mostrarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostraModulos mostraModulos = new frmMostraModulos(RutaReporte);
            mostraModulos.Show();
        }

        private void dgvReportes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvReportes.Rows[e.RowIndex].Cells["Codigo Modulo"].Value == null)
                {
                    MessageBox.Show("Esta fila no posee datos");
                }
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        this.RutaReporte = dgvReportes.Rows[e.RowIndex].Cells["Ruta Reporte"].Value.ToString();
                        this.cmsMostrar.Show(this.dgvReportes, e.Location);
                        cmsMostrar.Show(Cursor.Position);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se puede seleccionar una fila sin datos", "ADVERTENCIA");
            }
            
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
