/*
 Control de Vista de Reportes por Modulos
*/
using CapaModeloReporteador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorReporteador.ControladoresReporteador
{
    public class clsControlModuloReporte
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la conexion
        private DataTable tabla; // variable tipo Datatable
        private OdbcDataAdapter datos; // variable tipo OdbcDataAdapter
        string sRuta;
        //Metodo para obtener los datos del data table al datagridview
        public DataTable obtenerTodo(int IDModulo)
        {

            try
            {
                string sComando = string.Format("select m.pk_id_modulo as 'Codigo Modulo', m.nombre_modulo as 'Nombre Modulo',r.pk_id_reporte as 'Codigo Reporte', r.nombre_reporte as 'Nombre Reporte', r.ruta_reporte 'Ruta Reporte' from modulo m inner join reporte_modulo rm on "+
                "m.pk_id_modulo = rm.fk_id_modulo inner join reporte r on r.pk_id_reporte = rm.fk_id_reporte where r.estado_reporte = 1 and rm.estado_reporte_modulo = 1 and m.estado_modulo = 1 and m.pk_id_modulo="+IDModulo+";");
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
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
