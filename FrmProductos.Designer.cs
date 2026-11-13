namespace ProyectoP5.Presentacion
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IblTitulo = new Label();
            panelContenido = new Panel();
            button2 = new Button();
            btnMenuPrincipal = new Button();
            btnBuscar = new Button();
            bntLimpiar = new Button();
            btnEliminar = new Button();
            bntModificar = new Button();
            btnGuardar = new Button();
            txtBuscar = new TextBoxRedondeado();
            dgvProductos = new DataGridView();
            grpCaracteristicas = new RedondeoGroupBox();
            nudMetros = new NumericUpDownRedondeado();
            txtCompatibilidad = new TextBoxRedondeado();
            txtConectores = new TextBoxRedondeado();
            lblConectores = new Label();
            lblCompatibilidad = new Label();
            lblMetros = new Label();
            chkMicrofono = new CheckBox();
            txtTipoAlimentacion = new TextBoxRedondeado();
            cmbTipoConexion = new ComboBoxRedondeado();
            lblTipoConexion = new Label();
            lblTipoAlimentacion = new Label();
            grpDatosGenerales = new RedondeoGroupBox();
            txtDescripcion = new TextBoxRedondeado();
            lblDescripcion = new Label();
            cmbCategoria = new ComboBoxRedondeado();
            lblCategoria = new Label();
            nudStock = new NumericUpDownRedondeado();
            lblStock = new Label();
            textMarca = new TextBoxRedondeado();
            lblMarca = new Label();
            nudPrecio = new NumericUpDownRedondeado();
            lblPrecio = new Label();
            textNombre = new TextBoxRedondeado();
            lblNombre = new Label();
            txtCodigo = new TextBoxRedondeado();
            lblCodigo = new Label();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grpCaracteristicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMetros).BeginInit();
            grpDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // IblTitulo
            // 
            IblTitulo.Anchor = AnchorStyles.Top;
            IblTitulo.ForeColor = Color.Navy;
            IblTitulo.Location = new Point(348, 9);
            IblTitulo.Margin = new Padding(6, 0, 6, 0);
            IblTitulo.Name = "IblTitulo";
            IblTitulo.Size = new Size(382, 41);
            IblTitulo.TabIndex = 0;
            IblTitulo.Text = "GESTIÓN DE PRODUCTOS";
            IblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelContenido.Controls.Add(button2);
            panelContenido.Controls.Add(btnMenuPrincipal);
            panelContenido.Controls.Add(btnBuscar);
            panelContenido.Controls.Add(bntLimpiar);
            panelContenido.Controls.Add(btnEliminar);
            panelContenido.Controls.Add(bntModificar);
            panelContenido.Controls.Add(btnGuardar);
            panelContenido.Controls.Add(txtBuscar);
            panelContenido.Controls.Add(dgvProductos);
            panelContenido.Controls.Add(grpCaracteristicas);
            panelContenido.Controls.Add(grpDatosGenerales);
            panelContenido.Location = new Point(25, 53);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(983, 1000);
            panelContenido.TabIndex = 13;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(278, 871);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 19;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMenuPrincipal.BackColor = Color.FromArgb(52, 73, 94);
            btnMenuPrincipal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuPrincipal.ForeColor = Color.White;
            btnMenuPrincipal.Location = new Point(26, 910);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(159, 40);
            btnMenuPrincipal.TabIndex = 18;
            btnMenuPrincipal.Text = "Volver al menú";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(588, 525);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 40);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.DimGray;
            bntLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bntLimpiar.ForeColor = Color.White;
            bntLimpiar.Location = new Point(397, 525);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(120, 40);
            bntLimpiar.TabIndex = 16;
            bntLimpiar.Text = "Limpiar";
            bntLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(271, 525);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // bntModificar
            // 
            bntModificar.BackColor = Color.RoyalBlue;
            bntModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bntModificar.ForeColor = Color.White;
            bntModificar.Location = new Point(145, 525);
            bntModificar.Name = "bntModificar";
            bntModificar.Size = new Size(120, 40);
            bntModificar.TabIndex = 14;
            bntModificar.Text = "Modificar";
            bntModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(21, 525);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 40);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtBuscar.Location = new Point(714, 522);
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(10, 7, 10, 7);
            txtBuscar.Size = new Size(244, 43);
            txtBuscar.TabIndex = 12;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(21, 590);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(937, 300);
            dgvProductos.TabIndex = 8;
            // 
            // grpCaracteristicas
            // 
            grpCaracteristicas.Anchor = AnchorStyles.Top;
            grpCaracteristicas.BackColor = Color.White;
            grpCaracteristicas.Controls.Add(nudMetros);
            grpCaracteristicas.Controls.Add(txtCompatibilidad);
            grpCaracteristicas.Controls.Add(txtConectores);
            grpCaracteristicas.Controls.Add(lblConectores);
            grpCaracteristicas.Controls.Add(lblCompatibilidad);
            grpCaracteristicas.Controls.Add(lblMetros);
            grpCaracteristicas.Controls.Add(chkMicrofono);
            grpCaracteristicas.Controls.Add(txtTipoAlimentacion);
            grpCaracteristicas.Controls.Add(cmbTipoConexion);
            grpCaracteristicas.Controls.Add(lblTipoConexion);
            grpCaracteristicas.Controls.Add(lblTipoAlimentacion);
            grpCaracteristicas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            grpCaracteristicas.ForeColor = Color.Black;
            grpCaracteristicas.Location = new Point(21, 341);
            grpCaracteristicas.Name = "grpCaracteristicas";
            grpCaracteristicas.Size = new Size(937, 175);
            grpCaracteristicas.TabIndex = 3;
            grpCaracteristicas.TabStop = false;
            grpCaracteristicas.Text = "Características específicas";
            // 
            // nudMetros
            // 
            nudMetros.BackColor = Color.White;
            nudMetros.DecimalPlaces = 2;
            nudMetros.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudMetros.Location = new Point(639, 86);
            nudMetros.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudMetros.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudMetros.Name = "nudMetros";
            nudMetros.Padding = new Padding(10, 7, 10, 7);
            nudMetros.Size = new Size(222, 35);
            nudMetros.TabIndex = 10;
            nudMetros.ThousandsSeparator = false;
            nudMetros.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // txtCompatibilidad
            // 
            txtCompatibilidad.BackColor = Color.White;
            txtCompatibilidad.Location = new Point(709, 129);
            txtCompatibilidad.Multiline = false;
            txtCompatibilidad.Name = "txtCompatibilidad";
            txtCompatibilidad.Padding = new Padding(10, 7, 10, 7);
            txtCompatibilidad.Size = new Size(152, 35);
            txtCompatibilidad.TabIndex = 9;
            // 
            // txtConectores
            // 
            txtConectores.BackColor = Color.White;
            txtConectores.Location = new Point(130, 86);
            txtConectores.Multiline = false;
            txtConectores.Name = "txtConectores";
            txtConectores.Padding = new Padding(10, 7, 10, 7);
            txtConectores.Size = new Size(295, 35);
            txtConectores.TabIndex = 5;
            // 
            // lblConectores
            // 
            lblConectores.AutoSize = true;
            lblConectores.Location = new Point(21, 98);
            lblConectores.Name = "lblConectores";
            lblConectores.Size = new Size(103, 23);
            lblConectores.TabIndex = 0;
            lblConectores.Text = "Conectores:";
            // 
            // lblCompatibilidad
            // 
            lblCompatibilidad.AutoSize = true;
            lblCompatibilidad.Location = new Point(562, 141);
            lblCompatibilidad.Name = "lblCompatibilidad";
            lblCompatibilidad.Size = new Size(141, 23);
            lblCompatibilidad.TabIndex = 8;
            lblCompatibilidad.Text = "Compatibilidad:";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(561, 98);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(71, 23);
            lblMetros.TabIndex = 3;
            lblMetros.Text = "Metros:";
            // 
            // chkMicrofono
            // 
            chkMicrofono.AutoSize = true;
            chkMicrofono.Location = new Point(562, 43);
            chkMicrofono.Name = "chkMicrofono";
            chkMicrofono.Size = new Size(163, 27);
            chkMicrofono.TabIndex = 2;
            chkMicrofono.Text = "Tiene micrófono";
            chkMicrofono.UseVisualStyleBackColor = true;
            // 
            // txtTipoAlimentacion
            // 
            txtTipoAlimentacion.BackColor = Color.White;
            txtTipoAlimentacion.Location = new Point(214, 129);
            txtTipoAlimentacion.Multiline = false;
            txtTipoAlimentacion.Name = "txtTipoAlimentacion";
            txtTipoAlimentacion.Padding = new Padding(10, 7, 10, 7);
            txtTipoAlimentacion.Size = new Size(211, 35);
            txtTipoAlimentacion.TabIndex = 7;
            // 
            // cmbTipoConexion
            // 
            cmbTipoConexion.BackColor = Color.White;
            cmbTipoConexion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoConexion.FormattingEnabled = true;
            cmbTipoConexion.Location = new Point(179, 39);
            cmbTipoConexion.MinimumSize = new Size(0, 34);
            cmbTipoConexion.Name = "cmbTipoConexion";
            cmbTipoConexion.SelectedIndex = -1;
            cmbTipoConexion.SelectedItem = null;
            cmbTipoConexion.Size = new Size(245, 35);
            cmbTipoConexion.TabIndex = 1;
            // 
            // lblTipoConexion
            // 
            lblTipoConexion.AutoSize = true;
            lblTipoConexion.Location = new Point(21, 47);
            lblTipoConexion.Name = "lblTipoConexion";
            lblTipoConexion.Size = new Size(152, 23);
            lblTipoConexion.TabIndex = 0;
            lblTipoConexion.Text = "Tipo de conexion:";
            // 
            // lblTipoAlimentacion
            // 
            lblTipoAlimentacion.AutoSize = true;
            lblTipoAlimentacion.Location = new Point(21, 141);
            lblTipoAlimentacion.Name = "lblTipoAlimentacion";
            lblTipoAlimentacion.Size = new Size(187, 23);
            lblTipoAlimentacion.TabIndex = 6;
            lblTipoAlimentacion.Text = "Tipo de Alimentación:";
            // 
            // grpDatosGenerales
            // 
            grpDatosGenerales.Anchor = AnchorStyles.Top;
            grpDatosGenerales.AutoSize = true;
            grpDatosGenerales.BackColor = Color.White;
            grpDatosGenerales.Controls.Add(txtDescripcion);
            grpDatosGenerales.Controls.Add(lblDescripcion);
            grpDatosGenerales.Controls.Add(cmbCategoria);
            grpDatosGenerales.Controls.Add(lblCategoria);
            grpDatosGenerales.Controls.Add(nudStock);
            grpDatosGenerales.Controls.Add(lblStock);
            grpDatosGenerales.Controls.Add(textMarca);
            grpDatosGenerales.Controls.Add(lblMarca);
            grpDatosGenerales.Controls.Add(nudPrecio);
            grpDatosGenerales.Controls.Add(lblPrecio);
            grpDatosGenerales.Controls.Add(textNombre);
            grpDatosGenerales.Controls.Add(lblNombre);
            grpDatosGenerales.Controls.Add(txtCodigo);
            grpDatosGenerales.Controls.Add(lblCodigo);
            grpDatosGenerales.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDatosGenerales.ForeColor = Color.Black;
            grpDatosGenerales.Location = new Point(21, 15);
            grpDatosGenerales.Name = "grpDatosGenerales";
            grpDatosGenerales.Size = new Size(937, 300);
            grpDatosGenerales.TabIndex = 2;
            grpDatosGenerales.TabStop = false;
            grpDatosGenerales.Text = "Información general del producto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.Location = new Point(124, 202);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(10, 7, 10, 7);
            txtDescripcion.Size = new Size(789, 60);
            txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(6, 207);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(112, 25);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripcion:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(672, 147);
            cmbCategoria.MinimumSize = new Size(0, 34);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.SelectedItem = null;
            cmbCategoria.Size = new Size(241, 35);
            cmbCategoria.TabIndex = 11;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Cursor = Cursors.SizeAll;
            lblCategoria.Location = new Point(573, 158);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(93, 23);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria:";
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.White;
            nudStock.Cursor = Cursors.SizeAll;
            nudStock.DecimalPlaces = 0;
            nudStock.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.Location = new Point(93, 147);
            nudStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudStock.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Padding = new Padding(8, 10, 8, 10);
            nudStock.Size = new Size(247, 35);
            nudStock.TabIndex = 9;
            nudStock.ThousandsSeparator = true;
            nudStock.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblStock
            // 
            lblStock.Location = new Point(6, 158);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(82, 25);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock:";
            // 
            // textMarca
            // 
            textMarca.BackColor = Color.White;
            textMarca.Location = new Point(672, 101);
            textMarca.Multiline = false;
            textMarca.Name = "textMarca";
            textMarca.Padding = new Padding(10, 7, 10, 7);
            textMarca.Size = new Size(241, 35);
            textMarca.TabIndex = 7;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Cursor = Cursors.SizeAll;
            lblMarca.Location = new Point(573, 108);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(64, 23);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca:";
            // 
            // nudPrecio
            // 
            nudPrecio.BackColor = Color.White;
            nudPrecio.Cursor = Cursors.SizeAll;
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecio.Location = new Point(93, 101);
            nudPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudPrecio.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Padding = new Padding(8, 10, 8, 10);
            nudPrecio.Size = new Size(247, 35);
            nudPrecio.TabIndex = 5;
            nudPrecio.ThousandsSeparator = true;
            nudPrecio.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(5, 108);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(82, 25);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.White;
            textNombre.Location = new Point(672, 49);
            textNombre.Multiline = false;
            textNombre.Name = "textNombre";
            textNombre.Padding = new Padding(10, 7, 10, 7);
            textNombre.Size = new Size(241, 35);
            textNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Cursor = Cursors.SizeAll;
            lblNombre.Location = new Point(573, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 23);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.Location = new Point(93, 51);
            txtCodigo.Multiline = false;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(10, 7, 10, 7);
            txtCodigo.Size = new Size(247, 35);
            txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.Location = new Point(5, 56);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(82, 25);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1082, 1053);
            Controls.Add(panelContenido);
            Controls.Add(IblTitulo);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Location = new Point(41, 63);
            Margin = new Padding(6);
            MinimumSize = new Size(1100, 1100);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Productos";
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grpCaracteristicas.ResumeLayout(false);
            grpCaracteristicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMetros).EndInit();
            grpDatosGenerales.ResumeLayout(false);
            grpDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label IblTitulo;
        private Panel panelContenido;
        private TextBoxRedondeado txtBuscar;
        private DataGridView dgvProductos;
        private RedondeoGroupBox grpCaracteristicas;
        private NumericUpDownRedondeado nudMetros;
        private TextBoxRedondeado txtCompatibilidad;
        private Label lblCompatibilidad;
        private TextBoxRedondeado txtTipoAlimentacion;
        private Label lblTipoAlimentacion;
        private TextBoxRedondeado txtConectores;
        private Label lblConectores;
        private Label lblMetros;
        private CheckBox chkMicrofono;
        private ComboBoxRedondeado cmbTipoConexion;
        private Label lblTipoConexion;
        private RedondeoGroupBox grpDatosGenerales;
        private TextBoxRedondeado txtDescripcion;
        private Label lblDescripcion;
        private ComboBoxRedondeado cmbCategoria;
        private Label lblCategoria;
        private NumericUpDownRedondeado nudStock;
        private Label lblStock;
        private TextBoxRedondeado textMarca;
        private Label lblMarca;
        private NumericUpDownRedondeado nudPrecio;
        private Label lblPrecio;
	    private TextBoxRedondeado textNombre;
        private Label lblNombre;
	    private TextBoxRedondeado txtCodigo;
        private Label lblCodigo;
        private Button btnBuscar;
        private Button bntLimpiar;
        private Button btnEliminar;
        private Button bntModificar;
        private Button btnGuardar;
        private Button button2;
        private Button btnMenuPrincipal;
    }
}