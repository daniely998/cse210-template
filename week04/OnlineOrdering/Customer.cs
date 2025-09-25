public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool InUSA()
    {
        if (_address.InUSA())
        {
            return true;
        }
        return false;
    }

    public string Display()
    {
        return $"Name: {_name}\nAddress:\n{_address.CompleteAddress()}";
    }
}