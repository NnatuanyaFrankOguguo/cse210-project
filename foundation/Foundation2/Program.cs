using System;

class Program
{
    
    static void Main(string[] args)
    {
        //creating address for the for the users
        Address frankAddress = new Address("No. 24 Isaac John St", "G.R.A Ikeja", "Lagos", "Nigeria");
        Address klausAddress = new Address("1234 W Main St", "Boise", "Idaho", "USA");
        
        //creating the users
        Customer user1 = new Customer("Frank Nnatuanya", frankAddress);
        Customer user2 = new Customer("Klaus Mikaelson", klausAddress);

        //items each users bought
        Product item1 = new Product("Iphone 16", 111, 2000, 1);
        Product item2 = new Product("Macbook pro", 222, 1600, 1);
        Product item3 = new Product("Lasagnia", 333, 90, 2);
        Product item4 = new Product("Harmburger", 444, 50, 3);
        
        //creating each orders that differents users made with the Address class, users, Products(which is a list incase the users order multiple product)
        Console.WriteLine("Order 1:");
        Order myOrder = new Order(user1);
        myOrder.AddProducts(item1);
        myOrder.AddProducts(item2);
        Console.WriteLine($"Total Cost: ${myOrder.TotalCost()}");
        Console.WriteLine("Packing Label");
        myOrder.PackingLabel();
        Console.WriteLine("Shipping Label");
        myOrder.ShippingLabel();

        Console.WriteLine("\n--------------------------\n");
        //creating another order again
        Console.WriteLine("Order 2:");
        Order myOrder2 = new Order(user2);
        myOrder2.AddProducts(item3);
        myOrder2.AddProducts(item4);
        Console.WriteLine($"Total Cost: ${myOrder.TotalCost()}");
        Console.WriteLine("Packing Label");
        myOrder2.PackingLabel();
        Console.WriteLine("Shipping Label");
        myOrder2.ShippingLabel();


    }
}