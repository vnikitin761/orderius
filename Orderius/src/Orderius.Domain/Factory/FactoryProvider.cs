namespace Orderius.Domain;

public class FactoryProvider : IFactory
{
    public IProduct CreateProduct(DataTransfer dtObject) => new Provider(dtObject.GetProperty<int>("Id"), 
        dtObject.GetProperty<string>("Name"), dtObject.GetProperty<List<Order>>("Orders"));
}