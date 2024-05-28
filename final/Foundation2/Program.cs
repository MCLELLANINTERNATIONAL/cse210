using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        var addressUSA = new Address("123 Elm St", "Anytown", "CA", "USA");
        var addressCanada = new Address("456 Maple St", "Toronto", "ON", "Canada");
        var addressUK = new Address("789 Oak St", "London", "Greater London", "UK");

        var customer1 = new Customer("Cindy Lee", addressUSA);
        var customer2 = new Customer("David Sheal", addressCanada);
        var customer3 = new Customer("Peter Wannenburg", addressUK);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("W123", "Chair", 3.50m, 10));
        order1.AddProduct(new Product("G456", "Table", 5.00m, 5));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("G456", "Table", 5.00m, 2));
        order2.AddProduct(new Product("W123", "Chair", 3.50m, 3));

        var order3 = new Order(customer3);
        order3.AddProduct(new Product("W123","Chair",  3.50m, 3));
        order3.AddProduct(new Product("S234", "Cover", 1.50m, 3));
        order3.AddProduct(new Product("G456", "Table", 5.00m, 2));

        Console.WriteLine("\nOrder 1:");
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(order1.GetShippingLabel());
        
        Console.WriteLine("\n\nOrder 2:");
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\n\nOrder 3:");
        Console.WriteLine("Total Cost: $" + order3.CalculateTotalCost());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(order3.GetShippingLabel());
    }
    
}