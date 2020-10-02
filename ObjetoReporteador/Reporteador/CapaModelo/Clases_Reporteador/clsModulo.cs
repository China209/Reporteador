using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Reporteador
{
    public class clsModulo
    {
        private int iIdModulo;
        private string sNombre;
        private string sDescripcion;
        private int iEstado;

        public int IIdModulo { get => iIdModulo; set => iIdModulo = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
