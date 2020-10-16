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
        public string obtenerRuta(int iID)
        {
            try
            {
                string sComando = "SELECT ruta_reporte FROM REPORTE WHERE estado_reporte=1 AND pk_id_reporte="+iID;
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
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
