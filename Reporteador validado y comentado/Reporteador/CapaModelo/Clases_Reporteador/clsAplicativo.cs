using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Metodo para retornar los datos para el aplicativo 
namespace CapaModelo.Clases_Reporteador
{
    public class clsAplicativo
    {
        private int iIdAplicativo; // variable para id aplicativo
        private int iModulo;     // variable para el id modulo 
        private string sNombre;  // variable para el nombre
        private string sDescripcion; // variable para la descripcion
        private int iEstado; // variable para el estado

        // metodos get y set 
        public int IIdAplicativo { get => iIdAplicativo; set => iIdAplicativo = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
        public int IModulo { get => iModulo; set => iModulo = value; }
    }
}
