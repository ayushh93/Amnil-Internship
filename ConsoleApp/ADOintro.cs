using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class ADOintro
    {
        static string connectionString = "Server=localhost;Database=amnildb;Uid=root;Pwd=;";
        public static void CheckConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connection established");
                connection.Close();

            }
        }

        public static void GetData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT ID,FirstName, LastName, Age, Address, Email FROM Interns";
                    connection.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("ID  | Name                     | Age | Address         | Email");
                        Console.WriteLine("--- | ------------------------ | --- | -------         | -----");
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader.GetInt32(reader.GetOrdinal("ID")),-3} | " +
                      $"{reader.GetString(reader.GetOrdinal("Firstname"))} " +
                      $"{reader.GetString(reader.GetOrdinal("LastName")),-15} | " +
                      $"{reader.GetInt32(reader.GetOrdinal("Age")),-3} | " +
                      $"{(reader.IsDBNull(reader.GetOrdinal("Address")) ? "NULL" : reader.GetString(reader.GetOrdinal("Address"))),-15} | " +
                      $"{(reader.IsDBNull(reader.GetOrdinal("Email")) ? "NULL" : reader.GetString(reader.GetOrdinal("Email"))),-15}");
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }

        public static void InsertData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Insert into Interns(FirstName,Lastname, Age, Address)" + "VALUES('Sanam','Thapa',25,'Suryabinayak')";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Data inserted succesfully");
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error inserting data: {ex.Message}" );
            }
        }
        public static void UpdateData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Update Interns SET Email = 'test@example.com' WHERE Email IS NULL ";
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Data inserted succesfully");
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating data: {ex.Message}");
            }
        }
        public static void DeleteData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Interns WHERE ID BETWEEN 15 AND 21";

                        connection.Open();

                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Interns deleted succesfully.");

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting data: {ex.Message}");
            }

        }
        public static void InsertUserData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Insert Data in table:");
                    Console.WriteLine("Enter FirstName: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter LastName: ");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Address: ");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter Email: ");
                    string email = Console.ReadLine();

                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "Insert into Interns(FirstName,Lastname, Age, Address, Email)" + "VALUES('@firstName','@lastName',@age,'@address','@email')";

                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@email", email);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Inserting data: {ex.Message}");
            }
            }
        }
    }
}
