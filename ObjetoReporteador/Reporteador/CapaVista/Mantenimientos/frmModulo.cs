
using CapaControlador.ControladoresReporteador;
using CapaModelo.Clases_Reporteador;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class frmModulo : Form
    {
        private clsModulo modulo;
        private string sNombreAux, sDescAux;
        private int iIDAux;
        private clsControlModulo controlModulo = new clsControlModulo();

        public frmModulo()
        {
            InitializeComponent();
            cargarDatos();
            CargarCombobox();
            BloquearBotones();
            ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese la descripción del módulo");
            ttMensaje.SetToolTip(this.txtNombre, "Ingrese la descripción del módulo");
            ttMensaje.SetToolTip(this.cmbBuscar, "Despliega las Opciones de Búsqueda de Campos");
            ttMensaje.SetToolTip(this.btnAyuda, "Accede a una ventana que explica el funcionamiento del formulario");
            ttMensaje.SetToolTip(this.btnGuardar, "Guarda los datos que ingresó");
            ttMensaje.SetToolTip(this.btnModificar, "Guarda los cambios de datos previamente seleccionados que usted modificó");
            ttMensaje.SetToolTip(this.btnRefrescar, "Actualiza las opciones de Datos a Buscar y Muestra todos los datos del Grid");
        }

        private void CargarCombobox()
        {
            cmbBuscar.DisplayMember = "nombre_modulo";
            cmbBuscar.ValueMember = "pk_id_modulo";
            cmbBuscar.DataSource = controlModulo.obtenerCamposCombobox();
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlModulo.obtenerTodo();
        }
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }
        private clsModulo llenarCampos()
        {
            clsModulo auxModulo = new clsModulo();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SDescripcion = txtDescripcion.Text;
            auxModulo.IEstado = 1;
            return auxModulo;
        }

        private void LimpiarComponentes()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }
        private clsModulo ObtenerModificaciones()
        {
            clsModulo auxModulo = new clsModulo();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SDescripcion = txtDescripcion.Text;
            auxModulo.IIdModulo = iIDAux;
            return auxModulo;
        }

        private bool guardarDatos()
        {
            this.modulo = llenarCampos();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlModulo.insertarModulos(this.modulo);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

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
        private bool ModificarDatos()
        {
            this.modulo = ObtenerModificaciones();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlModulo.modificarModulos(this.modulo);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Modificados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }

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

        private void cmsModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Text = sNombreAux;
            txtDescripcion.Text = sDescAux;
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

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

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasReporteador/AyudasObjetoReporteador.chm", "Modulo.html");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCombobox();
        }

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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetterOrDigit(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

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
