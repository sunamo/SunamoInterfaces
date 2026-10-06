namespace SunamoInterfaces.Interfaces;

public interface IJsSerializerDynamic : IJsSerializer
{
    string SerializeFromDynamic(dynamic value);

    dynamic DeserializeToDynamic(string json);
}
