using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
    public class ProductoAudio : Producto

    {
        //Propiedades de ProductoCable
        public bool TieneMicrofono { get; set; }
        public string TipoConexion { get; set; }

        public ProductoAudio(
            string codigo, 
            string nombre, 
            string? descripcion, 
            decimal precio, 
            string? marca, 
            int stock, 
            bool activo, 
            string tipoConexion, 
            bool tieneMicrofono)
            : base(codigo, nombre, descripcion, precio, "Audio", marca, stock, activo)
        {
            TieneMicrofono = tieneMicrofono;
            TipoConexion = tipoConexion;
        }
    }
}
