using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal static class OrderController
    {
        static string connectionString = "Server=localhost;Database=amnil_ecommerce;Uid=root;Pwd=;";
        public static void CreateOrder(int customerId)
        {
            Console.Write("\nEnter the id of product you want to order: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Orders (Customer_ID, Product_Id, Quantity) " +
                            "VALUES (@Customer_ID, @Product_ID, @Quantity)";

                        cmd.Parameters.AddWithValue("@Customer_ID", customerId);
                        cmd.Parameters.AddWithValue("@Product_ID", productId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);

                        connection.Open();

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Order placed");
                        connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Placing Order: {ex.Message}");

            }
        }
        public static void ShowOrders()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = " SELECT \r\n  Customers.ID AS CustomerId,\r\n  CONCAT(Customers.FirstName, ' ', Customers.LastName) AS CustomerName,\r\n  Orders.ID AS OrderId,\r\n  Orders.Quantity AS Qty,\r\n  Products.Rate AS Rate,\r\n  Orders.Quantity * Products.Rate AS Total\r\nFROM Orders\r\nJOIN Customers ON Orders.Customer_ID = Customers.ID\r\nJOIN Products ON Orders.Product_ID = Products.ID;";
                    connection.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n Here are your orders: \n");

                        Console.WriteLine("CustomerId | Customer Name         | OrderId   | Qty   | Rate    |   Total");
                        Console.WriteLine("---------- | --------------------- | ------ | ------ | ------ |--------");
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader.GetInt32(reader.GetOrdinal("CustomerId")),-10} | " +
                                $"{reader.GetString(reader.GetOrdinal("CustomerName")),-20} | " +
                                $"{reader.GetString(reader.GetOrdinal("OrderId")),-3} | " +
                                $"{reader.GetString(reader.GetOrdinal("Qty")),-3} | " +
                                $"{reader.GetString(reader.GetOrdinal("Rate")),-3} | " +
                                $"{reader.GetString(reader.GetOrdinal("Total")),-5}");
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
