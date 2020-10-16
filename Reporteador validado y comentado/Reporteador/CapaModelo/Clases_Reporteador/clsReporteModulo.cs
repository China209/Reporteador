using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// metodos para poder manejar los datos de los reportes por modulos 
namespace CapaModelo.Clases_Reporteador
{
    public class clsReporteModulo
    {
        private int iModulo; // variable para el id modulo 
        private int iReporte;// variable para el id reporte 
        private int iEstado;// variable para el estado 

        
        // metodos get y set 
        public int IEstado { get => iEstado; set => iEstado = value; }
        public int IModulo { get => iModulo; set => iModulo = value; }
        public int IReporte { get => iReporte; set => iReporte = value; }
    }
}
