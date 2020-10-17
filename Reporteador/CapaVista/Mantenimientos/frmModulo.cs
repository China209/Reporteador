using CapaControladorReporteador.ControladoresReporteador;
using CapaModeloReporteador.Clases_Reporteador;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaVistaReporteador.Mantenimientos
{
    public partial class frmModulo : Form
    {
        private clsModulo modulo; // instanciar la clase modulo 
        private string sNombreAux, sDescAux; // variables para manejar los datos como nombre y descripcion 
        private int iIDAux; // variable para manejar el id 
        private clsControlModulo controlModulo = new clsControlModulo(); // se crea una nueva clase tipo contro del modulo 

        // metodos para manejar los datos 
        public frmModulo()
        {
            InitializeComponent();
            cargarDatos();
            CargarCombobox();
            BloquearBotones();
           
        }

        // cargar los datos al combo box 
        private void CargarCombobox()
        {
            cmbBuscar.DisplayMember = "nombre_modulo";
            cmbBuscar.ValueMember = "pk_id_modulo";
            cmbBuscar.DataSource = controlModulo.obtenerCamposCombobox();
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }

        // cargar todos los datos 
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlModulo.obtenerTodo();
        }

        // metodo para bloquear botones 
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        // metodo para retornar los datos 
        private clsModulo llenarCampos()
        {
            clsModulo auxModulo = new clsModulo();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SDescripcion = txtDescripcion.Text;
            auxModulo.IEstado = 1;
            return auxModulo;
        }

        // metodo para limpiar los atributos en el formulario 
        private void LimpiarComponentes()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
        }

        // Metodos que retorna los datos cuando hay una modificación 
        private clsModulo ObtenerModificaciones()
        {
            clsModulo auxModulo = new clsModulo();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SDescripcion = txtDescripcion.Text;
            auxModulo.IIdModulo = iIDAux;
            return auxModulo;
        }

        // Metodo para validar el ingreso de los datos si fue correcto o no 
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

        // metodo que validad los datos modificados 
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

        //metodo para visualizar los datos en el datagrid
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

        // metodo par eliminar los datos desde el datagrid 
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


        // metodos para modificar los datos desde el datagrid 
        private void cmsModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Text = sNombreAux;
            txtDescripcion.Text = sDescAux;
        }

        //visualiza la hora y fecha actual 
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        // metodo que valida la salida del formulario 
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

        //metodo para visualizar las ayudas para el usuario 
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasReporteador/AyudasObjetoReporteador.chm", "Modulo.html");
        }

        // metodo para cargar todos los datos 
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCombobox();
        }


        // metodo para la busqueda de datos 
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

        // metodo para validar los atributos en el formularios 
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

        // valida el ingreso de datos permitiendo solo ingresar  letras 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        // valida el ingreso de datos permitiendo solo ingresar  letras 
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetterOrDigit(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        // metodo para limpiar todos los atributos cuando ocurre una modificación 
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
