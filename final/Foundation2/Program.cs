// Encapsulation with Online Ordering program. I have completed the design phase, creating classes for products, customers, addresses, and orders.
 
  
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Online Ordering store!");
        Console.WriteLine();

        Address address1 = new Address("567 Elm St", "Suburbia", "CA", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Table", 5678, 99.99, 1);
        Product product2 = new Product("Chair", 2345, 49.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Address address2 = new Address("45 High Street", "London", "WC1V 6EA", "United Kingdom");
        Customer customer2 = new Customer("Emma Thompson", address2);

        Product product3 = new Product("Teapot", 3547, 19.99, 3);
        Product product4 = new Product("Toaster", 4295, 29.99, 4);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4); 

        Console.WriteLine("\n-------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}