using System;
using CapaControlador.ControladoresReporteador;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo.Clases_Reporteador;
using System.Text.RegularExpressions;

namespace CapaVista.Mantenimientos
{
    public partial class frmAplicativo : Form
    {
        private clsAplicativo aplicativo;
        private string sNombreAux, sDescAux;
        private int iIDAux, iIDModAux;
        clsControlAplicativo controlAplicativo=new clsControlAplicativo();

        // metodos publicos para el manejo de los datos
        public frmAplicativo()
        {
            InitializeComponent();
            CargarCombobox();
            cargarDatos();
            CargarBusqueda();
            BloquearBotones();
        }

        // cargo todos los datos  necesarios para el aplicativo
        private void CargarCombobox()
        {
            cmbModulo.DisplayMember = "nombre_modulo";
            cmbModulo.ValueMember = "pk_id_modulo";
            cmbModulo.DataSource = controlAplicativo.obtenerCamposCombobox("pk_id_modulo","nombre_modulo","MODULO","estado_modulo");
            cmbModulo.SelectedIndex = -1;
        }

        // carga todos los datos para la busqueda
        private void CargarBusqueda()
        {
            cmbBuscar.DisplayMember = "nombre_aplicativo";
            cmbBuscar.ValueMember = "pk_id_aplicativo";
            cmbBuscar.DataSource = controlAplicativo.obtenerCamposCombobox("pk_id_aplicativo","nombre_aplicativo","APLICATIVO","estado_aplicativo");
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }

        // carga todos los datos para el DataGriview
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlAplicativo.obtenerTodo();
        }

        // Bloquea los botones cuando es necesario
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }


        // Retorna todos los datos ingresados 
        private clsAplicativo llenarCampos()
        {
            clsAplicativo auxAplicativo = new clsAplicativo();
            auxAplicativo.SNombre = txtNombre.Text;
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IModulo = int.Parse(cmbModulo.SelectedValue.ToString());
            auxAplicativo.IEstado = 1;
            return auxAplicativo;
        }

        // Limpia todos los componentes en el formulario
        private void LimpiarComponentes()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cmbModulo.SelectedIndex = -1;
            txtNombre.Focus();
        }

        // Obtiene todos los datos por si hubo alguna modificacion 
        private clsAplicativo ObtenerModificaciones()
        {
            clsAplicativo auxAplicativo = new clsAplicativo();
            auxAplicativo.SNombre = txtNombre.Text;
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IModulo = int.Parse(cmbModulo.SelectedValue.ToString());
            auxAplicativo.IIdAplicativo = iIDAux;
            return auxAplicativo;
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

        
        // Llevamos todos los datos a guardar y validamos si el proceso fue éxitoso
        private bool guardarDatos()
        {
            this.aplicativo = llenarCampos();
            try
            {
                controlAplicativo.insertarAplicativo(this.aplicativo);
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
            this.aplicativo = ObtenerModificaciones();
            try
            {
                controlAplicativo.modificarAplicativo(this.aplicativo);
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

        // Limpia todos los campos al modificar algun dato
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

        
        //Eliminar el campo seleccionado
        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgMensaje = MessageBox.Show("Una vez eliminados estos datos no se podrán recuperar, ¿Desea Continuar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMensaje == DialogResult.Yes)
                {

                    this.controlAplicativo.eliminarAplicativo(iIDAux);
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

        // Calcula la hora y fecha actual
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        // Validacion para la salir
        private void frmAplicativo_FormClosing(object sender, FormClosingEventArgs e)
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
            Help.ShowHelp(this, "AyudasReporteador/AyudasObjetoReporteador.chm", "Aplicativo.html");
        }

        // metodo de busqueda en el combo box
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex >= 0)
            {
                int iIDAux = int.Parse(cmbBuscar.SelectedValue.ToString());
                dgvVistaDatos.DataSource = controlAplicativo.obtenerDatos(iIDAux);
            }
            else if (cmbBuscar.SelectedIndex < 0)
            {
                cargarDatos();
            }
        }

        // Cargar la busqueda
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarBusqueda();
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

        private void dgvVistaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Visuliza todos los datos en el datagriview
        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_aplicativo"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_aplicativo"].Value.ToString();
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["descripcion_aplicativo"].Value.ToString();
                iIDModAux=int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["fk_id_modulo"].Value.ToString());
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
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
    }
}
