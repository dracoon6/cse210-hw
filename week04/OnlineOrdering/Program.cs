using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address canadaAddress1 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Address usaAddress2 = new Address("789 Pine Ln", "Denver", "CO", "USA");

        // Create customers
        Customer customer1 = new Customer("Alice Smith", usaAddress1);
        Customer customer2 = new Customer("Bob Johnson", canadaAddress1);
        Customer customer3 = new Customer("Charlie Brown", usaAddress2);

        // Create products
        Product product1 = new Product("Laptop", "LAP001", 1200.00m, 1);
        Product product2 = new Product("Mouse", "MOU002", 25.00m, 2);
        Product product3 = new Product("Keyboard", "KEY003", 75.00m, 1);
        Product product4 = new Product("Monitor", "MON004", 300.00m, 1);
        Product product5 = new Product("Webcam", "CAM005", 50.00m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order 1 details
        Console.WriteLine("--- Order 1 ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        // Display order 2 details
        Console.WriteLine("--- Order 2 ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}