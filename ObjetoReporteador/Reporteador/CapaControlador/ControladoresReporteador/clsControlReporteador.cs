using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador.ControladoresReporteador
{
    public class clsControlReporteador
    {
        clsSentencia sentencia = new clsSentencia();
        clsConexion conexion = new clsConexion();
        private string sRuta;
        public string obtenerRutaApp(int iID)
        {
            try
            {
                string sComando = "select r.ruta_reporte from reporte r inner join reporte_aplicativo a on r.pk_id_reporte=a.fk_id_reporte where fk_id_aplicativo =" + iID;
                OdbcCommand comando = new OdbcCommand(sComando, conexion.conexion());
                OdbcDataReader registro = comando.ExecuteReader();


                while (registro.Read())
                {
                    sRuta = registro["ruta_reporte"].ToString();
                }
                return sRuta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
