using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// metodo para retornar datos del aplicativo y asi obtenerlos y enviar los datos a la BD
namespace CapaModeloReporteador.Clases_Reporteador
{
    public class clsAplicativo
    {
        private int iIdAplicativo;
        private int iModulo;
        private string sNombre;
        private string sDescripcion;
        private int iEstado;

        public int IIdAplicativo { get => iIdAplicativo; set => iIdAplicativo = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
        public int IModulo { get => iModulo; set => iModulo = value; }
    }
}
