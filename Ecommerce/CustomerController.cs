using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    internal static class CustomerController
    {
        public static string connectionString = "Server=localhost;Database=amnil_ecommerce;Uid=root;Pwd=;";

        public static int ShowCustomer(int customerId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM CUSTOMERS ORDER BY ID DESC LIMIT 1";
                        connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine("\nCustomer Details:");
                                    Console.WriteLine($"Customer ID: {reader.GetInt32(reader.GetOrdinal("ID"))}");
                                    Console.WriteLine($"Customer Name: {reader.GetString(reader.GetOrdinal("FirstName"))} {reader.GetString(reader.GetOrdinal("LastName"))}");
                                    Console.WriteLine($"Customer Age: {reader.GetInt32(reader.GetOrdinal("Age"))}");
                                    Console.WriteLine($"Customer Address: {reader.GetString(reader.GetOrdinal("Address"))}");
                                    customerId = reader.GetInt32(reader.GetOrdinal("ID"));
                                }
                                
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Checking Customer: {ex.Message}");

            }
            return customerId;

        }

        public static int CheckCustomer(int value,int customerId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM CUSTOMERS WHERE ID = @value ";
                        cmd.Parameters.AddWithValue("@value", value);
                        connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine("Customer Details:");
                                    Console.WriteLine($"Customer ID: {reader.GetInt32(reader.GetOrdinal("ID"))}");
                                    Console.WriteLine($"Customer Name: {reader.GetString(reader.GetOrdinal("FirstName"))} {reader.GetString(reader.GetOrdinal("LastName"))}" );
                                    Console.WriteLine($"Customer Age: {reader.GetInt32(reader.GetOrdinal("Age"))}");
                                    Console.WriteLine($"Customer Address: {reader.GetString(reader.GetOrdinal("Address"))}");
                                    customerId = reader.GetInt32(reader.GetOrdinal("ID"));

                                }
                            }
                            else
                            {
                                customerId = CreateCustomer(value,customerId);
                            }
                        }
                            connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error Checking Customer: {ex.Message}");

            }
            return customerId;


        }
        public static int CreateCustomer(int value, int customerId)
        {
            Console.WriteLine($"\nSorry! We couldnot find a customer with Customer ID {value}");

            Console.WriteLine("Create a Customer to continue:");
            Console.WriteLine("\nEnter FirstName: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter LastName: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

           try
           {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Customers (FirstName, LastName, Age, Address) " +
                            "VALUES (@firstName, @lastName, @age, @address)";

                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);

                        connection.Open();

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Customer Created");
                        customerId = ShowCustomer(customerId);
                        connection.Close();
                    }

                }
           }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Creating Customer: {ex.Message}");

            }
            return customerId;
        }
    }
}
