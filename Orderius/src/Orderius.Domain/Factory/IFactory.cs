namespace Orderius.Domain.Factory;

public interface IFactory
{
    IProduct CreateProduct(DataTransfer dtObject);
}