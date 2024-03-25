
using Npgsql;
using _2_Clases_Objetos_Constructores.Models;


namespace _5_ConexionDB.Models
{
    internal class CervezaDB
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Database=postgres-csharp;Username=my_user;Password=123456;";

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "SELECT * FROM public.cerveza ORDER BY id ASC"; // Ejemplo de consulta SQL

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

                    connection.Open();

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int cantidad = reader.GetInt32(reader.GetOrdinal("cantidad"));
                            string nombre = reader.GetString(reader.GetOrdinal("nombre"));
                            int alcohol = reader.GetInt32(reader.GetOrdinal("alcohol"));
                            string marca = reader.GetString(reader.GetOrdinal("marca"));

                            Cerveza cerveza = new Cerveza(cantidad, nombre)
                            {
                                Alcohol = alcohol,
                                Marca = marca
                            };

                            cervezas.Add(cerveza);
                        }
                    }

                    connection.Close();
                }
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("No se pudo conectar a la base de datos postgres, error: " + e.ToString());
            }

            return cervezas;
        }

        public void Add(Cerveza cerveza)
        {
            string query = "INSERT INTO cerveza (nombre, marca, alcohol, cantidad) VALUES (@nombre, @marca, @alcohol, @cantidad)";

            try
            {
                using (NpgsqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        _ = command.Parameters.AddWithValue("nombre", cerveza.Nombre);
                        _ = command.Parameters.AddWithValue("marca", cerveza.Marca);
                        _ = command.Parameters.AddWithValue("alcohol", cerveza.Alcohol);
                        _ = command.Parameters.AddWithValue("cantidad", cerveza.Cantidad);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Se insertaron {rowsAffected} filas.");
                    }

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void Edit(Cerveza cerveza, int id)
        {
            string query = "UPDATE cerveza SET nombre = @nombre, marca = @marca, alcohol = @alcohol, cantidad = @cantidad WHERE id = @id";

            try
            {
                using (NpgsqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        _ = command.Parameters.AddWithValue("nombre", cerveza.Nombre);
                        _ = command.Parameters.AddWithValue("marca", cerveza.Marca);
                        _ = command.Parameters.AddWithValue("alcohol", cerveza.Alcohol);
                        _ = command.Parameters.AddWithValue("cantidad", cerveza.Cantidad);
                        _ = command.Parameters.AddWithValue("id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Se actualizaron {rowsAffected} filas.");
                    }

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM cerveza WHERE id = @id";

            try
            {
                using (NpgsqlConnection connection = new(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        _ = command.Parameters.AddWithValue("id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Se Elimino {rowsAffected} filas.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }


    }
}
