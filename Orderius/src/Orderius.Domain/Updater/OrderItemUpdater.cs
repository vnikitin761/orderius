namespace Orderius.Domain.Updater;

public class OrderItemUpdater : IUpdater
{
    public void UpdateModel(IDomainModel domainModel, DataTransfer dtObject)
    {
        var orderItem = domainModel as OrderItem;
        orderItem.Name = dtObject.GetProperty<string>("Name");
        orderItem.Quantity = dtObject.GetProperty<int>("Quantity");
        orderItem.Unit = dtObject.GetProperty<TypeUnit>("Unit");
    }
}