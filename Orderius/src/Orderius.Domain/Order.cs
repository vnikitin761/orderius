namespace Orderius.Domain;

public class Order
{
    public int Id { get; private set; }
    public string Number { get; set; }
    public DateTime Date { get; set; }
    public int ProviderId { get; set; }
    public OrderItem[] OrderItems { get; set; }

    private Order(int id, string number, DateTime date, int providerId)
    {
        Id = id;
        Number = number;
        Date = date;
        ProviderId = providerId;
    }

    public static Order FactoryOrder(DataTransfer dtObject)
    {
        return new Order(dtObject.GetProperty<int>("Id"), dtObject.GetProperty<string>("Number"), dtObject.GetProperty<DateTime>("Date"),
            dtObject.GetProperty<int>("ProviderId"));
    }
}

