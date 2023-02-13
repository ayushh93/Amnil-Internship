using Ecommerce;
using Mysqlx.Session;

Console.WriteLine("--------------------------------Welcome to Amnil Ecommerce--------------------------------");
ProductController.GetData();
bool repeat = true;
do
{
    Console.WriteLine("\nEnter your Customer ID to place an order:");
    int value = Convert.ToInt32(Console.ReadLine());
    int customerId= 0;
    customerId = CustomerController.CheckCustomer(value, customerId);
    OrderController.CreateOrder(customerId);
    Console.WriteLine("Do you want to place another order? (yes/no)");
    string response = Console.ReadLine();
    if (response.ToLower() == "no")
    {
        repeat = false;
    }
}
while (repeat) ;

OrderController.ShowOrders();
