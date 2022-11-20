namespace Orderius.Domain.Updater;

public class OrderUpdater : IUpdater
{
    public void UpdateModel(IDomainModel domainModel, DataTransfer dtObject)
    {
        var order = domainModel as Order;
        order.Number = dtObject.GetProperty<string>("Number");
        order.Date = dtObject.GetProperty<DateTime>("Date");
        order.Provider = dtObject.GetProperty<Provider>();
    }
}