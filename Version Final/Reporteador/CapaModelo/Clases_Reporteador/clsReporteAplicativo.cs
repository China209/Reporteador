using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Metodo para obtener y recibir datos de de la tabla reporte aplicativo 
namespace CapaModeloReporteador.Clases_Reporteador
{
    public class clsReporteAplicativo
    {
        private int iReporte;
        private int iAplicativo;
        private int iModulo;
        private int iEstado;

        public int IEstado { get => iEstado; set => iEstado = value; }
        public int IReporte { get => iReporte; set => iReporte = value; }
        public int IAplicativo { get => iAplicativo; set => iAplicativo = value; }
        public int IModulo { get => iModulo; set => iModulo = value; }
    }
}
