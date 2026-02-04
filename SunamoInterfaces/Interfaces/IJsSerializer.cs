namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for JSON serialization and deserialization operations.
/// </summary>
public interface IJsSerializer
{
    /// <summary>
    /// Deserializes JSON to an object of the specified type.
    /// </summary>
    /// <param name="json">The JSON string to deserialize.</param>
    /// <param name="targetType">The target type to deserialize to.</param>
    /// <returns>The deserialized object.</returns>
    object Deserialize(string json, Type targetType);

    /// <summary>
    /// Serializes an object to JSON.
    /// </summary>
    /// <param name="value">The object to serialize.</param>
    /// <returns>The JSON string representation.</returns>
    string Serialize(object value);

    /// <summary>
    /// Serializes an object to JSON with formatting options.
    /// </summary>
    /// <param name="value">The object to serialize.</param>
    /// <param name="isIndented">Whether to indent the output.</param>
    /// <param name="jsonSerializerSettings">The serializer settings to use.</param>
    /// <returns>The JSON string representation.</returns>
    string Serialize(object value, bool isIndented, JsonSerializerSettings jsonSerializerSettings);

    /// <summary>
    /// Serializes a strongly-typed object to JSON.
    /// </summary>
    /// <typeparam name="T">The type of the object to serialize.</typeparam>
    /// <param name="value">The object to serialize.</param>
    /// <returns>The JSON string representation.</returns>
    string SerializeT<T>(T value);

    /// <summary>
    /// Serializes a strongly-typed object to JSON with formatting options.
    /// </summary>
    /// <typeparam name="T">The type of the object to serialize.</typeparam>
    /// <param name="value">The object to serialize.</param>
    /// <param name="isIndented">Whether to indent the output.</param>
    /// <param name="jsonSerializerSettings">The serializer settings to use.</param>
    /// <returns>The JSON string representation.</returns>
    string SerializeT<T>(T value, bool isIndented, JsonSerializerSettings jsonSerializerSettings);
}