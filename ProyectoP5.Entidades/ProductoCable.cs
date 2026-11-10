using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
    public class ProductoCable : Producto

    {
        //Propiedades de ProductoCable
        public decimal Metros { get; set; }
        public string Conectores { get; set; }

        public ProductoCable(
            string codigo, 
            string nombre, 
            string? descripcion, 
            decimal precio, 
            string? marca, 
            int stock, 
            bool activo, 
            decimal metros, 
            string conectores)
            : base(codigo, nombre, descripcion, precio, "Cable", marca, stock, activo)
        {
            Metros = metros;
            Conectores = conectores;
        }
    }
}
