using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Entidades
{
    /// <summary>
    /// Clase con los Valores Principales
    /// </summary>
    public class Reportes
    {
        /// Valores
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int CantidadVentas { get; set; }

        public decimal TotalVentas { get; set; }

        public int TotalProductosVendidos { get; set; }

        public List<VentaHistorialItem> Ventas { get; set; }
            = new List<VentaHistorialItem>();
    }
}
