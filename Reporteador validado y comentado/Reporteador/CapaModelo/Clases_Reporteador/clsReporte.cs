using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Metodo para retornar los datos para el reporte 
namespace CapaModelo.Clases_Reporteador
{
    public class clsReporte
    {
        private int iIdReporte;  // variable para el id reporte 
        private string sNombre;// variable para el nombre
        private string sRuta; // variable para la descripcion 
        private int iEstado;  // variable para el estado 

        // metodos get y set 
        public int IIdReporte { get => iIdReporte; set => iIdReporte = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SRuta { get => sRuta; set => sRuta = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
