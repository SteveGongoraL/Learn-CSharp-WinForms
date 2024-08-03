using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ConexionDB
{
    public class DataAccess
    {
        private string connectionString;

        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertProducto(string nombre, int precio)
        {
            using (MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = "INSERT INTO pruebasProducto(nombre, precio) VALUES (@nombre, @precio);";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexionBD))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@precio", precio);

                    conexionBD.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            using(MySqlConnection conexionBD = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT id, nombre FROM pruebasProducto;";
                try
                {
                    conexionBD.Open();
                    MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                    MySqlDataReader reader = comando.ExecuteReader();
                    dataTable.Load(reader);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar datos: " + ex.Message);
                }
            }
            return dataTable;
        }

    }
}

