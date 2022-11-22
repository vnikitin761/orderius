using Orderius.Domain.Factory;
using Orderius.Domain.Updater;

namespace Orderius.Domain;

public class Order : IDomainModel
{
    public int Id { get; private set; }
    public string Number { get; internal set; }
    public DateTime Date { get; internal set; }
    public int ProviderId => Provider.Id;
    
    public List<OrderItem> OrderItems { get; private set; }
    
    public Provider Provider { get; internal set; }

    internal Order(int id, string number, DateTime date, Provider provider)
    {
        Id = id;
        Number = number;
        Date = date;
        Provider = provider;
        OrderItems = new List<OrderItem>();
    }

    public void Update(IUpdater updater,DataTransfer dtObject)
    {
        updater.UpdateModel(this,dtObject);
    }
}

