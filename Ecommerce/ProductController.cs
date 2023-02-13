using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal static  class ProductController
    {
        static string connectionString = "Server=localhost;Database=amnil_ecommerce;Uid=root;Pwd=;";
        public static void GetData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT ID,Product_name, Rate, Description FROM Products";
                    connection.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n Here are our products: \n");

                        Console.WriteLine("ID  | Product Name         | Rate   | Description");
                        Console.WriteLine("--- | -------------------- | ------ | ----------------------------------");
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader.GetInt32(reader.GetOrdinal("ID")),-3} | " +
                                $"{reader.GetString(reader.GetOrdinal("Product_name")),-20} | " +
                                $"{reader.GetString(reader.GetOrdinal("Rate")),-3} | " +
                                $"{(reader.IsDBNull(reader.GetOrdinal("Description")) ? "NULL" : reader.GetString(reader.GetOrdinal("Description"))),-15}");
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
