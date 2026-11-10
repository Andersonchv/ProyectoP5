using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
    public class ProductoAccesorio : Producto
    {
        //Propiedades de ProductoAccesorio
        public string TipoAlimentacion { get; set; }
        public string Compatibilidad { get; set; }

        public ProductoAccesorio(
            string codigo, 
            string nombre, 
            string? descripcion, 
            decimal precio, 
            string? marca, 
            int stock, 
            bool activo, 
            string tipoAlimentacion, 
            string compatibilidad)
            : base(codigo, nombre, descripcion, precio, "Accesorio", marca, stock, activo)
        {
            TipoAlimentacion = tipoAlimentacion;
            Compatibilidad = compatibilidad;
        }
    }
}