using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }

    public int TotalCost()
    {
        int productCost = 0;
        //iterate through the each product and add their totalprice to sum up everything in the productCost
        foreach (Product product in _products)
        {
            productCost += product.GetTotalPrice();
        }
        
        if(_customer.UsaResident())
        {
            int totalCost = productCost + 5;
            return totalCost;
        }
        else
        {
            int totalCost = productCost + 35;
            return totalCost;
        }
    }


    public void PackingLabel()
    {
        foreach (var product in _products)
        {
            Console.WriteLine($"Name of Product: {product.GetName()}, Product ID: {product.GetId()}");
        }
    }

    public void ShippingLabel()
    {
       
        Console.WriteLine($"Name of Customer: {_customer.GetName()}, \nCustomer Address: {_customer.GetAddress()} ");
        
       
    }

   

}