using MySqlConnector;
using ProyectoP5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP5.Datos
{
    /// <summary>
    /// Clase para Extraer los datos de la BD
    /// </summary>
    public class ReporteDAO
    {
        /// VENTAS: Obtener Ventas Registradas
        public List<VentaHistorialItem> ObtenerVentas(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            var ventas = new List<VentaHistorialItem>();

            /// Solicitud de datos: Lo pide dentro de un período
            using var conexion = VentaConexion.CrearConexion();

            conexion.Open();

            const string sql = @"
                SELECT
                    v.id,
                    v.fecha,
                    v.cliente_id,
                    c.nombre,
                    v.total
                FROM ventas v
                INNER JOIN clientes c
                    ON v.cliente_id = c.id
                WHERE v.fecha >= @inicio
                  AND v.fecha < @fin
                ORDER BY v.fecha DESC, v.id DESC";

            using var comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue(
                "@inicio", fechaInicio.Date);

            comando.Parameters.AddWithValue(
                "@fin", fechaFin.Date.AddDays(1));

            using var lector = comando.ExecuteReader();

            /// Obtiene los datos y los envía
            while (lector.Read())
            {
                var venta = new VentaHistorialItem
                {
                    Id = lector.GetInt32(0),
                    Fecha = lector.GetDateTime(1),
                    ClienteId = lector.GetInt32(2),
                    Cliente = lector.GetString(3),
                    Total = lector.GetDecimal(4)
                };

                ventas.Add(venta);
            }

            return ventas;
        }

        /// VENTAS: Obtener cantidad total de productos vendidos.
        public int ObtenerTotalUnidadesVendidas(
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            /// Solicitud de datos: Lo pide dentro de un período
            using var conexion = VentaConexion.CrearConexion();

            conexion.Open();

            const string sql = @"
                SELECT COALESCE(SUM(dv.cantidad), 0)
                FROM detalle_venta dv
                INNER JOIN ventas v
                    ON dv.venta_id = v.id
                WHERE v.fecha >= @inicio
                  AND v.fecha < @fin";
            /// Utiliza el comando COALESCE para evitar valores nulos.

            using var comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue(
                "@inicio", fechaInicio.Date);

            comando.Parameters.AddWithValue(
                "@fin", fechaFin.Date.AddDays(1));

            /// Devuelve el resultado
            object? resultado = comando.ExecuteScalar();

            return Convert.ToInt32(resultado);
        }
    }
}
