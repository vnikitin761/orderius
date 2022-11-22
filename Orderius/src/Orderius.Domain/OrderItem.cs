using Orderius.Domain.Factory;
using Orderius.Domain.Updater;

namespace Orderius.Domain;

public class OrderItem : IDomainModel
{
    public int OrderId => Order.Id;
    public int Id { get; private set; }
    public string Name { get; internal set; }
    public int Quantity { get; internal set; }
    public TypeUnit Unit { get; internal set; }
    
    public Order Order { get; private set; }

    internal OrderItem(Order order,int id, string name, int quantity, TypeUnit unit)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Unit = unit;
        Order = order;
    }
    
    public void Update(IUpdater updater,DataTransfer dtObject)
    {
        updater.UpdateModel(this,dtObject);
    }
}

