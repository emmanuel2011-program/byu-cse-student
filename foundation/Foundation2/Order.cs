using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const decimal _shippingCostUSA = 5.00m;
    private const decimal _shippingCostInternational = 35.00m;

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
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        total += _customer.IsCustomerInUSA() ? _shippingCostUSA : _shippingCostInternational;
        return total;
    }

    public string GetPackingLabel()
    {
        var packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"Product Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.CustomerAddress.DisplayAddressInfo()}";
    }
}
