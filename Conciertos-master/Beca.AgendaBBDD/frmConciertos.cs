using System.Data;
using System.Diagnostics.Contracts;

namespace Conciertos
{
    public partial class frmConciertos : Form
    {
        public frmConciertos()
        {
            InitializeComponent();
        }

        #region Enumerado

        public enum ModoEdicion
        {
            lectura,
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        #endregion

        #region Eventos

        /// <summary>
        /// Evento Load del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            // Cargamos los items de bbdd.
            CargarYConfigurarGrid();

        }

        /// <summary>
        /// Evento KeyPress para controlar que no se puedan escribir caracteres en el tel�fono.
        /// </summary>
        /// <param name="sender">Objeto llamante.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento del bot�n a�adir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnA�adir_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento del bot�n eliminar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool correcto = false;
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea eliminar el concierto?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Conciertos c = ObtenerInformacion();
                correcto = Repositorio.EliminarConcierto(c);

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }

        }

        /// <summary>
        /// Evento del bot�n Modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();

        }

        /// <summary>
        /// Evento click del bot�n guardar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la informaci�n
                Conciertos c = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repositorio.CrearConcierto(c);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repositorio.ModificarConcierto(c);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acci�n se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acci�n, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Nombre, fecha, precio de la entrada y numero de asiento son obligatorios.");
            }

        }

        /// <summary>
        /// Evento click del bot�n Cancelar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("�Est� seguro de que desea salir de la edici�n?", "Confirmaci�n", MessageBoxButtons.YesNo);

            if(respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if(dgvListado.SelectedRows.Count == 1)
                {
                    // Recargamos su informaci�n en el formulario
                    CargarInfoFilaSeleccionadaFormulario(dgvListado.SelectedRows[0]);
                }
            }
        }

        /// <summary>
        /// Evento click de la celda.
        /// Cuando se hace click en una celda se selecciona la fila entera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListado.Rows[e.RowIndex].Selected = true;
        }

        /// <summary>
        /// Evento para cuando una fila cambia de estado en el grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListado_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Para cualquier operaci�n que no sea que ha cambiado la selecci�n de la fila, nos salimos
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Obtenemos la fila seleccionada
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);

        }

        #endregion

        #region M�todos

        /// <summary>
        /// M�todo para establecer el modo de la pantalla a edici�n.
        /// </summary>
        public void ModoPantallaEdicion()
        {
            // Limpiamos s�lo si es modo creaci�n, si es modo edici�n dejamos los valores:
            if (modoEdicion == ModoEdicion.crear)
            {
                txtNombre.Text = "";
                dtpFechaConcierto.Value = DateTime.Now;
                txtPrecioEntrada.Text = "";
                txtNumeroAsiento.Text = "";
                txtDescripcion.Text = "";
                txtId.Text = "";

            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Enabled = true;
            dtpFechaConcierto.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecioEntrada.Enabled = true;
            txtNumeroAsiento.Enabled = true;
            txtId.Enabled = false;

            btnA�adir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            dgvListado.Enabled = false;
        }

        /// <summary>
        /// M�todo para establecer el modo de la pantalla a edici�n.
        /// </summary>
        public void ModoPantallaLectura()
        {
            txtNombre.Text = "";
            dtpFechaConcierto.Value = DateTime.Now;
            txtPrecioEntrada.Text = "";
            txtNumeroAsiento.Text = "";
            txtDescripcion.Text = "";
            txtId.Text = "";

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnA�adir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            txtNombre.Enabled = false;
            dtpFechaConcierto.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecioEntrada.Enabled = false;
            txtNumeroAsiento.Enabled = false;
            txtId.Enabled = false;

            dgvListado.Enabled = true;
        }

        /// <summary>
        /// M�todo para obtener la informaci�n del formulario.
        /// </summary>
        /// <returns>Contacto con la informaci�n del formulario.</returns>
        public Conciertos ObtenerInformacion()
        {
            Conciertos c = new Conciertos();

            c.nombre = txtNombre.Text;
            c.fechaConcierto = dtpFechaConcierto.Value;
            c.precioEntrada = Convert.ToInt32(txtPrecioEntrada.Text);
            c.numeroAsiento = Convert.ToInt32(txtNumeroAsiento.Text);
            c.descripcion = txtDescripcion.Text;

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                c.Id = Convert.ToInt32(txtId.Text);
            }

            return c;
        }

        /// <summary>
        /// M�todo que carga y configura el grid.
        /// </summary>
        /// <param name="Conciertos">DataTable con la info de los contactos</param>
        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repositorio.ObtenerConciertos();
            dgvListado.DataSource = ds.Tables[0];

            // Tama�os columnas
            dgvListado.Columns["Id"].Width = 40;
            dgvListado.Columns["Nombre"].Width = 150;
            dgvListado.Columns["FechaConcierto"].Width = 150;
            dgvListado.Columns["PrecioConcierto"].Width = 150;
            dgvListado.Columns["NumeroAsiento"].Width = 120;
            dgvListado.Columns["Descripcion"].Width = 300;

            // Renombrado columnas
            dgvListado.Columns["FechaConcierto"].HeaderText = "Fecha Concierto";
            dgvListado.Columns["PrecioEntrada"].HeaderText = "Precio Entrada";
            dgvListado.Columns["NumeroAsiento"].HeaderText = "Numero Asiento";
            // Formato fecha en espa�ol
            dgvListado.Columns["FechaConcierto"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarPrimeraFilaGrid();

        }

        /// <summary>
        /// M�todo que selecciona la primera fila del grid si existe.
        /// </summary>
        public void SeleccionarPrimeraFilaGrid()
        {
            // Si hay alguna fila, seleccionamos la primera
            if (dgvListado.Rows.Count > 0)
            {
                dgvListado.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// M�todo que carga la informaci�n de la fila seleccionada en los controles.
        /// </summary>
        /// <param name="filaSeleccionada"></param>
        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            dtpFechaConcierto.Value = (DateTime)filaSeleccionada.Cells["FechaConcierto"].Value;
            txtPrecioEntrada.Text = filaSeleccionada.Cells["PrecioEntrada"].Value.ToString();
            txtNumeroAsiento.Text = filaSeleccionada.Cells["NumeroAsiento"].Value.ToString();
            txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();

        }

        /// <summary>
        /// Funci�n que nos indica si la informaci�n obligatoria est� cumplimentada o no.
        /// </summary>
        /// <returns></returns>
        public bool InformacionObligatoriaCumplimentada()
        {
            if(String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtPrecioEntrada.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion


        private void frmConciertos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblFechaConcierto_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaConcierto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecioEntrada_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroAsiento_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void btnA�adir_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroAsiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConciertos_Load_1(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void frmConciertos_Load_2(object sender, EventArgs e)
        {

        }
    }
}