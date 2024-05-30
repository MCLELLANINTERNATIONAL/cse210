using System;
using System.Collections.Concurrent;

// Define an address class
class Address
{
    protected string _street;
    protected string _city;
    protected string _state;
    protected string _country;
    protected string _zipCode;

    public Address(string street, string city, string state, string country, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_country}, {_zipCode}";
    }
}
