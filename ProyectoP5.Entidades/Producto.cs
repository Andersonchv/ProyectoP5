using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
    public class Producto
    {
        //Propiedades de la clase padre producto
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; } 

        public string? Descripcion { get; set; } // Opcional

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public bool Activo { get; set; }

        public string Categoria { get; set; }

        public string? Marca { get; set; } // Opcional


        //Constructor de padre producto
        public Producto(
            string codigo, 
            string nombre, 
            string? descripcion, 
            decimal precio, 
            string categoria, 
            string? marca, 
            int stock, 
            bool activo) 
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            Activo = activo;
            Categoria = categoria;
            Marca = marca;
        }
    }
}
