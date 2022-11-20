namespace Orderius.Domain.Factory;

public interface IFactory
{
    IDomainModel CreateProduct(DataTransfer dtObject);
}