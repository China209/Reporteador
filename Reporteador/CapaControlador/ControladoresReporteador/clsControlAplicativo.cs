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
    public class clsControlAplicativo
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la conexion
        private DataTable tabla; // variable tipo Datatable
        private OdbcDataAdapter datos; // variable tipo OdbcDataAdapter


        // Metodo para insertar datos en el aplicativo 
        public void insertarAplicativo(clsAplicativo aplicativo)
        {
            try
            {
                string sComando = string.Format("INSERT INTO APLICACION(fk_id_modulo, nombre_aplicacion, descripcion_aplicacion, estado_aplicacion) VALUES ({0},'{1}','{2}',{3});", aplicativo.IModulo, aplicativo.SNombre, aplicativo.SDescripcion,aplicativo.IEstado);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }


        // Metodos para modificar el aplicativo 
        public void modificarAplicativo(clsAplicativo aplicativo)
        {
            try
            {
                string sComando = string.Format("UPDATE APLICACION SET fk_id_modulo={1}, nombre_aplicacion='{2}', descripcion_aplicacion='{3}' WHERE pk_id_aplicacion={0};", aplicativo.IIdAplicativo, aplicativo.IModulo, aplicativo.SNombre, aplicativo.SDescripcion);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // Metodo para eliminar el aplicativo 
        public void eliminarAplicativo(int iIDApp)
        {
            try
            {
                string sComando = string.Format("UPDATE APLICATIVO SET estado_aplicacion=0 WHERE pk_id_aplicacion={0};", iIDApp.ToString());
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
                string sComando = string.Format("SELECT  pk_id_aplicacion, fk_id_modulo, nombre_aplicacion, descripcion_aplicacion FROM APLICACION WHERE estado_aplicacion=1");
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

        // Metodo para obtener los datos en el combo box 
        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstado)
        {
            try
            {
                string sComando = string.Format("SELECT "+sCampo1 +" ,"+sCampo2+" FROM "+sTabla+" WHERE "+sEstado+"=1");
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

        // metodos para realizar la busqueda por id 
        public DataTable obtenerDatos(int iIDModulo)
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_aplicacion, fk_id_modulo, nombre_aplicacion, descripcion_aplicacion FROM APLICACION WHERE estado_aplicacion=1 AND pk_id_aplicacion={0};", iIDModulo.ToString());
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
