using System.Reflection;

namespace Orderius.Domain;

public struct DataTransfer
{
    private Dictionary<string,object> _properties;

    public DataTransfer(Dictionary<string, object> properties = null)
    {
        _properties = properties ?? new Dictionary<string,object>();
    }

    public T? GetProperty<T>(string propertyName = nameof(T)) =>
        _properties[propertyName] is T ? (T)_properties[propertyName] : default;

    public void SetProperty<T>(string propertyName, T propertyValue) => _properties.Add(propertyName,propertyValue);
}