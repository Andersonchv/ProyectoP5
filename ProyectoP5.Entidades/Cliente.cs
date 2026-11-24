using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
   public  class Cliente : Usuario
    {
        public string Apellido { get; set; } = string.Empty;
        public int Edad { get; set; } = 0;
        public int Credito { get; set; } = 0;

        public Cliente()
        {
        }

        public Cliente(string nombre, string telefono, string correo)
            : base(nombre, telefono, correo, "Cliente")
        {
        }

        public Cliente(int id,string nombre,string apellido, string telefono, int edad, string correo, int Credito)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Edad = edad;
            this.Credito = Credito;
        }

        public override void permisos()
        {
            //permisos de cliente
        }
    }
}
