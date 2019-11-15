using System;
namespace Csharp_exercises
{
class Program3
    {
  
   
static void Main(string[] args)
  {
      var customer = new Customer();
      customer.Id = 1;
      customer.Name = "Ben";
      var order = new Order();
      customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
      


  }
}
}