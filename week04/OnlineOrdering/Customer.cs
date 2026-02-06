class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name)
    {
        _name = name;
    }
    public bool LivesInUsa()
    {
        return _address.InUsa();
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(string streetAddress, string city, string state, string country)
    {
        _address = new Address(streetAddress, city, state, country);
    }
}