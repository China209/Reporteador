using CapaVista.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMenuReporteador : Form
    {
        public frmMenuReporteador()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmGestorReportes reporte = new frmGestorReportes();
            //this.Dispose();
            reporte.Show();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            frmModulo modulo = new frmModulo();
          //  this.Dispose();
            modulo.Show();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            frmAplicativo aplicativo = new frmAplicativo();
            //this.Dispose();
            aplicativo.Show();
        }

        private void btnAsigModulo_Click(object sender, EventArgs e)
        {
            frmReporteMod repmod = new frmReporteMod();
            //this.Dispose();
            repmod.Show();
        }

        private void frmMenuReporteador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAsigApp_Click(object sender, EventArgs e)
        {
            frmReporteApp repmod = new frmReporteApp();
            //this.Dispose();
            repmod.Show();
        }
    }
}
