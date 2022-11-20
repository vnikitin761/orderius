using Orderius.Domain.Factory;

namespace Orderius.Domain;

public class Provider : IProduct
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    
    public List<Order> Orders { get; private set; }

    internal Provider(int id, string name, List<Order> orders)
    {
        Id = id;
        Name = name;
        Orders = orders;
    }
}