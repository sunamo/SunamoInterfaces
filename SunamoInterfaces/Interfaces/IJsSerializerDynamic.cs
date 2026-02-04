namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for JSON serialization with dynamic type support.
/// </summary>
public interface IJsSerializerDynamic : IJsSerializer
{
    /// <summary>
    /// Serializes a dynamic object to JSON.
    /// </summary>
    /// <param name="value">The dynamic object to serialize.</param>
    /// <returns>The JSON string representation.</returns>
    string SerializeFromDynamic(dynamic value);

    /// <summary>
    /// Deserializes JSON to a dynamic object.
    /// </summary>
    /// <param name="json">The JSON string to deserialize.</param>
    /// <returns>The deserialized dynamic object.</returns>
    dynamic DeserializeToDynamic(string json);
}