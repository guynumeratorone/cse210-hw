using System;
using System.Collections.Generic;

class Program //Program 2: Encapsulation with Online Ordering
{
    static void Main(string[] args)
    {
        Console.Clear();
        // addresses
        Address address1 = new Address("1 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("2 Board Walk Ave.", "Othercity", "NY", "USA");

        // customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Alice Smith", address2);

        // products
        Product product1 = new Product("Laptop", "12345", 999.99, 1);
        Product product2 = new Product("Mouse", "567654", 19.99, 2);
        Product product3 = new Product("Keyboard", "676543", 49.99, 1);

        // orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
