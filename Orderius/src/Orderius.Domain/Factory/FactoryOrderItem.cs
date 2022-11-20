namespace Orderius.Domain.Factory;

public class FactoryOrderItem : IFactory
{
    public IProduct CreateProduct(DataTransfer dtObject)
    {
        var order = dtObject.GetProperty<Order>();
            var name = dtObject.GetProperty<string>("Name");
            if (order.Number == name)
                throw new Exception("Name order item it`s not number order!");
            return new OrderItem(order, dtObject.GetProperty<int>("Id"), name,
            dtObject.GetProperty<int>("Quantity"), dtObject.GetProperty<TypeUnit>("Unit"));

    }
}