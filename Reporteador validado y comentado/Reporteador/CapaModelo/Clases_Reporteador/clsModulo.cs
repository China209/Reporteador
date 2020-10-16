using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Metodo para retornar los datos para del modulo 
namespace CapaModelo.Clases_Reporteador
{
    public class clsModulo
    {
        private int iIdModulo;  // variable para el id modulo 
        private string sNombre;  // variable para el nombre
        private string sDescripcion; // variable para la descripcion 
        private int iEstado; // variable para el estado 

        // metodos get y set 
        public int IIdModulo { get => iIdModulo; set => iIdModulo = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
