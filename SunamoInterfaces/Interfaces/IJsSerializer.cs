namespace SunamoInterfaces.Interfaces;

public interface IJsSerializer
{
    object Deserialize(string json, Type targetType);

    string Serialize(object value);

    string Serialize(object value, bool isIndented, JsonSerializerSettings jsonSerializerSettings);

    string SerializeT<T>(T value);

    string SerializeT<T>(T value, bool isIndented, JsonSerializerSettings jsonSerializerSettings);
}
