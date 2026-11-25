using ProyectoP5.Datos;
using ProyectoP5.Presentacion;

namespace ProyectoP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CrearBotonReportes(); /// Inicializar el boton Reportes
        }

        /// <summary>
        /// Crear Boton Reportes
        /// </summary>
        private void CrearBotonReportes()
        {
            Button btnReportes = new Button
            {
                Name = "btnReportes",
                Text = "Reportes de ventas",
                Location = new Point(550, 148),
                Size = new Size(153, 89),
                BackColor = Color.FromArgb(40, 100, 180),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnReportes.Click += (sender, e) =>
            {
                using (FrmReportes formulario = new FrmReportes())
                {
                    formulario.ShowDialog();
                }
            };

            Controls.Add(btnReportes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestiondeusuarios form3 = new Gestiondeusuarios();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConexionBD.CrearConexion();
            MessageBox.Show("Conexión exitosa");
        }
    }
}
