using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Metodo para obtener y recibir los datos de la tabla reporte modulo 

namespace CapaModeloReporteador.Clases_Reporteador
{
    public class clsReporteModulo
    {
        private int iModulo;
        private int iReporte;
        private int iEstado;

        public int IEstado { get => iEstado; set => iEstado = value; }
        public int IModulo { get => iModulo; set => iModulo = value; }
        public int IReporte { get => iReporte; set => iReporte = value; }
    }
}
