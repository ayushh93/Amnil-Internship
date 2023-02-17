
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2.Models
{
    public class Products
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Product_name { get; set; }
        public double Rate { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
    }
}
