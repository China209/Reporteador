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
    public class clsControlModulo
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la clase conexion 
        DataTable tabla; // variable tipo DataTable 
        OdbcDataAdapter datos; // Variable OdbcDataAdapter

        // Metodo para insertar datos en el modulo 
        public void insertarModulos(clsModulo modulo)
        {
            try
            {
                string sComando = string.Format("INSERT INTO MODULO(nombre_modulo, descripcion_modulo, estado_modulo) VALUES ('{0}','{1}',{2});", modulo.SNombre, modulo.SDescripcion, modulo.IEstado);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // metodos para modificar los datos en el modulo 
        public void modificarModulos(clsModulo modulo)
        {
            try
            {
                string sComando = string.Format("UPDATE MODULO SET nombre_modulo='{1}', descripcion_modulo='{2}' WHERE pk_id_modulo={0};", modulo.IIdModulo, modulo.SNombre, modulo.SDescripcion);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // metodos para eliminar por id en la tabla modulo 
        public void eliminarModulos(int iIDModulo)
        {
            try
            {
                string sComando = string.Format("UPDATE MODULO SET estado_modulo=0 WHERE pk_id_modulo={0};", iIDModulo.ToString());
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
                string sComando = string.Format("SELECT pk_id_modulo, nombre_modulo, descripcion_modulo FROM MODULO WHERE estado_modulo=1");
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
        public DataTable obtenerDatos(int iIDModulo)
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_modulo, nombre_modulo, descripcion_modulo FROM MODULO WHERE estado_modulo=1 AND pk_id_modulo={0};", iIDModulo.ToString());
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

        // Metodo para busqueda de datos en el combo box 
        public DataTable obtenerCamposCombobox()
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_modulo, nombre_modulo FROM MODULO WHERE estado_modulo=1");
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
