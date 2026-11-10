using MySqlConnector;

namespace ProyectoP5.Datos
{
    public static class ConexionBD
    {
        public static MySqlConnection CrearConexion()
        {
            string? conexion =
                Environment.GetEnvironmentVariable("SISTEMA_VENTAS_DB");

            if (string.IsNullOrWhiteSpace(conexion))
            {
                throw new InvalidOperationException(
                    "No se encontró la configuración de conexión a MySQL."
                );
            }

            return new MySqlConnection(conexion);
        }
    }
}
