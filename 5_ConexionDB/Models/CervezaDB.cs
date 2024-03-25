
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


    }
}
