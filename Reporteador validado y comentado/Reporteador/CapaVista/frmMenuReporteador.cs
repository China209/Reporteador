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

        // Muestra la ventana Gestor Reportes
        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmGestorReportes reporte = new frmGestorReportes();
            //this.Dispose();
            reporte.Show();
        }

        //Muestra la ventana modulo 
        private void btnModulo_Click(object sender, EventArgs e)
        {
            frmModulo modulo = new frmModulo();
          //  this.Dispose();
            modulo.Show();
        }

        //Muestra la venta aplicativo
        private void btnApp_Click(object sender, EventArgs e)
        {
            frmAplicativo aplicativo = new frmAplicativo();
            //this.Dispose();
            aplicativo.Show();
        }

        // muestra la ventana reporte por modulo 
        private void btnAsigModulo_Click(object sender, EventArgs e)
        {
            frmReporteMod repmod = new frmReporteMod();
            //this.Dispose();
            repmod.Show();
        }

        // Validación para salir de la aplicación
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
    }
}
