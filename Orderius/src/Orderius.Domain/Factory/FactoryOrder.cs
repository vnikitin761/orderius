namespace Orderius.Domain.Factory;

public class FactoryOrder : IFactory
{
    public IProduct CreateProduct(DataTransfer dtObject)
    {
        var provider = dtObject.GetProperty<Provider>();
        var number = dtObject.GetProperty<string>("Number");
        if (provider.Orders.Exists(x => x.Number == number))
            throw new Exception("Provider can only have one order with this number!");
        return new Order(dtObject.GetProperty<int>("Id"), number,
            dtObject.GetProperty<DateTime>("Date"),
            provider);
    }
}