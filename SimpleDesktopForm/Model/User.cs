using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesktopForm.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public User()
        {

        }
        public User(int id, string name, int age, string email, string address)
        {
            Id = id;
            Name = name;
            Age= age;
            Email = email;
            Address = address;
        }
        public override string ToString()
        {
            return $"User: {Id} Name:{Name} Age:{Age} Address:{Address} Email:{Email}";
        }
    }
   
}
