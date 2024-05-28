using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const decimal DomesticShippingCost = 5m;
    private const decimal InternationalShippingCost = 35m;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        return totalCost + (_customer.IsCustomerInUSA() ? DomesticShippingCost : InternationalShippingCost);
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in _products)
        {
            sb.AppendLine($"ID: {product.GetName()} Product: {product.GetProductId()}  ");
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
   }
}
