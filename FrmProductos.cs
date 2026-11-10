
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoP5.Datos;
using ProyectoP5.Entidades;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ProyectoP5.Presentacion
{
    public partial class FrmProductos : Form
    {
        // Instancia para acceder a la base de datos
        private readonly ProductoDAO productoDAO = new ProductoDAO();
        private Producto? productoSeleccionado;

        public FrmProductos()
        {
            InitializeComponent();

            // Opciones del tipo de conexión
            cmbTipoConexion.Items.Clear();
            cmbTipoConexion.Items.AddRange(new object[]
            {
                "Jack 3.5 mm",
                "USB",
                "Bluetooth"
            });

            ConfigurarFormulario();
            CargarProductos();
            dgvProductos.Resize += (s, e) => RedondearTabla();
            RedondearTabla();
            dgvProductos.Paint += dgvProductos_Paint;

            // Eventos de botones y Cmb
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            btnGuardar.Click += btnGuardar_Click;
            dgvProductos.CellClick += dgvProductos_CellClick;
            bntModificar.Click += bntModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            bntLimpiar.Click += bntLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;

            // Estado inicial de los controles
            cmbCategoria_SelectedIndexChanged(null, EventArgs.Empty);
            // Redondeo general 
            RedondearBoton(btnGuardar, 12);
            RedondearBoton(bntModificar, 12);
            RedondearBoton(btnEliminar, 12);
            RedondearBoton(bntLimpiar, 12);
            RedondearBoton(btnBuscar, 12);


            // Ajustar el diseño al cambiar el tamaño de la ventana
            this.Resize += FrmProductos_Resize;
            AjustarControles();
        }

        private void FrmProductos_Resize(object? sender, EventArgs e)
        {
            AjustarControles();
        }

        private void AjustarControles()
        {
            // Centrar el panel horizontalmente
            panelContenido.Left = (this.ClientSize.Width - panelContenido.Width) / 2;

            // Ajustar la altura del panel
            panelContenido.Height = this.ClientSize.Height
                                    - panelContenido.Top - 10;

            // Hacer que la tabla ocupe el espacio restante
            dgvProductos.Height = panelContenido.ClientSize.Height
                                  - dgvProductos.Top - 10;
        }

        // Configuración inicial del formulario
        // Configuración inicial del formulario
        private void ConfigurarFormulario()
        {
            // Categorías disponibles
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Audio");
            cmbCategoria.Items.Add("Cable");
            cmbCategoria.Items.Add("Accesorio");

            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.SelectedIndex = -1;

            // Configuración del tipo de conexión
            cmbTipoConexion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoConexion.SelectedIndex = -1;

            // Configuración del listado
            dgvProductos.AutoGenerateColumns = true;
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.RowHeadersVisible = false;
	    dgvProductos.ScrollBars = ScrollBars.Vertical;

            // Diseño visual de la tabla
            dgvProductos.EnableHeadersVisualStyles = false;

            // Encabezados
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(31, 78, 121);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Altura del encabezado
            dgvProductos.ColumnHeadersHeight = 38;
            dgvProductos.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Filas
            dgvProductos.DefaultCellStyle.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgvProductos.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 45, 45);
            dgvProductos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 120, 215);
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProductos.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // Filas alternadas
            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 245, 250);

            // Bordes internos negros
            dgvProductos.CellBorderStyle =
                DataGridViewCellBorderStyle.Single;
            dgvProductos.GridColor = Color.FromArgb(190, 200, 210);

            // Borde exterior: se dibujará redondeado por separado
            dgvProductos.BorderStyle = BorderStyle.None;

            // Altura de las filas
            dgvProductos.RowTemplate.Height = 30;
        }

        // Habilitar características según la categoría
        private void cmbCategoria_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            string categoria =
                cmbCategoria.SelectedItem?.ToString() ?? "";

            bool esAudio = categoria == "Audio";
            bool esCable = categoria == "Cable";
            bool esAccesorio = categoria == "Accesorio";

            cmbTipoConexion.Enabled = esAudio;
            chkMicrofono.Enabled = esAudio;

            nudMetros.Enabled = esCable;
            txtConectores.Enabled = esCable;

            txtTipoAlimentacion.Enabled = esAccesorio;
            txtCompatibilidad.Enabled = esAccesorio;
	    MostrarCaracteristicas();
        }

        // Consultar y mostrar productos
        private void CargarProductos()
        {
            try
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataSource =
                    productoDAO.ListarProductos();
                if (dgvProductos.Columns.Contains("Id"))
                {
                    dgvProductos.Columns["Id"].Visible = false;
                    dgvProductos.Columns["Activo"].Visible = false;
		    dgvProductos.Columns["Codigo"].HeaderText = "Código";
                    dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los productos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Registrar producto
        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            try
            {
                // Validar código y nombre
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(textNombre.Text))
                {
                    MessageBox.Show(
                        "Complete el código y el nombre.");
                    return;
                }

                // Validar categoría
                if (cmbCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione una categoría.");
                    return;
                }

                string codigo = txtCodigo.Text.Trim();
                string nombre = textNombre.Text.Trim();

                string? descripcion =
                    string.IsNullOrWhiteSpace(txtDescripcion.Text)
                    ? null
                    : txtDescripcion.Text.Trim();

                decimal precio = nudPrecio.Value;

                string? marca =
                    string.IsNullOrWhiteSpace(textMarca.Text)
                    ? null
                    : textMarca.Text.Trim();

                int stock = (int)nudStock.Value;

                string categoria =
                    cmbCategoria.SelectedItem!.ToString()!;

                Producto producto;

                // Crear producto según su categoría
                if (categoria == "Audio")
                {
                    // Validar tipo de conexión
                    if (cmbTipoConexion.SelectedIndex == -1)
                    {
                        MessageBox.Show(
                            "Seleccione un tipo de conexión.");
                        return;
                    }

                    producto = new ProductoAudio(
                        codigo,
                        nombre,
                        descripcion,
                        precio,
                        marca,
                        stock,
                        true,
                        cmbTipoConexion.Text,
                        chkMicrofono.Checked
                    );
                }
                else if (categoria == "Cable")
                {
                    // Validar conectores
                    if (string.IsNullOrWhiteSpace(txtConectores.Text))
                    {
                        MessageBox.Show(
                            "Ingrese los conectores del cable.");
                        return;
                    }

                    producto = new ProductoCable(
                        codigo,
                        nombre,
                        descripcion,
                        precio,
                        marca,
                        stock,
                        true,
                        nudMetros.Value,
                        txtConectores.Text.Trim()
                    );
                }
                else
                {
                    // Validar características del accesorio
                    if (string.IsNullOrWhiteSpace(
                            txtTipoAlimentacion.Text) ||
                        string.IsNullOrWhiteSpace(
                            txtCompatibilidad.Text))
                    {
                        MessageBox.Show(
                            "Complete la alimentación y compatibilidad.");
                        return;
                    }

                    producto = new ProductoAccesorio(
                        codigo,
                        nombre,
                        descripcion,
                        precio,
                        marca,
                        stock,
                        true,
                        txtTipoAlimentacion.Text.Trim(),
                        txtCompatibilidad.Text.Trim()
                    );
                }

                // Registrar en MySQL
                productoDAO.RegistrarProducto(producto);

                MessageBox.Show(
                    "Producto registrado correctamente.",
                    "Gestión de productos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Actualizar listado
                CargarProductos();

                // Limpiar formulario
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar el producto:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Seleccionar producto de la tabla
        private void dgvProductos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                productoSeleccionado =
                    dgvProductos.Rows[e.RowIndex].DataBoundItem as Producto;

                if (productoSeleccionado == null)
                    return;

                // Cargar información general
                txtCodigo.Text = productoSeleccionado.Codigo;
                textNombre.Text = productoSeleccionado.Nombre;
                txtDescripcion.Text = productoSeleccionado.Descripcion ?? "";
                textMarca.Text = productoSeleccionado.Marca ?? "";

                nudPrecio.Value = productoSeleccionado.Precio;
                nudStock.Value = productoSeleccionado.Stock;

                // Seleccionar categoría
                cmbCategoria.SelectedItem = productoSeleccionado.Categoria;

                // Cargar características según el tipo
                if (productoSeleccionado is ProductoAudio audio)
                {
                    cmbTipoConexion.SelectedItem = audio.TipoConexion;
                    chkMicrofono.Checked = audio.TieneMicrofono;
                }
                else if (productoSeleccionado is ProductoCable cable)
                {
                    nudMetros.Value = cable.Metros;
                    txtConectores.Text = cable.Conectores;
                }
                else if (productoSeleccionado is ProductoAccesorio accesorio)
                {
                    txtTipoAlimentacion.Text = accesorio.TipoAlimentacion;
                    txtCompatibilidad.Text = accesorio.Compatibilidad;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el producto:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Modificar producto
        private void bntModificar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un producto de la tabla.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(textNombre.Text))
                {
                    MessageBox.Show("Complete el código y el nombre.");
                    return;
                }

                string categoria = cmbCategoria.SelectedItem?.ToString() ?? "";

                if (categoria != productoSeleccionado.Categoria)
                {
                    MessageBox.Show("No se puede cambiar la categoría del producto.");
                    return;
                }

                string codigo = txtCodigo.Text.Trim();
                string nombre = textNombre.Text.Trim();

                string? descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text)
                    ? null : txtDescripcion.Text.Trim();

                decimal precio = nudPrecio.Value;

                string? marca = string.IsNullOrWhiteSpace(textMarca.Text)
                    ? null : textMarca.Text.Trim();

                int stock = (int)nudStock.Value;

                Producto producto;

                if (categoria == "Audio")
                {
                    if (cmbTipoConexion.SelectedIndex == -1)
                    {
                        MessageBox.Show("Seleccione un tipo de conexión.");
                        return;
                    }

                    producto = new ProductoAudio(
                        codigo, nombre, descripcion, precio, marca, stock,
                        true, cmbTipoConexion.Text, chkMicrofono.Checked);
                }
                else if (categoria == "Cable")
                {
                    if (string.IsNullOrWhiteSpace(txtConectores.Text))
                    {
                        MessageBox.Show("Ingrese los conectores del cable.");
                        return;
                    }

                    producto = new ProductoCable(
                        codigo, nombre, descripcion, precio, marca, stock,
                        true, nudMetros.Value, txtConectores.Text.Trim());
                }
                else if (categoria == "Accesorio")
                {
                    if (string.IsNullOrWhiteSpace(txtTipoAlimentacion.Text) ||
                        string.IsNullOrWhiteSpace(txtCompatibilidad.Text))
                    {
                        MessageBox.Show("Complete la alimentación y compatibilidad.");
                        return;
                    }

                    producto = new ProductoAccesorio(
                        codigo, nombre, descripcion, precio, marca, stock,
                        true, txtTipoAlimentacion.Text.Trim(),
                        txtCompatibilidad.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Seleccione una categoría válida.");
                    return;
                }

                // Conservar el ID original
                producto.Id = productoSeleccionado.Id;

                // Actualizar en MySQL
                productoDAO.ModificarProducto(producto);

                MessageBox.Show(
                    "Producto modificado correctamente.",
                    "Gestión de productos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarProductos();

                productoSeleccionado = null;
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar el producto:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Eliminar producto
        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Seleccione un producto de la tabla.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar el producto: " +
                    productoSeleccionado.Nombre + "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.No)
                    return;

                // Eliminación lógica en MySQL
                productoDAO.EliminarProducto(productoSeleccionado.Id);

                MessageBox.Show(
                    "Producto eliminado correctamente.",
                    "Gestión de productos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Actualizar listado
                productoSeleccionado = null;
                CargarProductos();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el producto:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Botón para limpiar el formulario
        private void bntLimpiar_Click(object? sender, EventArgs e)
        {
            productoSeleccionado = null;
            dgvProductos.ClearSelection();
            LimpiarFormulario();
        }

        // Limpiar formulario luego de una accion
        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            textNombre.Clear();
            txtDescripcion.Clear();
            textMarca.Clear();

            nudPrecio.Value = 0;
            nudStock.Value = 0;
            nudMetros.Value = 0;

            cmbCategoria.SelectedIndex = -1;
            cmbTipoConexion.SelectedIndex = -1;

            chkMicrofono.Checked = false;

            txtConectores.Clear();
            txtTipoAlimentacion.Clear();
            txtCompatibilidad.Clear();
        }

        // Buscar productos por código o nombre
        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            try
            {
                string busqueda = txtBuscar.Text.Trim();

                List<Producto> productos = productoDAO.ListarProductos();

                if (!string.IsNullOrWhiteSpace(busqueda))
                {
                    productos = productos.FindAll(p =>
                        p.Codigo.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                        p.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase));
                }

                productoSeleccionado = null;
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;

                if (dgvProductos.Columns.Contains("Id"))
                {
                    dgvProductos.Columns["Id"].Visible = false;
                }

                dgvProductos.ClearSelection();

                if (productos.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        //Redondeo de boton
        private void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            int diametro = radio * 2;

            path.AddArc(0, 0, diametro, diametro, 180, 90);
            path.AddArc(boton.Width - diametro, 0, diametro, diametro, 270, 90);
            path.AddArc(boton.Width - diametro, boton.Height - diametro,
                        diametro, diametro, 0, 90);
            path.AddArc(0, boton.Height - diametro, diametro, diametro, 90, 90);

            path.CloseFigure();

            boton.Region = new Region(path);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
        }

	//Redondear txt
	private void RedondearTextBox(TextBox txt, int radio)
	{
    		using (GraphicsPath path = new GraphicsPath())
    		{
        int diametro = radio * 2;

        path.AddArc(0, 0, diametro, diametro, 180, 90);
        path.AddArc(txt.Width - diametro - 1, 0,
                    diametro, diametro, 270, 90);
        path.AddArc(txt.Width - diametro - 1,
                    txt.Height - diametro - 1,
                    diametro, diametro, 0, 90);
        path.AddArc(0, txt.Height - diametro - 1,
                    diametro, diametro, 90, 90);

        path.CloseFigure();

        txt.Region?.Dispose();
        txt.Region = new Region(path);
    }
}

        //Redondeo de tabla
        private void RedondearTabla()
        {
            int radio = 12;
            int ancho = dgvProductos.Width;
            int alto = dgvProductos.Height;

            if (ancho <= 0 || alto <= 0)
                return;

            int diametro = radio * 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, diametro, diametro, 180, 90);
                path.AddArc(ancho - diametro - 1, 0, diametro, diametro, 270, 90);
                path.AddArc(ancho - diametro - 1, alto - diametro - 1, diametro, diametro, 0, 90);
                path.AddArc(0, alto - diametro - 1, diametro, diametro, 90, 90);
                path.CloseFigure();

                dgvProductos.Region?.Dispose();
                dgvProductos.Region = new Region(path);
            }

            dgvProductos.Invalidate();
        }

        private void dgvProductos_Paint(object? sender, PaintEventArgs e)
        {
            int radio = 12;

		int ancho = dgvProductos.ClientSize.Width - 2;
		int alto = dgvProductos.ClientSize.Height - 2;

            if (ancho <= 0 || alto <= 0)
                return;

            int diametro = radio * 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(1, 1, diametro, diametro, 180, 90);
                path.AddArc(ancho - diametro, 1, diametro, diametro, 270, 90);
                path.AddArc(ancho - diametro, alto - diametro, diametro, diametro, 0, 90);
                path.AddArc(1, alto - diametro, diametro, diametro, 90, 90);
                path.CloseFigure();

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (Pen lapiz = new Pen(Color.Black, 1))
                {
                    e.Graphics.DrawPath(lapiz, path);
                }
            }
        }
	
private void MostrarCaracteristicas()
{
    string categoria = cmbCategoria.SelectedItem?.ToString() ?? "";

    bool esAudio = categoria == "Audio";
    bool esCable = categoria == "Cable";
    bool esAccesorio = categoria == "Accesorio";

    // Características de Audio
    cmbTipoConexion.Visible = esAudio;
    lblTipoConexion.Visible = esAudio;
    chkMicrofono.Visible = esAudio;

    // Características de Cable
    nudMetros.Visible = esCable;
    lblMetros.Visible = esCable;
    txtConectores.Visible = esCable;
    lblConectores.Visible = esCable;

    // Características de Accesorio
    txtTipoAlimentacion.Visible = esAccesorio;
    lblTipoAlimentacion.Visible = esAccesorio;
    txtCompatibilidad.Visible = esAccesorio;
    lblCompatibilidad.Visible = esAccesorio;
}
    }
}
