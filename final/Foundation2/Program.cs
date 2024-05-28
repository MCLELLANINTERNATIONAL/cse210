using System;

class Program
{
    static void Main(string[] args)
    {
        var addressUSA = new Address("123 Elm St", "Anytown", "CA", "USA");
        var addressCanada = new Address("456 Maple St", "Toronto", "ON", "Canada");

        var customer1 = new Customer("John Doe", addressUSA);
        var customer2 = new Customer("Jane Smith", addressCanada);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W123", 3.50m, 10));
        order1.AddProduct(new Product("Gadget", "G456", 5.00m, 5));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Widget", "W123", 3.50m, 3));
        order2.AddProduct(new Product("Gadget", "G456", 5.00m, 2));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
    
}