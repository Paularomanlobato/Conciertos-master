namespace Conciertos
{
    partial class frmConciertos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPuntosDefensa = new System.Windows.Forms.TextBox();
            this.txtPuntosAtaque = new System.Windows.Forms.TextBox();
            this.lblPuntosAtaque = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtPuntosVida = new System.Windows.Forms.TextBox();
            this.lblPuntosVida = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPuntosDefensa
            // 
            this.txtPuntosDefensa.Location = new System.Drawing.Point(261, 175);
            this.txtPuntosDefensa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuntosDefensa.MaxLength = 9;
            this.txtPuntosDefensa.Name = "txtPuntosDefensa";
            this.txtPuntosDefensa.Size = new System.Drawing.Size(113, 31);
            this.txtPuntosDefensa.TabIndex = 30;
            this.txtPuntosDefensa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPuntosAtaque
            // 
            this.txtPuntosAtaque.Location = new System.Drawing.Point(261, 76);
            this.txtPuntosAtaque.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuntosAtaque.MaxLength = 9;
            this.txtPuntosAtaque.Name = "txtPuntosAtaque";
            this.txtPuntosAtaque.Size = new System.Drawing.Size(171, 31);
            this.txtPuntosAtaque.TabIndex = 29;
            this.txtPuntosAtaque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPuntosAtaque
            // 
            this.lblPuntosAtaque.AutoSize = true;
            this.lblPuntosAtaque.Location = new System.Drawing.Point(106, 45);
            this.lblPuntosAtaque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosAtaque.Name = "lblPuntosAtaque";
            this.lblPuntosAtaque.Size = new System.Drawing.Size(34, 25);
            this.lblPuntosAtaque.TabIndex = 27;
            this.lblPuntosAtaque.Text = "ID:";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(145, 139);
            this.lblFechaCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFechaCreacion.Size = new System.Drawing.Size(134, 25);
            this.lblFechaCreacion.TabIndex = 23;
            this.lblFechaCreacion.Text = ":Fecha Creación";
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCreacion.Location = new System.Drawing.Point(261, 117);
            this.dtpFechaCreacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(205, 31);
            this.dtpFechaCreacion.TabIndex = 24;
            // 
            // txtPuntosVida
            // 
            this.txtPuntosVida.Location = new System.Drawing.Point(261, 39);
            this.txtPuntosVida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuntosVida.MaxLength = 9;
            this.txtPuntosVida.Name = "txtPuntosVida";
            this.txtPuntosVida.Size = new System.Drawing.Size(171, 31);
            this.txtPuntosVida.TabIndex = 26;
            this.txtPuntosVida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPuntosVida
            // 
            this.lblPuntosVida.AutoSize = true;
            this.lblPuntosVida.Location = new System.Drawing.Point(106, 181);
            this.lblPuntosVida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntosVida.Name = "lblPuntosVida";
            this.lblPuntosVida.Size = new System.Drawing.Size(129, 25);
            this.lblPuntosVida.TabIndex = 25;
            this.lblPuntosVida.Text = "Precio Entrada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.lblPuntosVida);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPuntosDefensa);
            this.groupBox2.Controls.Add(this.lblPuntosAtaque);
            this.groupBox2.Controls.Add(this.txtPuntosAtaque);
            this.groupBox2.Controls.Add(this.txtPuntosVida);
            this.groupBox2.Controls.Add(this.dtpFechaCreacion);
            this.groupBox2.Location = new System.Drawing.Point(40, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 362);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Concierto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.Location = new System.Drawing.Point(261, 255);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(414, 89);
            this.txtDescripcion.TabIndex = 31;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(105, 286);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 25);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero Asiento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(662, 175);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 31);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(841, 395);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 38);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(712, 395);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 38);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(371, 395);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 38);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(235, 395);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 38);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(120, 395);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(107, 38);
            this.btnAñadir.TabIndex = 34;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(13, 443);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 62;
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(1028, 150);
            this.dgvListado.TabIndex = 39;
            // 
            // frmConciertos
            // 
            this.ClientSize = new System.Drawing.Size(1054, 612);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmConciertos";
            this.Text = "Contacto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblFechaConcierto;
        private DateTimePicker dtpFechaConcierto;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private DataGridView dgvListado;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtObservaciones;
        private Label lblObservaciones;
        private TextBox txtId;
        private Label lblId;
        private GroupBox gbInfoContacto;
        private TextBox txtPrecioEntrada;
        private TextBox txtNumeroAsiento;
        private Label lblPrecioEntrada;
        private Label lblNumeroAsiento;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtPuntosDefensa;
        private TextBox txtPuntosAtaque;
        private Label lblPuntosAtaque;
        private Label lblFechaCreacion;
        private DateTimePicker dtpFechaCreacion;
        private TextBox txtPuntosVida;
        private Label lblPuntosVida;
        private GroupBox groupBox2;
        private Label label3;
    }
}