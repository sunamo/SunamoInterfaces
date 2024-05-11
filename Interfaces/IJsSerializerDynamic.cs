
namespace SunamoInterfaces;
public interface IJsSerializerDynamic : IJsSerializer
{
    string SerializeFromDynamic(dynamic item);
    dynamic DeserializeToDynamic(string s);
}