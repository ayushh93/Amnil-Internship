using Ecommerce2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2
{
    internal static class CustomerController
    {
        public static string connectionString = "Server=localhost;Database=amnil_ecommerce;Uid=root;Pwd=;";

        public static int ShowCustomer(int customerId)
        {
            Customers customer = new();
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
                                    customer.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                                    customer.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                    customer.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                                    /*Console.WriteLine("\nCustomer Details:");
                                    Console.WriteLine($"Customer ID: {reader.GetInt32(reader.GetOrdinal("ID"))}");
                                    Console.WriteLine($"Customer Name: {reader.GetString(reader.GetOrdinal("FirstName"))} {reader.GetString(reader.GetOrdinal("LastName"))}");
                                    Console.WriteLine($"Customer Age: {reader.GetInt32(reader.GetOrdinal("Age"))}");
                                    Console.WriteLine($"Customer Address: {reader.GetString(reader.GetOrdinal("Address"))}");
                                    customerId = reader.GetInt32(reader.GetOrdinal("ID"));*/
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
            Console.WriteLine(customer);
            return customer.Id;

        }

        public static int CheckCustomer(int value, int customerId)
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
                            if (reader.HasRows)
                            {
                                Customers customer = new();
                                while (reader.Read())
                                {
                                    /* Console.WriteLine("Customer Details:");
                                     Console.WriteLine($"Customer ID: {reader.GetInt32(reader.GetOrdinal("ID"))}");
                                     Console.WriteLine($"Customer Name: {reader.GetString(reader.GetOrdinal("FirstName"))} {reader.GetString(reader.GetOrdinal("LastName"))}");
                                     Console.WriteLine($"Customer Age: {reader.GetInt32(reader.GetOrdinal("Age"))}");
                                     Console.WriteLine($"Customer Address: {reader.GetString(reader.GetOrdinal("Address"))}");
                                     customerId = reader.GetInt32(reader.GetOrdinal("ID"));*/
                                    customer.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                                    customer.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                    customer.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                                    customer.Age = reader.GetInt32(reader.GetOrdinal("Age"));
                                    customer.Address = reader.GetString(reader.GetOrdinal("Address"));
                                    Console.WriteLine("Customer Exists. \n Customer Details:");
                                    Console.WriteLine(customer);
                                    customerId = customer.Id; //For passing value in customerId variable
                                }
                            }
                            else
                            {
                                customerId = CreateCustomer(value, customerId);
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
        public static int CreateCustomer(int value, int customerId)
        {
            Console.WriteLine($"\nSorry! We couldnot find a customer with Customer ID {value}");
            Customers customer = new();
            Console.WriteLine("Create a Customer to continue:");
            Console.WriteLine("\nEnter FirstName: ");
            customer.FirstName = Console.ReadLine();

            Console.Write("Enter LastName: ");
            customer.LastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            customer.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address: ");
            customer.Address = Console.ReadLine();

            try
            {
                
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO Customers (FirstName, LastName, Age, Address) " +
                                "VALUES (@firstName, @lastName, @age, @address)";

                            cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                            cmd.Parameters.AddWithValue("@lastName", customer.LastName);
                            cmd.Parameters.AddWithValue("@age", customer.Age);
                            cmd.Parameters.AddWithValue("@address", customer.Address);

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
