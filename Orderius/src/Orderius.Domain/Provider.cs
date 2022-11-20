namespace Orderius.Domain;

public class Provider : IProduct
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    internal Provider(int id, string name)
    {
        Id = id;
        Name = name;
    }
}