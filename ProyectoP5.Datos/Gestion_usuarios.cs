
using ProyectoP5.Entidades;
using MySql.Data.MySqlClient;

namespace ProyectoP5.Datos
{
    public class Gestion_usuarios
    {
        public static int Agregar(Cliente cliente)
        {
            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(
                "INSERT INTO clientes (nombre, telefono, correo, activo) " +
                "VALUES (@nombre, @telefono, @correo, @activo)",
                conexion);

            comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = cliente.Nombre;
            comando.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = cliente.Telefono;
            comando.Parameters.Add("@correo", MySqlDbType.VarChar).Value = cliente.Correo;
            comando.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

            return comando.ExecuteNonQuery();
        }

        public static List<Cliente> Obtenertodos()
        {
            List<Cliente> lista = new List<Cliente>();

            string sql = "SELECT id, nombre, telefono, correo, activo FROM clientes WHERE activo = 1";

            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(sql, conexion);
            using MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );

                lista.Add(cliente);
            }

            return lista;
        }

        public static List<Cliente> Buscar(string texto)
        {
            List<Cliente> lista = new List<Cliente>();

            string sql = @"SELECT id, nombre, telefono, correo, activo
                           FROM clientes
                           WHERE activo = 1
                           AND (CAST(id AS CHAR) = @exacto
                           OR nombre LIKE @parcial
                           OR telefono LIKE @parcial
                           OR correo LIKE @parcial)";

            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@exacto", texto);
            comando.Parameters.AddWithValue("@parcial", "%" + texto + "%");

            using MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );

                lista.Add(cliente);
            }

            return lista;
        }

        public static Cliente ObtenerCliente(int id)
        {
            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(
                "SELECT id, nombre, telefono, correo, activo FROM clientes WHERE id = @id",
                conexion);

            comando.Parameters.AddWithValue("@id", id);

            using MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                return new Cliente(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );
            }

            return null;
        }

        public static int Actualizar(Cliente cliente)
        {
            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(
                "UPDATE clientes SET nombre = @nombre, telefono = @telefono, correo = @correo WHERE id = @id",
                conexion);

            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@correo", cliente.Correo);
            comando.Parameters.AddWithValue("@id", cliente.Id);

            return comando.ExecuteNonQuery();
        }

        public static int Eliminar(Cliente cliente)
        {
            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(
                "UPDATE clientes SET activo = 0 WHERE id = @id",
                conexion);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = cliente.Id;

            return comando.ExecuteNonQuery();
        }
    }
}
