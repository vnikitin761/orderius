namespace Orderius.Domain;

public class FactoryOrder : IFactory
{
    public IProduct CreateProduct(DataTransfer dtObject) => new Order(dtObject.GetProperty<int>("Id"), dtObject.GetProperty<string>("Number"), dtObject.GetProperty<DateTime>("Date"),
            dtObject.GetProperty<int>("ProviderId"));
}