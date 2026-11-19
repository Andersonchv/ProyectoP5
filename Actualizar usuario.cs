using MySqlX.XDevAPI;
using ProyectoP5.Datos;
using ProyectoP5.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoP5.Presentacion
{
    public partial class Actualizar_usuario : Form
    {
        public Actualizar_usuario()
        {
            InitializeComponent();
        }
        public Usuario? usuario_seleccionado { get; set; }
        private void button3_Click(object sender, EventArgs e)
        {
            Gestiondeusuarios gestiondeusuarios = new Gestiondeusuarios();
            gestiondeusuarios.Show();
            this.Close();
        }

        private void Actualizar_usuario_Load(object sender, EventArgs e)
        {
            dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
            else
                dgvbuscar.DataSource = Gestion_usuarios.Buscar(textBox1.Text);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (usuario_seleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            Usuario usuario = new Usuario();

            usuario.Nombre = txtNombre.Text.Trim();
            usuario.Telefono = txtTelefono.Text.Trim();
            usuario.Correo = txtCorreo.Text.Trim();
            usuario.Rol = comboBox1.SelectedItem?.ToString();
            usuario.Id = usuario_seleccionado.Id;

            if (Gestion_usuarios.Actualizar(usuario) > 0)
            {

                MessageBox.Show("Datos del usuario actualizados correctamente", "Actualización de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puedo actualizar el usuario", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
        }

        private void dgvbuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvbuscar.Rows[e.RowIndex];

            int id = Convert.ToInt32(fila.Cells[0].Value);
            usuario_seleccionado = Gestion_usuarios.ObtenerUsuario(id);

            txtID.Text = usuario_seleccionado.Id.ToString();
            txtNombre.Text = usuario_seleccionado.Nombre;
            txtTelefono.Text = usuario_seleccionado.Telefono;
            txtCorreo.Text = usuario_seleccionado.Correo;
            comboBox1.SelectedItem = usuario_seleccionado.Rol;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtID.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            comboBox1.SelectedIndex = -1;
            dgvbuscar.DataSource = Gestion_usuarios.Obtenertodos();
        }

        private void Actualizar_usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
