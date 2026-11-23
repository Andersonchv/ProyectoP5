using ProyectoP5.Datos;
using ProyectoP5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Negocio
{
    /// <summary>
    /// Clase para coordinar la lógica del programa.
    /// </summary>
    public class ReporteServicio
    {

        /// DAO de consultas
        private readonly ReporteDAO reporteDAO;

        public ReporteServicio()
        {
            reporteDAO = new ReporteDAO();
        }

        /// VENTAS: Generar un reporte de ventas por fechas.
        public Reportes GenerarReporteVentas(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            // Validar rango de fechas.
            if (fechaInicio.Date > fechaFin.Date)
            {
                throw new ArgumentException(
                    "La fecha inicial no puede ser " +
                    "mayor que la fecha final.");
            }

            if (fechaFin.Date >= DateTime.MaxValue.Date)
            {
                throw new ArgumentException(
                    "Seleccione una fecha final válida.");
            }

            // Consultar las ventas del período.
            var ventas = reporteDAO.ObtenerVentas(
                fechaInicio, fechaFin);

            // Crear el reporte.
            var reporte = new Reportes
            {
                FechaInicio = fechaInicio.Date,
                FechaFin = fechaFin.Date,
                Ventas = ventas,
                CantidadVentas = ventas.Count,
                TotalVentas = ventas.Sum(v => v.Total),
                TotalProductosVendidos =
                    reporteDAO.ObtenerTotalUnidadesVendidas(
                        fechaInicio, fechaFin)
            };

            return reporte;
        }
    }
}
