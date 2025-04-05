using System;

namespace ProductOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Elm St", "Los Angeles", "CA", "USA");
            Address address2 = new Address("456 Maple Ave", "Vancouver", "BC", "Canada");

            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            Product product1 = new Product("Laptop", 101, 999.99, 1);
            Product product2 = new Product("Headphones", 102, 199.99, 2);
            Product product3 = new Product("Mouse", 103, 25.99, 3);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
        }
    }
}
