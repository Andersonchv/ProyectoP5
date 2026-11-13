using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ProyectoP5.Entidades;

namespace ProyectoP5.Datos
{
    public class ProductoDAO
    {
        // Consultar todos los productos
        public List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();

            string consulta = @"
                SELECT
                    p.*,
                    a.tipo_conexion,
                    a.tiene_microfono,
                    c.metros,
                    c.conectores,
                    ac.tipo_alimentacion,
                    ac.compatibilidad
                FROM productos p
                LEFT JOIN producto_audio a
                    ON p.id = a.producto_id
                LEFT JOIN producto_cable c
                    ON p.id = c.producto_id
                LEFT JOIN producto_accesorio ac
                    ON p.id = ac.producto_id
                WHERE p.activo = 1";

            using (MySqlConnection conexion = ConexionBD.CrearConexion())
            {
                using (MySqlCommand comando =
                new MySqlCommand(consulta, conexion))
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string codigo = reader["codigo"].ToString()!;
                        string nombre = reader["nombre"].ToString()!;
                        string? descripcion =
                            reader["descripcion"] == DBNull.Value
                            ? null : reader["descripcion"].ToString();

                        decimal precio = Convert.ToDecimal(reader["precio"]);

                        string? marca =
                            reader["marca"] == DBNull.Value
                            ? null : reader["marca"].ToString();

                        int stock = Convert.ToInt32(reader["stock"]);
                        bool activo = Convert.ToBoolean(reader["activo"]);

                        string categoria = reader["categoria"].ToString()!;

                        Producto producto;

                        if (categoria == "Audio")
                        {
                            producto = new ProductoAudio(
                                codigo, nombre, descripcion, precio,
                                marca, stock, activo,
                                reader["tipo_conexion"].ToString()!,
                                Convert.ToBoolean(reader["tiene_microfono"])
                            );
                        }
                        else if (categoria == "Cable")
                        {
                            producto = new ProductoCable(
                                codigo, nombre, descripcion, precio,
                                marca, stock, activo,
                                Convert.ToDecimal(reader["metros"]),
                                reader["conectores"].ToString()!
                            );
                        }
                        else if (categoria == "Accesorio")
                        {
                            producto = new ProductoAccesorio(
                                codigo, nombre, descripcion, precio,
                                marca, stock, activo,
                                reader["tipo_alimentacion"].ToString()!,
                                reader["compatibilidad"].ToString()!
                            );
                        }
                        else
                        {
                            continue;
                        }

                        producto.Id = Convert.ToInt32(reader["id"]);

                        lista.Add(producto);
                    }
                }
            }

            return lista;
        }

        // Registrar un producto
        public int RegistrarProducto(Producto producto)
        {
            using (MySqlConnection conexion = ConexionBD.CrearConexion())
            {

                using (MySqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        string consulta = @"
                        INSERT INTO productos
                        (codigo, nombre, descripcion, precio, categoria, marca, stock, activo)
                        VALUES
                        (@codigo, @nombre, @descripcion, @precio, @categoria, @marca, @stock, @activo)";

                        using (MySqlCommand comando = new MySqlCommand(
                        consulta, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@codigo", producto.Codigo);
                            comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                            comando.Parameters.AddWithValue("@descripcion",
                                (object?)producto.Descripcion ?? DBNull.Value);
                            comando.Parameters.AddWithValue("@precio", producto.Precio);
                            comando.Parameters.AddWithValue("@categoria", producto.Categoria);
                            comando.Parameters.AddWithValue("@marca",
                                (object?)producto.Marca ?? DBNull.Value);
                            comando.Parameters.AddWithValue("@stock", producto.Stock);
                            comando.Parameters.AddWithValue("@activo", producto.Activo);

                            comando.ExecuteNonQuery();
                        }

                        int idProducto = Convert.ToInt32(
                            new MySqlCommand(
                                "SELECT LAST_INSERT_ID()",
                                conexion,
                                transaccion
                            ).ExecuteScalar());

                        if (producto is ProductoAudio audio)
                        {
                            string sqlAudio = @"
                            INSERT INTO producto_audio
                            (producto_id, tiene_microfono, tipo_conexion)
                            VALUES (@id, @microfono, @conexion)";

                            using (MySqlCommand comando = new MySqlCommand(
                            sqlAudio, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@id", idProducto);
                                comando.Parameters.AddWithValue("@microfono", audio.TieneMicrofono);
                                comando.Parameters.AddWithValue("@conexion", audio.TipoConexion);

                                comando.ExecuteNonQuery();
                            }
                        }
                        else if (producto is ProductoCable cable)
                        {
                            string sqlCable = @"
                            INSERT INTO producto_cable
                            (producto_id, metros, conectores)
                            VALUES (@id, @metros, @conectores)";

                            using (MySqlCommand comando = new MySqlCommand(
                            sqlCable, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@id", idProducto);
                                comando.Parameters.AddWithValue("@metros", cable.Metros);
                                comando.Parameters.AddWithValue("@conectores", cable.Conectores);

                                comando.ExecuteNonQuery();
                            }
                        }
                        else if (producto is ProductoAccesorio accesorio)
                        {
                            string sqlAccesorio = @"
                            INSERT INTO producto_accesorio
                            (producto_id, tipo_alimentacion, compatibilidad)
                            VALUES (@id, @alimentacion, @compatibilidad)";

                            using (MySqlCommand comando = new MySqlCommand(
                            sqlAccesorio, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@id", idProducto);
                                comando.Parameters.AddWithValue("@alimentacion", accesorio.TipoAlimentacion);
                                comando.Parameters.AddWithValue("@compatibilidad", accesorio.Compatibilidad);
                                comando.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            throw new Exception("Tipo de producto no válido.");
                        }

                        transaccion.Commit();
                        producto.Id = idProducto;

                        return idProducto;
                    }
                    catch (MySqlException ex) when (ex.Number == 1062)
                    {
                        transaccion.Rollback();
                        throw new Exception(
                        "Ya existe un producto registrado con ese código. Ingrese uno diferente.", ex);
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        // Modificar un producto existente
        public void ModificarProducto(Producto producto)
        {
            using (MySqlConnection conexion = ConexionBD.CrearConexion())
            {

                using (MySqlTransaction transaccion = conexion.BeginTransaction())
            {
                try
                {
                    string consulta = @"
                        UPDATE productos
                        SET codigo = @codigo,
                            nombre = @nombre,
                            descripcion = @descripcion,
                            precio = @precio,
                            marca = @marca,
                            stock = @stock
                        WHERE id = @id";

                    using (MySqlCommand comando = new MySqlCommand(
                    consulta, conexion, transaccion))
                    {
                        comando.Parameters.AddWithValue("@codigo", producto.Codigo);
                        comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                        comando.Parameters.AddWithValue("@descripcion",
                        (object?)producto.Descripcion ?? DBNull.Value);
                        comando.Parameters.AddWithValue("@precio", producto.Precio);
                        comando.Parameters.AddWithValue("@marca",
                        (object?)producto.Marca ?? DBNull.Value);
                        comando.Parameters.AddWithValue("@stock", producto.Stock);
                        comando.Parameters.AddWithValue("@id", producto.Id);
                         comando.ExecuteNonQuery();
                    }

                    if (producto is ProductoAudio audio)
                    {
                        string sql = @"
                        UPDATE producto_audio
                        SET tiene_microfono = @microfono,
                            tipo_conexion = @conexion
                        WHERE producto_id = @id";

                        using (MySqlCommand comando = new MySqlCommand(
                        sql, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@microfono", audio.TieneMicrofono);
                            comando.Parameters.AddWithValue("@conexion", audio.TipoConexion);
                            comando.Parameters.AddWithValue("@id", producto.Id);
                            comando.ExecuteNonQuery();
                        }
                    }
                    else if (producto is ProductoCable cable)
                    {
                        string sql = @"
                        UPDATE producto_cable
                        SET metros = @metros,
                        conectores = @conectores
                        WHERE producto_id = @id";

                        using (MySqlCommand comando = new MySqlCommand(
                        sql, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@metros", cable.Metros);
                            comando.Parameters.AddWithValue("@conectores", cable.Conectores);
                            comando.Parameters.AddWithValue("@id", producto.Id);
                            comando.ExecuteNonQuery();
                        }
                    }
                    else if (producto is ProductoAccesorio accesorio)
                    {
                        string sql = @"
                        UPDATE producto_accesorio
                        SET tipo_alimentacion = @alimentacion,
                            compatibilidad = @compatibilidad
                        WHERE producto_id = @id";

                        using (MySqlCommand comando = new MySqlCommand(
                        sql, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue("@alimentacion", accesorio.TipoAlimentacion);
                            comando.Parameters.AddWithValue("@compatibilidad", accesorio.Compatibilidad);
                            comando.Parameters.AddWithValue("@id", producto.Id);
                            comando.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        throw new Exception("Tipo de producto no válido.");
                    }

                    transaccion.Commit();
                    }
                    catch (MySqlException ex) when (ex.Number == 1062)
                    {
                        transaccion.Rollback();
                        throw new Exception(
                        "Ese código ya pertenece a otro producto. Ingrese uno diferente.", ex);
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        // Eliminar producto de las lista pero no de la base de datos
        public void EliminarProducto(int id)
        {
            using (MySqlConnection conexion = ConexionBD.CrearConexion())
            {
                string consulta = @"
                UPDATE productos
                SET activo = 0
                WHERE id = @id";

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    int filas = comando.ExecuteNonQuery();

                    if (filas == 0)
                    {
                        throw new Exception("No se encontró el producto.");
                    }
                }
            }
        }
    }
}