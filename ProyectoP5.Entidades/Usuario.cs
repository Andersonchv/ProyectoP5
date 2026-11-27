using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
    public class Usuario
    {
        // Valores
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public String Rol { get; set; } = string.Empty;


        public Usuario()
        {

        }
        public Usuario(string nombre, string telefono, string correo, string rol)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Rol = rol;
        }

        public virtual void permisos() {
            //permisos de usuario
        }

    }
}
