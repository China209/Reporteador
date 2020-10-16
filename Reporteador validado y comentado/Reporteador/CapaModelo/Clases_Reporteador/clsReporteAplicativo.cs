using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Metodo para retornar los datos para el reporte por aplicativo 
namespace CapaModelo.Clases_Reporteador
{
    public class clsReporteAplicativo
    {
        private clsReporte Reporte;  // retornar los valores del reporte 
        private clsAplicativo Aplicativo; // retornar los calores del aplicativo 
        private clsModulo Modulo; // retornar los valores del modulo 
        private int iEstado; // variable para el estado 

        // metodos get y set 
        public int IEstado { get => iEstado; set => iEstado = value; }
        internal clsReporte Reporte1 { get => Reporte; set => Reporte = value; }
        internal clsAplicativo Aplicativo1 { get => Aplicativo; set => Aplicativo = value; }
        internal clsModulo Modulo1 { get => Modulo; set => Modulo = value; }
    }
}
