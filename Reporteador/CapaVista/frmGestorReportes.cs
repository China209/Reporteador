using CapaControladorReporteador.ControladoresReporteador;
using CapaModeloReporteador.Clases_Reporteador;
using CapaVistaReporteador.Reporteador_Navegador;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaVistaReporteador
{
    public partial class frmGestorReportes : Form
    {
        private clsReporte reportes;
        private string sRutaArchivo,sNombreAux,sRutaAux;
        private int iIDAux,iIDApp;
        private clsControlReportes controlReportes = new clsControlReportes();

        // metodos para manejar los datos 
        public frmGestorReportes()
        {
            InitializeComponent();
            cargarDatos();
            BloquearBotones();
            CargarCombobox();
        }

        // metodos para la busqueda por combo box 
        private void CargarCombobox()
        {
            cmbBuscar.DisplayMember = "nombre_reporte";
            cmbBuscar.ValueMember = "pk_id_reporte";
            cmbBuscar.DataSource = controlReportes.obtenerCamposCombobox();
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }

        // cargar los datos desde el data grid 
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource=controlReportes.obtenerTodo();
        }

        // metodo para bloquear botones modificar y ver reporte 
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnVerReporte.Enabled = false;
            btnGuardar.Enabled = true;
        }

        // metodo para retornar los datos 
        private clsReporte llenarCampos()
        {
            clsReporte auxReporte = new clsReporte();
            auxReporte.SNombre = txtNombre.Text;
            auxReporte.SRuta = txtRuta.Text;
            auxReporte.IEstado = 1;
            return auxReporte;
        }

        // metodo para limpiar los componentes 
        private void LimpiarComponentes()
        {
            txtNombre.Text = "";
            txtRuta.Text = "";
            cmbBuscar.SelectedIndex = -1;
            txtNombre.Focus();
        }

        // metodos para retornar los datos en una modificacion 
        private clsReporte ObtenerModificaciones()
        {
            clsReporte auxReporte = new clsReporte();
            auxReporte.SNombre = txtNombre.Text;
            auxReporte.SRuta = txtRuta.Text;
            auxReporte.IIdReporte = iIDAux;
            return auxReporte;
        }

        // metodos para validar los datos insertados 
        private bool guardarDatos()
        {
            this.reportes = llenarCampos();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlReportes.insertarReportes(this.reportes);
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

        //Metodo para seleccionar el reporte 
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string[] sNombre;
            OpenFileDialog ofdArchivo = new OpenFileDialog();
            ofdArchivo.Multiselect = false;
            ofdArchivo.Filter = "reportes|*.rpt";
            DialogResult drResultado = ofdArchivo.ShowDialog();

            if (drResultado == DialogResult.OK)
            {
                this.sRutaArchivo = ofdArchivo.FileName.ToString();
                sNombre = this.sRutaArchivo.Split('\\');
                txtRuta.Text = sNombre[sNombre.Length - 1];
            }
        }

        // metodo para validar las modificaciones 
        private bool ModificarDatos()
        {
            this.reportes = ObtenerModificaciones();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlReportes.modificarReportes(this.reportes);
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

        // metodo para limpiar los atributos cuando ocurre una modificación 
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

        //visualizar los datos en el datagrid 
        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_reporte"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_reporte"].Value.ToString();
                sRutaAux = dgvVistaDatos.Rows[e.RowIndex].Cells["ruta_reporte"].Value.ToString();
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }

        //metodo para visualizar la hora y la fecha actual 
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        //valida la salida del formulario 
        private void frmGestorReportes_FormClosing(object sender, FormClosingEventArgs e)
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

        // validar todos los campos en el formulario 
        private bool ValidarTextbox()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            else if (txtRuta.Text == "")
            {
                MessageBox.Show("Ingrese Ruta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtNombre.Text == "" && txtRuta.Text == "")
            {
                MessageBox.Show("Llene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarComponentes();
                return false;
            }
            return true;

        }
        // boton para salir de la apllicación 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                
            }
        }

        // boton para visualizar las ayudas al usuario 
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasReporteador/AyudasObjetoReporteador.chm", "GestorReportes.html");
        }

        // metodo par ala busqueda de datos en el commbo 
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex >= 0)
            {
                int iIDAux = int.Parse(cmbBuscar.SelectedValue.ToString());
                dgvVistaDatos.DataSource = controlReportes.obtenerDatos(iIDAux);
            }
            else if (cmbBuscar.SelectedIndex < 0)
            {
                cargarDatos();
            }
        }

        // metodo para cargar losd atos en el combobox 
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCombobox();
        }

        // metodo para visualizar el reporte 
        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            iIDApp = controlReportes.obtenerIDApp(iIDAux);
            frmReporteadorNavegador reporteadorNavegador = new frmReporteadorNavegador(iIDApp);
            reporteadorNavegador.Show();
            if (!reporteadorNavegador.IsDisposed)
            {
                BloquearBotones();
            }
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
        private void cmsMostrar_Click(object sender, EventArgs e)
        {
            btnVerReporte.Enabled = true;
        }

        // metodo para eliminar desde el datagrid 
        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgMensaje = MessageBox.Show("Una vez eliminados estos datos no se podrán recuperar, ¿Desea Continuar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMensaje == DialogResult.Yes)
                {
                    this.controlReportes.eliminarReportes(iIDAux);
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

        // metodo para modificar desde el data grid 
        private void cmsModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Text = sNombreAux;
            txtRuta.Text = sRutaAux;
        }
    }
}
