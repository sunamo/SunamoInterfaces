namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i js serializer dynamic type.
/// </summary>
public interface IJsSerializerDynamic : IJsSerializer
{
    /// <summary>
    /// Serialize from dynamic.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The serialize from dynamic result.</returns>
    string SerializeFromDynamic(dynamic value);

    /// <summary>
    /// Deserialize to dynamic.
    /// </summary>
    /// <param name="json">The json.</param>
    /// <returns>The deserialize to dynamic result.</returns>
    dynamic DeserializeToDynamic(string json);
}
