using Orderius.Domain.Factory;

namespace Orderius.Domain;

public class OrderItem : IDomainModel
{
    public int OrderId => Order.Id;
    public int Id { get; private set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public TypeUnit Unit { get; set; }
    
    public Order Order { get; private set; }

    internal OrderItem(Order order,int id, string name, int quantity, TypeUnit unit)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Unit = unit;
        Order = order;
    }
}

