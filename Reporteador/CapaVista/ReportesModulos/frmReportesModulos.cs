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
            if (e.Button == MouseButtons.Right)
            {
                this.RutaReporte = dgvReportes.Rows[e.RowIndex].Cells["Ruta Reporte"].Value.ToString();
                this.cmsMostrar.Show(this.dgvReportes, e.Location);
                cmsMostrar.Show(Cursor.Position);
            }
        }
    }
}
