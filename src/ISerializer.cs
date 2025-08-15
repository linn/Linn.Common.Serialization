namespace Linn.Common.Serialization
{
    public interface ISerializer
    {
        T Deserialize<T>(string body);

        string Serialize(object value);
    }
}
