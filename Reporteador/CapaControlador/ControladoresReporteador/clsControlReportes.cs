/*
Control de Reportes 
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using CapaModeloReporteador;
using CapaModeloReporteador.Clases_Reporteador;

namespace CapaControladorReporteador.ControladoresReporteador
{
    public class clsControlReportes
    {
        clsSentencia sentencia=new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la clase conexion 
        DataTable tabla; // variable tipo datatable
        OdbcDataAdapter datos; // variable tipo OdbcDataAdapter
        private int iIDRuta;//Toma valor de ID reporte

        // Metodo para insertar datos en reporte 
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

        // metodos para modificar datos en el reporte
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

        // metodo para eliminar por medio del id 
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

        //Metodo para obtener los datos del data table al datagridview
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

        // metodo para la busqueda por medio del idreporte 
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

        //Metodo para la busqueda por combobox
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
        public int obtenerIDApp(int iID)
        {
            try
            {
                string sComando = "select fk_id_aplicacion from reporte_aplicativo where fk_id_reporte =" + iID+ " AND estado_reporte_aplicativo=1";
                OdbcCommand comando = new OdbcCommand(sComando, conexion.conexion());
                OdbcDataReader registro = comando.ExecuteReader();


                while (registro.Read())
                {
                    iIDRuta = int.Parse(registro["fk_id_aplicacion"].ToString());
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
