using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
   public class Administrador : Usuario
    {
        public Administrador(int id, string nombre, string telefono, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Correo = correo;
        }
        public override void permisos()
        {
            //permisos de Administrador
        }
    }
}
