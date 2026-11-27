using ProyectoP5.Entidades;
using ProyectoP5.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoP5.Presentacion
{
    public partial class Eliminar_usuarios : Form
    {
        private int idSeleccionado = 0;

        public Eliminar_usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestiondeusuarios gestiondeusuarios = new Gestiondeusuarios();
            gestiondeusuarios.Show();
            this.Hide();
        }

        private void Eliminar_usuarios_Load(object sender, EventArgs e)
        {
            dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
            }
            else
            {
                dgvbuscar.DataSource = Gestion_usuarios.Buscar(textBox1.Text);
            }
        }

        private void dgvbuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvbuscar.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario en la tabla.");
                return;
            }

            Usuario usuario = new Usuario();
            usuario.Id = idSeleccionado;

            int resultado = Gestion_usuarios.Eliminar(usuario);

            if (resultado > 0)
            {
                MessageBox.Show("Usuario eliminado correctamente.");

                idSeleccionado = 0;
                dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el usuario.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
        }

        private void Eliminar_usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
