using CapaControlador.ControladoresReporteador;
using CapaModelo.Clases_Reporteador;
using CapaVista.Reporteador_Navegador;
using Prototipo_No_Funcional.MDI;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmGestorReportes : Form
    {
        private clsReporte reportes;
        private string sRutaArchivo,sNombreAux,sRutaAux;
        private int iIDAux;
        private clsControlReportes controlReportes = new clsControlReportes();
        public frmGestorReportes()
        {
            InitializeComponent();
            cargarDatos();
            BloquearBotones();
            CargarCombobox();
        }

        private void CargarCombobox()
        {
            cmbBuscar.DisplayMember = "nombre_reporte";
            cmbBuscar.ValueMember = "pk_id_reporte";
            cmbBuscar.DataSource = controlReportes.obtenerCamposCombobox();
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }

        private void cargarDatos()
        {
            dgvVistaDatos.DataSource=controlReportes.obtenerTodo();
        }
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnVerReporte.Enabled = false;
            btnGuardar.Enabled = true;
        }
        private clsReporte llenarCampos()
        {
            clsReporte auxReporte = new clsReporte();
            auxReporte.SNombre = txtNombre.Text;
            auxReporte.SRuta = txtRuta.Text;
            auxReporte.IEstado = 1;
            return auxReporte;
        }

        private void LimpiarComponentes()
        {
            txtNombre.Text = "";
            txtRuta.Text = "";
            cmbBuscar.SelectedIndex = -1;
            txtNombre.Focus();
        }
        private clsReporte ObtenerModificaciones()
        {
            clsReporte auxReporte = new clsReporte();
            auxReporte.SNombre = txtNombre.Text;
            auxReporte.SRuta = txtRuta.Text;
            auxReporte.IIdReporte = iIDAux;
            return auxReporte;
        }

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

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

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

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasReporteador/AyudasObjetoReporteador.chm", "GestorReportes.html");
        }

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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCombobox();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            frmReporteadorNavegador reporteadorNavegador = new frmReporteadorNavegador(iIDAux);
            reporteadorNavegador.Show();
            if (!reporteadorNavegador.IsDisposed)
            {
                BloquearBotones();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        private void cmsMostrar_Click(object sender, EventArgs e)
        {
            btnVerReporte.Enabled = true;
        }

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

        private void cmsModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Text = sNombreAux;
            txtRuta.Text = sRutaAux;
        }
    }
}
