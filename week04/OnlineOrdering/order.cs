using System.Security.Cryptography.X509Certificates;

class Order
{
    private List<Product>_products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double TotalCost()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total += product.TotalCost();
        }
        if (_customer.LivesInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string PackingLabel()
    {
        string packinglabel = "";
        foreach(Product product in _products)
        {
            packinglabel += $"{product.GetProductId()}: {product.GetName()} x {product.GetQuantity()}| ";
        }
        return packinglabel;
    }
    public string ShippingLabel()
    {
    return $"{_customer.GetName()}: {_customer.GetAddress().GetStreetAddress()} {_customer.GetAddress().GetCity()} {_customer.GetAddress().GetState()} {_customer.GetAddress().GetCountry()}"; 
    }
    public void AddProduct(string name, string productId, double price, int quantity)
    {
        Product newProduct = new Product(name, productId, price, quantity);
        _products.Add(newProduct);
    }
}