public class Order
{
    private List<Product> _list = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _list.Add(product);
    }
    public double TotalCost()
    {
        double total = 0.0;
        double shipCost;

        foreach (Product product in _list)
        {
            total += product.TotalCost();
        }

        if (_customer.InUSA())
        {
            shipCost = 5;
        }
        else
        {
            shipCost = 35;
        }

        total += shipCost;

        return total;
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _list)
        {
            label += $"{product.Display()}\n";
        }
        return label;
    }
    public string ShippingLabel()
    {
        return _customer.Display();
    }
    public string Display()
    {
        return $"Order:\n{PackingLabel()}\nShip To:\n{ShippingLabel()}\nTotal Price: ${TotalCost()}";
    }
}