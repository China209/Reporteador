using CapaVistaReporteador;
using CapaVistaReporteador.Mantenimientos;
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

        // boton para mostrar el gestor reporte 
        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmGestorReportes reporte = new frmGestorReportes();
            //this.Dispose();
            reporte.Show();
        }

        // boton para mostrar el modulo 
        private void btnModulo_Click(object sender, EventArgs e)
        {
            frmModulo modulo = new frmModulo();
          //  this.Dispose();
            modulo.Show();
        }

        // boton para mostrar el aplicativo 
        private void btnApp_Click(object sender, EventArgs e)
        {
            frmAplicativo aplicativo = new frmAplicativo();
            //this.Dispose();
            aplicativo.Show();
        }

        // boton para mostrar el formulario donde se asigna el reporte por modulo 
        private void btnAsigModulo_Click(object sender, EventArgs e)
        {
            frmReporteMod repmod = new frmReporteMod();
            //this.Dispose();
            repmod.Show();
        }

        // valida la salida 
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

        //boton para mostrar el formulario de reporte por aplicación 
        private void btnAsigApp_Click(object sender, EventArgs e)
        {
            frmReporteApp repmod = new frmReporteApp();
            //this.Dispose();
            repmod.Show();
        }
    }
}
