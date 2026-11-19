using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoP5.Datos;
using ProyectoP5.Entidades;

namespace ProyectoP5.Presentacion
{
    public partial class Registrodeusuarios : Form
    {
        public Registrodeusuarios()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestiondeusuarios Gestiondeusuarios = new Gestiondeusuarios();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Completa todos los campos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuario usuario = new Usuario(
                    textBox2.Text.Trim(),
                    textBox3.Text.Trim(),
                    textBox4.Text.Trim(),
                    comboBox1.Text.Trim());

                Gestion_usuarios.Agregar(usuario);

                MessageBox.Show("Usuario registrado correctamente.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo registrar el usuario:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedItem = null;
        }

        private void Registrodeusuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
