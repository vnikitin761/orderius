namespace Orderius.Domain.Updater;

public interface IUpdater
{
    void UpdateModel(IDomainModel domainModel,DataTransfer dtObject);
}