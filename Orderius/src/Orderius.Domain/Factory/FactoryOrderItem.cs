namespace Orderius.Domain;

public class FactoryOrderItem : IFactory
{
    public IProduct CreateProduct(DataTransfer dtObject)
    {
        
        return new OrderItem(dtObject.GetProperty<int>("OrderId"),dtObject.GetProperty<int>("Id"), dtObject.GetProperty<string>("Name"),
            dtObject.GetProperty<int>("Quantity"), dtObject.GetProperty<TypeUnit>("Unit"));
    }
}