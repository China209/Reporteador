using CapaControladorReporteador.ControladoresReporteador;
using CapaModeloReporteador.Clases_Reporteador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaReporteador.Mantenimientos
{
    public partial class frmReporteApp : Form
    {
        private clsReporteAplicativo modulo; // instanciar la clase reporte aplicativo 
        private int iIDRepAux, iIDAppAux; // variables para manejar los datos de id reporte y id aplicativo 
        clsControlAsignacionAplicativo controlModulo = new clsControlAsignacionAplicativo(); // nueva clase tipo asignacion de aplicativo 


        // metodos para manejar los datos 
        public frmReporteApp()
        {
            InitializeComponent();
            CargarCombobox();
            cargarDatos();
            LimpiarComponentes();
            tltVentana.SetToolTip(cmbAplicativo, "Seleccione la Aplicación a la que desea asignar un reporte");
            tltVentana.SetToolTip(cmbModulo, "Seleccione el Módulo de la Aplicación");
            tltVentana.SetToolTip(cmbReporte, "Seleccione el reporte a asignar");
            tltVentana.SetToolTip(dgvVistaDatos, "Vista de los Datos Existentes");
            tltVentana.SetToolTip(btnAyuda, "Dé click para ver las ayudas correspondientes a este formulario");
            tltVentana.SetToolTip(btnGuardar, "Dé click para guardar los datos");
        }

        //Metodos para la busqueda de datos en el combobox 
        private void CargarCombobox()
        {
            cmbModulo.DisplayMember = "nombre_modulo";
            cmbModulo.ValueMember = "pk_id_modulo";
            cmbModulo.DataSource = controlModulo.obtenerCamposCombobox("pk_id_modulo", "nombre_modulo", "MODULO", "estado_modulo");
            cmbReporte.DisplayMember = "nombre_reporte";
            cmbReporte.ValueMember = "pk_id_reporte";
            cmbReporte.DataSource = controlModulo.obtenerCamposCombobox("pk_id_reporte", "nombre_reporte", "REPORTE", "estado_reporte");
            cmbAplicativo.DisplayMember = "nombre_aplicacion";
            cmbAplicativo.ValueMember = "pk_id_aplicacion";
            cmbAplicativo.DataSource = controlModulo.obtenerCamposCombobox("pk_id_aplicacion", "nombre_aplicacion", "APLICACION", "estado_aplicacion");
            cmbAplicativo.SelectedIndex = -1;
            cmbReporte.SelectedIndex = -1;
            cmbModulo.SelectedIndex = -1;
        }

        // cargar los datos del datagrid 
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlModulo.obtenerTodo();
        }
        private clsReporteAplicativo llenarCampos()
        {
            if (validarIngreso() == true)
            {
                clsReporteAplicativo auxReporteModulo = new clsReporteAplicativo();
                auxReporteModulo.IReporte = int.Parse(cmbReporte.SelectedValue.ToString());
                auxReporteModulo.IModulo = int.Parse(cmbModulo.SelectedValue.ToString());
                auxReporteModulo.IAplicativo = int.Parse(cmbAplicativo.SelectedValue.ToString());
                auxReporteModulo.IEstado = 1;
                return auxReporteModulo;
            }
            else
            {
                clsReporteAplicativo auxReporteModulo = new clsReporteAplicativo();
                auxReporteModulo.IReporte = 0;
                auxReporteModulo.IModulo = 0;
                auxReporteModulo.IAplicativo = 0;
                auxReporteModulo.IEstado = 0;
                return null;
            }
        }

        //limpiar todos los atributos en el formulario 
        private void LimpiarComponentes()
        {
            cmbReporte.SelectedIndex = -1;
            cmbAplicativo.SelectedIndex = -1;
            cmbModulo.SelectedIndex = -1;
        }

        // metodo para validar la insercion de los datos 
        private bool guardarDatos()
        {
            this.modulo = llenarCampos();
            try
            {

                if (modulo == null)
                {
                    return false;
                }
                else
                {
                    int id1 = int.Parse(cmbReporte.SelectedValue.ToString());
                    int id2 = int.Parse(cmbModulo.SelectedValue.ToString());
                    int id3 = int.Parse(cmbAplicativo.SelectedValue.ToString());
                    if (controlModulo.verificarExistencias(id1, id2, id3)==true)
                    {
                        controlModulo.insertarModulos(this.modulo);
                        cargarDatos();
                        MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se puede insertar estos datos se encuentran existentes en el sistema", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        // metodo que limpia los atributos al momento de guardar datos 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (guardarDatos() == true)
            {
                LimpiarComponentes();
            }
            else
            {
                LimpiarComponentes();
            }
        }
        //Validar Ingreso
        private bool validarIngreso()
        {
            if (cmbModulo.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el campo Modulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbModulo.Focus();
                cmbModulo.SelectedIndex = -1;
                return false;
            }
            else if (cmbReporte.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el campo Reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbReporte.Focus();
                cmbReporte.SelectedIndex = -1;
                return false;
            }
            else if (cmbAplicativo.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el campo Aplicación/Aplicativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAplicativo.Focus();
                cmbAplicativo.SelectedIndex = -1;
                return false;
            }
            return true;
        }

        //visualiza la hora y fecha actual 
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        // metodo par eliminar los datos desde el datagrid 
        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgMensaje = MessageBox.Show("Una vez eliminados estos datos no se podrán recuperar, ¿Desea Continuar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMensaje == DialogResult.Yes)
                {

                    this.controlModulo.eliminarModulos(iIDAppAux, iIDRepAux);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Eliminados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgMensaje == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // validar la salida 
        private void frmReporteApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasReporteador/AyudasObjetoReporteador.chm", "AsignarAplicacion.html");
        }

        // visualizar los datos en el datagrid 
        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvVistaDatos.Rows[e.RowIndex].Cells["fk_id_reporte"].Value==null)
                {
                    MessageBox.Show("Esta fila no posee datos");
                }
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        iIDAppAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["fk_id_aplicacion"].Value.ToString());
                        iIDRepAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["fk_id_reporte"].Value.ToString());
                        this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                        cmsEM.Show(Cursor.Position);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se puede seleccionar una fila sin datos", "ADVERTENCIA");
            }
            
            
        }
    }
}
