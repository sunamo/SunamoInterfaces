namespace SunamoInterfaces.Interfaces;
using Newtonsoft.Json;

public interface IJsSerializer
{
    //string Serialize(object o);
    object Deserialize(string o, Type targetType);

    string Serialize(object o);
    string Serialize(object o, bool indented, JsonSerializerSettings jsonSerializerSettings);

    string SerializeT<T>(T o);
    string SerializeT<T>(T o, bool indented, JsonSerializerSettings jsonSerializerSettings);
}