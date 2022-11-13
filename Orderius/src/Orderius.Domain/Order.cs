namespace Orderius.Domain;

public class Order : IProduct
{
    public int Id { get; private set; }
    public string Number { get; set; }
    public DateTime Date { get; set; }
    public int ProviderId { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    internal Order(int id, string number, DateTime date, int providerId)
    {
        Id = id;
        Number = number;
        Date = date;
        ProviderId = providerId;
    }
}

