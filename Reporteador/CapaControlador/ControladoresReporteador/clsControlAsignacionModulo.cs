using CapaModeloReporteador;
using CapaModeloReporteador.Clases_Reporteador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorReporteador.ControladoresReporteador
{
    public class clsControlAsignacionModulo
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la clase conexion 
        DataTable tabla; // variable tipo Datatable
        OdbcDataAdapter datos; // variable tipo OdbcDataAdapter


        // Metodo para insertar datos en el reporte modulo 
        public void insertarModulos(clsReporteModulo modulo)
        {
            try
            {
                string sComando = string.Format("INSERT INTO REPORTE_MODULO(fk_id_reporte, fk_id_modulo, estado_reporte_modulo) VALUES ('{0}','{1}',{2});", modulo.IReporte, modulo.IModulo, modulo.IEstado);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // metodos para modificar los datos en el reporte modulo 
        public void modificarModulos(clsReporteModulo modulo)
        {
            try
            {
                string sComando = string.Format("UPDATE REPORTE_MODULO SET fk_id_reporte='{1}' WHERE fk_id_modulo={0};", modulo.IModulo, modulo.IReporte);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }


        // metodo para eliminar datos por id  y reporte 
        public void eliminarModulos(int iIDModulo,int iIDReporte)
        {
            try
            {
                string sComando = string.Format("UPDATE REPORTE_MODULO SET estado_reporte_modulo=0 WHERE fk_id_modulo={0} AND fk_id_reporte={1};", iIDModulo.ToString(),iIDReporte.ToString());
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        //Metodo para obtener los datos del data table al datagridview
        public DataTable obtenerTodo()
        {
            try
            {
                string sComando = string.Format("SELECT fk_id_reporte, fk_id_modulo FROM REPORTE_MODULO WHERE estado_reporte_modulo=1");
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


        // Metodo para busqueda de datos 
        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstado)
        {
            try
            {
                string sComando = string.Format("SELECT "+sCampo1+","+ sCampo2+" FROM "+sTabla+ " WHERE "+sEstado+"=1");
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
