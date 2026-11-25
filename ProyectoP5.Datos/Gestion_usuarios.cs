
using ProyectoP5.Entidades;
using MySqlConnector;


namespace ProyectoP5.Datos
{
    public class Gestion_usuarios
    {
        public static int Agregar(Usuario usuario)
        {
            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(
                "INSERT INTO usuarios (nombre, telefono, correo, activo, rol) " +
                "VALUES (@nombre, @telefono, @correo, @activo, @rol)",
                conexion);

            comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = usuario.Nombre;
            comando.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = usuario.Telefono;
            comando.Parameters.Add("@correo", MySqlDbType.VarChar).Value = usuario.Correo;
            comando.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;
            comando.Parameters.Add("@rol", MySqlDbType.VarChar).Value = usuario.Rol;

            return comando.ExecuteNonQuery();
        }
        public static List<Usuario> Obtenertodos()
        {
            List<Usuario> lista = new List<Usuario>();

            String sql = "SELECT id, nombre, telefono, correo, activo, rol FROM usuarios WHERE activo = 1";

            MySqlConnection conexion = ConexionBD.CrearConexion();
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Id = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Telefono = reader.GetString(2);
                usuario.Correo = reader.GetString(3);
                usuario.Rol = reader.GetString(5);

                lista.Add(usuario);
            }
            return lista;
        }

        public static List<Usuario> Buscar(string texto)
        {
            List<Usuario> lista = new List<Usuario>();

            string sql = @"SELECT id, nombre, telefono, correo, activo, rol
                   FROM usuarios
                   WHERE activo = 1
                     AND (CAST(id AS CHAR) = @exacto
                      OR nombre   LIKE @parcial
                      OR telefono LIKE @parcial
                      OR correo   LIKE @parcial) 
                      OR rol LIKE @parcial";

            using (MySqlConnection conexion = ConexionBD.CrearConexion())
            using (MySqlCommand comando = new MySqlCommand(sql, conexion))
            {
                comando.Parameters.AddWithValue("@exacto", texto);
                comando.Parameters.AddWithValue("@parcial", "%" + texto + "%");

                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = reader.GetInt32(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Telefono = reader.GetString(2);
                        usuario.Correo = reader.GetString(3);
                        usuario.Rol = reader.GetString(5);

                        lista.Add(usuario);
                    }
                }
            }

            return lista;
        }
        public static Cliente ObtenerCliente(int Id)
        {
            Cliente usuario = new Cliente();
            MySqlConnection conexion = ConexionBD.CrearConexion();

            MySqlCommand comando = new MySqlCommand(String.Format("SELECT id, nombre, telefono, correo, activo, rol FROM usuarios WHERE id={0}", Id), conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while(reader.Read())
            {
                usuario.Id = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Telefono = reader.GetString(2);
                usuario.Correo = reader.GetString(3);
                usuario.Rol = reader.GetString(5);

            }
            conexion.Close();
            return usuario;

        }
        public static int Actualizar(Usuario usuario)
        {
            int resultado = 0;

            MySqlConnection conexion = ConexionBD.CrearConexion();

             MySqlCommand comando = new MySqlCommand(String.Format("UPDATE usuarios set nombre = '{0}', telefono = '{1}', correo = '{2}', rol = '{4}' WHERE id = {3}", usuario.Nombre, usuario.Telefono, usuario.Correo, usuario.Id, usuario.Rol    ), conexion);
            resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;

            }


        public static int Eliminar(Usuario usuario)
        {
            using MySqlConnection conexion = ConexionBD.CrearConexion();
            using MySqlCommand comando = new MySqlCommand(
                "UPDATE usuarios SET activo = 0 WHERE id = @id", conexion);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = usuario.Id;

            return comando.ExecuteNonQuery();

        }
    }
 }