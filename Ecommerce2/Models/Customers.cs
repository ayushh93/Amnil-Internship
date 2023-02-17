using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2.Models
{
    internal class Customers
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string FirstName { get; set; }
        [StringLength(10)]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
                return $"Customer: {Id}";
            else
                return $"Customer ID: {Id} \n Customer name:{FirstName} {LastName}";
        }
    }
}
