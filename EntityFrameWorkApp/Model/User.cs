using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApp.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public User()
        {

        }

        public User(int id, string name, string role, string address, int age)
        {
            Id = id;
            Name = name;
            Role = role;
            Address = address;
            Age = age;
        }

        public override string ToString()
        {
            return $"User: {Id} Name:{Name} Role:{Role} Address:{Address} Age:{Age}";
        }
    }


}
