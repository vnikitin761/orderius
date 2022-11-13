namespace Orderius.Domain;

public class OrderItem : IProduct
{
    public int OrderId { get; private set; }
    public int Id { get; private set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public TypeUnit Unit { get; set; }

    internal OrderItem(int orderId, int id, string name, int quantity, TypeUnit unit)
    {
        OrderId = orderId;
        Id = id;
        Name = name;
        Quantity = quantity;
        Unit = unit;
    }
}

