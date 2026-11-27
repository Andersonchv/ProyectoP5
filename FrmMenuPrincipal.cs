using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoP5.Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos formulario = new FrmProductos();
            formulario.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas formulario = new FrmVentas();
            formulario.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Gestiondeusuarios formulario = new Gestiondeusuarios();
            formulario.Show();
            this.Hide();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
