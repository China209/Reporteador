using System;
using System.Windows.Forms;
using CapaVistaReporteador;
using CapaVistaReporteador.Mantenimientos;
using CapaVistaReporteador.ReportesModulos;

namespace Pruebas2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuReporteador());
        }
    }
}
//