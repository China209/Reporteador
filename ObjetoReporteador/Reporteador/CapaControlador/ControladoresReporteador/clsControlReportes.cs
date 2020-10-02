using CapaModelo;
using CapaModelo.Clases_Reporteador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace CapaControlador.ControladoresReporteador
{
    public class clsControlReportes
    {
        clsSentencia sentencia=new clsSentencia();
        clsConexion conexion = new clsConexion();
        DataTable tabla;
        OdbcDataAdapter datos;
        public void insertarReportes(clsReporte reporte)
        {
            try
            {
                string sComando = string.Format("INSERT INTO REPORTE(nombre_reporte, ruta_reporte, estado_reporte) VALUES ('{0}','{1}',{2});", reporte.SNombre, reporte.SRuta, reporte.IEstado);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }
        public void modificarReportes(clsReporte reporte)
        {
            try
            {
                string sComando = string.Format("UPDATE REPORTE SET nombre_reporte='{1}', ruta_reporte='{2}' WHERE pk_id_reporte={0};", reporte.IIdReporte, reporte.SNombre, reporte.SRuta);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        public void eliminarReportes(int iIDReporte)
        {
            try
            {
                string sComando = string.Format("UPDATE REPORTE SET estado_reporte=0 WHERE pk_id_reporte={0};", iIDReporte.ToString());
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        public DataTable obtenerTodo()
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_reporte, nombre_reporte, ruta_reporte FROM REPORTE WHERE estado_reporte=1");
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
        public DataTable obtenerDatos(int iIDReporte)
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_reporte, nombre_reporte, ruta_reporte FROM REPORTE WHERE estado_reporte=1 AND pk_id_reporte={0};", iIDReporte.ToString());
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
        public DataTable obtenerCamposCombobox()
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_reporte, nombre_reporte FROM REPORTE WHERE estado_reporte=1");
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
