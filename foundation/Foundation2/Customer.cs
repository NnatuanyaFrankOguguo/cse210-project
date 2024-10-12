using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.CombinedAddress();
    }

    
    public string GetDisplay()
    {
        return $"{_name} \nAddress: \n {_address.CombinedAddress()}";
    }


    public bool UsaResident()
    {
        if (_address.IsUsa()) 
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}