using Orderius.Domain.Factory;

namespace Orderius.Domain;

public class Order : IProduct
{
    public int Id { get; private set; }
    public string Number { get; set; }
    public DateTime Date { get; set; }
    public int ProviderId { get; set; }
    
    public List<OrderItem> OrderItems { get; set; }
    
    public Provider Provider { get; set; }

    internal Order(int id, string number, DateTime date, Provider provider)
    {
        Id = id;
        Number = number;
        Date = date;
        ProviderId = provider.Id;
        Provider = provider;
    }
}

