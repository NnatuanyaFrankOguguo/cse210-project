using System;

public class Product
{
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;
    

    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }

    // public int GetQuantity()
    // {
    //     return _quantity;
    // }

    //create a list of products in the orders class to be able to add multiple products for one customer

    public void GetDisplay()
    {
       Console.WriteLine($"{_name}, {_id}, {_price}, {_quantity}, {GetTotalPrice()}");
    }
}