using ProyectoP5.Entidades;
using ProyectoP5.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Presentacion
{
    public class FrmReportes : Form
    {
        private readonly ReporteServicio servicio;

        private DateTimePicker dtpInicio = null!;
        private DateTimePicker dtpFin = null!;
        private Button btnGenerar = null!;

        private DataGridView dgvVentas = null!;

        private Label lblCantidadVentas = null!;
        private Label lblTotalVentas = null!;
        private Label lblUnidadesVendidas = null!;

        public FrmReportes()
        {
            servicio = new ReporteServicio();

            CrearInterfaz();
        }

        /// <summary>
        /// UI de los reportes.
        /// </summary>
        private void CrearInterfaz()
        {
            Text = "ProyectoP5 - Reportes de Ventas";

            StartPosition = FormStartPosition.CenterScreen;

            ClientSize = new Size(1050, 700);

            MinimumSize = new Size(900, 600);

            BackColor = Color.White;

            // Panel de los Filtros.
            var pnlFiltros = new Panel
            {
                Dock = DockStyle.Top,
                Height = 90,
                Padding = new Padding(15),
                BackColor = Color.White
            };

            var lblInicio = new Label
            {
                Text = "Fecha inicio:",
                AutoSize = true,
                Location = new Point(15, 15)
            };

            dtpInicio = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(15, 38),
                Width = 150,
                Value = DateTime.Today.AddDays(-30)
            };

            var lblFin = new Label
            {
                Text = "Fecha fin:",
                AutoSize = true,
                Location = new Point(190, 15)
            };

            dtpFin = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(190, 38),
                Width = 150,
                Value = DateTime.Today
            };

            btnGenerar = new Button
            {
                Text = "Generar reporte",
                Location = new Point(370, 35),
                Size = new Size(160, 35),
                BackColor = Color.FromArgb(40, 100, 180),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnGenerar.Click += BtnGenerar_Click;

            pnlFiltros.Controls.Add(lblInicio);
            pnlFiltros.Controls.Add(dtpInicio);
            pnlFiltros.Controls.Add(lblFin);
            pnlFiltros.Controls.Add(dtpFin);
            pnlFiltros.Controls.Add(btnGenerar);

            // Panel del Resumen.
            var pnlResumen = new Panel
            {
                Dock = DockStyle.Top,
                Height = 110,
                Padding = new Padding(15),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            lblCantidadVentas = new Label
            {
                Text = "Cantidad de ventas: 0",
                AutoSize = true,
                Location = new Point(20, 25),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            lblTotalVentas = new Label
            {
                Text = "Total vendido: ₡0.00",
                AutoSize = true,
                Location = new Point(350, 25),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            lblUnidadesVendidas = new Label
            {
                Text = "Unidades vendidas: 0",
                AutoSize = true,
                Location = new Point(700, 25),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            pnlResumen.Controls.Add(lblCantidadVentas);
            pnlResumen.Controls.Add(lblTotalVentas);
            pnlResumen.Controls.Add(lblUnidadesVendidas);

            // Tabla de las Ventas.
            dgvVentas = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                RowHeadersVisible = false,
                BackgroundColor = Color.White
            };

            dgvVentas.Columns.Add("Id", "N.º Venta");
            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns.Add("ClienteId", "ID Cliente");
            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns.Add("Total", "Total");

            dgvVentas.Columns["Total"]!.DefaultCellStyle.Format =
                "₡ #,##0.00";

            // Agregar los Controles al Formulario.
            Controls.Add(dgvVentas);
            Controls.Add(pnlResumen);
            Controls.Add(pnlFiltros);
        }

        /// <summary>
        /// Generar Reporte al Presionar Botón.
        /// </summary>
        private void BtnGenerar_Click(object? sender, EventArgs e)
        {
            try
            {
                Reportes reporte = servicio.GenerarReporteVentas(
                    dtpInicio.Value,
                    dtpFin.Value);

                MostrarReporte(reporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo generar el reporte.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mostrar Resultados del Reporte.
        /// </summary>
        private void MostrarReporte(Reportes reporte)
        {
            dgvVentas.Rows.Clear();

            foreach (var venta in reporte.Ventas)
            {
                dgvVentas.Rows.Add(
                    venta.Id,
                    venta.Fecha,
                    venta.ClienteId,
                    venta.Cliente,
                    venta.Total);
            }

            lblCantidadVentas.Text =
                $"Cantidad de ventas: {reporte.CantidadVentas}";

            lblTotalVentas.Text =
                $"Total vendido: ₡{reporte.TotalVentas:N2}";

            lblUnidadesVendidas.Text =
                $"Unidades vendidas: " +
                $"{reporte.TotalProductosVendidos}";
        }
    }
}
