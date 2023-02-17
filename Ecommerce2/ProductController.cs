using Ecommerce2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    internal static class ProductController
    {
        static string connectionString = "Server=localhost;Database=amnil_ecommerce;Uid=root;Pwd=;";
        public static void GetData()
        {
            List<Products> products = new List<Products>();
            try
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
                                    /*Console.WriteLine($"{reader.GetInt32(reader.GetOrdinal("ID")),-3} | " +
                                    $"{reader.GetString(reader.GetOrdinal("Product_name")),-20} | " +
                                    $"{reader.GetString(reader.GetOrdinal("Rate")),-3} | " +
                                    $"{(reader.IsDBNull(reader.GetOrdinal("Description")) ? "NULL" : reader.GetString(reader.GetOrdinal("Description"))),-15}");*/

                                    products.AddRange(new Products[]
                                    {
                                        new Products
                                        {
                                            Id=reader.GetInt32(reader.GetOrdinal("ID")),
                                            Product_name=reader.GetString(reader.GetOrdinal("Product_name")),
                                            Rate=reader.GetInt32(reader.GetOrdinal("Rate")),
                                            Description=(reader.IsDBNull(reader.GetOrdinal("Description")) ? "NULL" :                                      reader.GetString(reader.GetOrdinal("Description")))
                                        }
                                    });
                                }
                                foreach (var product in products)
                                {
                                    Console.WriteLine($"{product.Id.ToString(),-3} | " +
                                    $"{product.Product_name,-20} | " +
                                    $"{product.Rate.ToString(),-3} | " +
                                    $"{product.Description,-15}");
                                }
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error found:{ex.Message}");
            }
        }
    }
}
