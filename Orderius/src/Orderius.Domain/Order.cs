using Orderius.Domain.Factory;

namespace Orderius.Domain;

public class Order : IDomainModel
{
    public int Id { get; private set; }
    public string Number { get; set; }
    public DateTime Date { get; set; }
    public int ProviderId => Provider.Id;
    
    public List<OrderItem> OrderItems { get; set; }
    
    public Provider Provider { get; set; }

    internal Order(int id, string number, DateTime date, Provider provider)
    {
        Id = id;
        Number = number;
        Date = date;
        Provider = provider;
    }
}

