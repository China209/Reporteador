using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Reporteador
{
    public class clsReporteAplicativo
    {
        private clsReporte Reporte;
        private clsAplicativo Aplicativo;
        private clsModulo Modulo;
        private int iEstado;

        public int IEstado { get => iEstado; set => iEstado = value; }
        internal clsReporte Reporte1 { get => Reporte; set => Reporte = value; }
        internal clsAplicativo Aplicativo1 { get => Aplicativo; set => Aplicativo = value; }
        internal clsModulo Modulo1 { get => Modulo; set => Modulo = value; }
    }
}
