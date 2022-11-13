namespace Orderius.Domain;

public interface IFactory
{
    IProduct CreateProduct(DataTransfer dtObject);
}