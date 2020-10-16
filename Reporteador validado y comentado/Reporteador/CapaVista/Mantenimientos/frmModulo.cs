using CapaControlador.ControladoresReporteador;
using CapaModelo.Clases_Reporteador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class frmModulo : Form
    {
        private clsModulo modulo;
        private string sNombreAux, sDescAux;
        private int iIDAux;
        private clsControlModulo controlModulo = new clsControlModulo();

        // metodos publicos para el manejo de los datos
        public frmModulo()
        {
            InitializeComponent();
            cargarDatos();
            CargarCombobox();
            BloquearBotones();
        }

        // cargar todos los datos  necesarios para el modulo
        private void CargarCombobox()
        {
            cmbBuscar.DisplayMember = "nombre_modulo";
            cmbBuscar.ValueMember = "pk_id_modulo";
            cmbBuscar.DataSource = controlModulo.obtenerCamposCombobox();
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }

        // carga todos los datos para el DataGriview
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlModulo.obtenerTodo();
        }

        // Bloquea los botones cuando es necesario
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        // Retorna todos los datos ingresados
        private clsModulo llenarCampos()
        {
            clsModulo auxModulo = new clsModulo();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SDescripcion = txtDescripcion.Text;
            auxModulo.IEstado = 1;
            return auxModulo;
        }

        // Limpia todos los componentes en el formulario
        private void LimpiarComponentes()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }

        // Obtiene todos los datos por si hubo alguna modificacion
        private clsModulo ObtenerModificaciones()
        {
            clsModulo auxModulo = new clsModulo();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SDescripcion = txtDescripcion.Text;
            auxModulo.IIdModulo = iIDAux;
            return auxModulo;
        }

        // Llevamos todos los datos a guardar y validamos si el proceso fue éxitoso
        private bool guardarDatos()
        {
            this.modulo = llenarCampos();
            try
            {
                controlModulo.insertarModulos(this.modulo);
                cargarDatos();
                MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Al guardar se limpian automaticamente todos los campos
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


        // Metodo para modificacion de datos
        private bool ModificarDatos()
        {
            this.modulo = ObtenerModificaciones();
            try
            {
                controlModulo.modificarModulos(this.modulo);
                cargarDatos();
                MessageBox.Show("Datos Correctamente Modificados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }


        // Visuliza todos los datos en el datagriview
        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_modulo"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_modulo"].Value.ToString();
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["descripcion_modulo"].Value.ToString();
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }

        //Eliminar
        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgMensaje = MessageBox.Show("Una vez eliminado estos datos no se podrán recuperar, ¿Desea Continuar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMensaje == DialogResult.Yes)
                {
                    this.controlModulo.eliminarModulos(iIDAux);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Eliminados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if (dgMensaje == DialogResult.No)
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // Deshabilita los botones de Guardar cuando se realizar la modificacion 
        private void cmsModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Text = sNombreAux;
            txtDescripcion.Text = sDescAux;
        }

        // Calcula la hora y fecha actual
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        // Validacion para la salir
        private void frmModulo_FormClosing(object sender, FormClosingEventArgs e)
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

        // Muestra las ayudas al usuario
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasReporteador/AyudasObjetoReporteador.chm", "Modulo.html");
        }


        // Cargar la busqueda
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCombobox();
        }

        // metodo de busqueda en el combo box
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex >= 0)
            {
                int iIDAux = int.Parse(cmbBuscar.SelectedValue.ToString());
                dgvVistaDatos.DataSource = controlModulo.obtenerDatos(iIDAux);
            }
            else if (cmbBuscar.SelectedIndex < 0)
            {
                cargarDatos();
            }
        }

        // valida todos los campos en el formulario
        private bool ValidarTextbox()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese Descripción", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            else if (!Regex.Match(txtNombre.Text, @"^[A-Za-z]+([\ A-Za-z]+)*$").Success)
            {
                MessageBox.Show("Datos del campo nombre invalido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            if (txtNombre.Text == "" && txtDescripcion.Text == "")
            {
                MessageBox.Show("Llene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarComponentes();
                return false;
            }
            return true;

        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        //valida que la entrada del teclado solo sean letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        //valida que la entrada del teclado solo sean letras
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }

        }

        // Limpia todos los campos al modificar algun dato y bloquea los botones 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ModificarDatos() == true)
            {
                LimpiarComponentes();
                BloquearBotones();
            }
            else
            {
                LimpiarComponentes();
                BloquearBotones();
            }
        }
    }
}
