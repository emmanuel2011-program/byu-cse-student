using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("23 Ghana Street off Aminu Kano Wuse 2", "Abuja", "FCT", "Nigeria");
        Address address2 = new Address("123 Main St", "Los Angeles", "CA", "USA");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 1500, 1500, 1));
        order1.AddProduct(new Product("Mouse", 20, 20, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", 800, 800, 1));
        order2.AddProduct(new Product("Charger", 15, 15, 1));

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
