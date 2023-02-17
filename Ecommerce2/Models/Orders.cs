using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public int Product_Id { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderDto
    {
        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string Product_Name { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }

        public double Total()
        {
            return Quantity * Rate;
        }

        public override string ToString()
        {
            return $"{Customer_Name} ordered {Quantity} {Product_Name}{(Quantity > 1 ? "'s" : "")} worth of {Rate:c}{(Quantity > 1 ? " each" : "")}."
                   + $"\nTotal Amount: {Total():c}";
        }
    }
}
