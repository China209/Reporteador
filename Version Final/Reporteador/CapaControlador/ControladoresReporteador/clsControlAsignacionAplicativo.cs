/*
 Control de Asignacion de Reporte a Aplicacion
 */
using CapaModeloReporteador;
using CapaModeloReporteador.Clases_Reporteador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorReporteador.ControladoresReporteador
{
    public class clsControlAsignacionAplicativo
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia 
        clsConexion conexion = new clsConexion(); // instanciar la clase conexion
        DataTable tabla; // variable tipo data table 
        OdbcDataAdapter datos; // variable tipo OdbcDataAdapter 


        // Metodo para insertar datos en en el reporte aplicativo 
        public void insertarModulos(clsReporteAplicativo modulo)
        {
            try
            {
                string sComando = string.Format("INSERT INTO REPORTE_APLICATIVO(fk_id_reporte, fk_id_aplicacion, fk_id_modulo, estado_reporte_aplicativo) VALUES ({0},{1},{2},{3});", modulo.IReporte, modulo.IAplicativo, modulo.IModulo, modulo.IEstado);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // metodo para modificar datos en el reporte aplicativo 
        public void modificarModulos(clsReporteAplicativo modulo)
        {
            try
            {
                string sComando = string.Format("UPDATE REPORTE_APLICATIVO SET fk_id_reporte='{1}', fk_id_modulo='{2}' WHERE fk_id_aplicacion={0};", modulo.IAplicativo, modulo.IReporte,modulo.IModulo);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // Metodo para eliminar los datos en el reporte aplicativo 
        public void eliminarModulos(int iIDModulo, int iIDReporte)
        {
            try
            {
                string sComando = string.Format("UPDATE REPORTE_APLICATIVO SET estado_reporte_aplicativo=0 WHERE fk_id_aplicacion={0} AND fk_id_reporte={1};", iIDModulo.ToString(), iIDReporte.ToString());
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
                string sComando = string.Format("SELECT fk_id_reporte, fk_id_aplicacion, fk_id_modulo FROM REPORTE_APLICATIVO WHERE estado_reporte_aplicativo=1");
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
         
        // metodo para obtener los datos los datos para el combo box 
        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstado)
        {
            try
            {
                string sComando = string.Format("SELECT " + sCampo1 + "," + sCampo2 + " FROM " + sTabla + " WHERE " + sEstado + "=1");
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
        public bool verificarExistencias(int IDReporte, int IDModulo, int IDApp)
        {
            string datos = "";
            try
            {
                string sComando = "select estado_reporte_aplicativo from reporte_aplicativo where fk_id_reporte=" + IDReporte + " and fk_id_modulo=" + IDModulo + " and fk_id_aplicacion ="+IDApp+";";
                OdbcCommand comando = new OdbcCommand(sComando, conexion.conexion());
                OdbcDataReader registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    datos = registro["estado_reporte_aplicativo"].ToString();
                }
                if (datos.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de reportes");
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
