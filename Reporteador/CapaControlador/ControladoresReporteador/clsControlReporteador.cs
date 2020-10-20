using CapaModeloReporteador;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorReporteador.ControladoresReporteador
{
    public class clsControlReporteador
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la clase conexion
        private string sRuta; // variable para la ruta 
        private int iIDRuta;//variable ID

        // variable para la buaqueda de la ruta del reporte 
        public string obtenerRuta(int iID)
        {
            try
            {
                string sComando = "select ruta_reporte from reporte where pk_id_reporte =" + iID;
                OdbcCommand comando = new OdbcCommand(sComando, conexion.conexion());
                OdbcDataReader registro = comando.ExecuteReader();


                while (registro.Read())
                {
                    sRuta= registro["ruta_reporte"].ToString();
                }
                return sRuta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener ruta de reporte");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public int obtenerIDApp(int iID)
        {
            try
            {
                string sComando = "select fk_id_reporte from reporte_aplicativo where fk_id_aplicacion =" + iID;
                OdbcCommand comando = new OdbcCommand(sComando, conexion.conexion());
                OdbcDataReader registro = comando.ExecuteReader();


                while (registro.Read())
                {
                    iIDRuta = int.Parse(registro["fk_id_reporte"].ToString());
                }
                return iIDRuta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
