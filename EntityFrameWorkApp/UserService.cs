using EntityFrameWorkApp.Data;
using EntityFrameWorkApp.Migrations;
using EntityFrameWorkApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityFrameWorkApp
{
    public class UserService
    {
        public void DisplayUser()
        {
            Console.WriteLine("Getting list of all users...");
            try
            {
                using(var context = new EFContext())
                {
                    var users = context.Users.ToList();
                    foreach (var user in users)
                    {
                        Console.WriteLine(user.ToString());
                    }
                }
            }
            catch(Exception ex)
            { 
                Console.WriteLine($"Cannot display users:\n{ex.Message}");
            }
        }

        public void InsertUser()
        {
            string name, role, address;
            int age;

            do
            {
                Console.WriteLine("Enter the name of the user:");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));

            do
            {
                Console.WriteLine("Enter the role of the user(Admin/Manager/User):");
                role = Console.ReadLine();
            } while (string.IsNullOrEmpty(role));

            do
            {
                Console.WriteLine("Enter the address of the user:");
                address = Console.ReadLine();
            } while (string.IsNullOrEmpty(address));

            do
            {
                Console.WriteLine("Enter the age of the user:");
            } while (!int.TryParse(Console.ReadLine(), out age) || age <= 0);

            try
            {
                using(var context =new EFContext())
                {
                    var user = new User
                    {
                        Name = name,
                        Role = role,
                        Address = address,
                        Age = age

                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                Console.WriteLine($"User: {name} saved succesfully");
                Console.WriteLine("The updated table is:");
                DisplayUser();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry! User could not be saved - {ex.Message}");
            }

        }

        public void UpdateUser()
        {
            Console.WriteLine("Enter the id of the user you want to update:");
            int Id = Convert.ToInt32(Console.ReadLine());
            try
            {
                using(var context = new EFContext())
                {
                    var user = context.Users.Find(Id);
                    if (user is null)
                    {
                        Console.WriteLine("Oops! User doesn't exist:");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(user.ToString());
                        string name, role, address;
                        int age;

                        do
                        {
                            Console.WriteLine("Enter the name of the user:");
                            name = Console.ReadLine();
                        } while (string.IsNullOrEmpty(name));

                        do
                        {
                            Console.WriteLine("Enter the role of the user(Admin/Manager/User):");
                            role = Console.ReadLine();
                        } while (string.IsNullOrEmpty(role));

                        do
                        {
                            Console.WriteLine("Enter the address of the user:");
                            address = Console.ReadLine();
                        } while (string.IsNullOrEmpty(address));

                        do
                        {
                            Console.WriteLine("Enter the age of the user:");
                        } while (!int.TryParse(Console.ReadLine(), out age) || age <= 0);

                        user.Name = name;
                        user.Role = role;
                        user.Address = address;
                        user.Age = age;
                        context.Users.Update(user);
                        context.SaveChanges();
                        Console.WriteLine($"User updated succesfully");
                        Console.WriteLine("The updated table is:");
                        DisplayUser();
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine($"Oops! Cannot update user: {ex.Message} "); 
            }

        }

        public void DeleteUser()
        {
            Console.WriteLine("Enter the id of the user you want to delete:");
            int Id = Convert.ToInt32(Console.ReadLine());
            try
            {
                using (var context = new EFContext())
                {
                    var user = context.Users.Find(Id);
                    if (user is null)
                    {
                        Console.WriteLine("Oops! User doesn't exist:");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(user.ToString());
                        string confirm;
                        do
                        {
                            Console.WriteLine("Are you sure you want to delete this user?(Yes/No)");
                            confirm = Console.ReadLine();
                        } while (string.IsNullOrEmpty(confirm));
                        if (confirm.ToLower() != "yes")
                        {
                            Console.WriteLine("User Deletion Cancelled");
                        }
                        else
                        {
                            context.Users.Remove(user);
                            context.SaveChanges();
                            Console.WriteLine("User deleted successfully.");
                            Console.WriteLine("The updated table is:");
                            DisplayUser();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Oops! Cannot delete user: {ex.Message} ");
            }

        }

    }
}
