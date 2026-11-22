namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i js serializer type.
/// </summary>
public interface IJsSerializer
{
    /// <summary>
    /// Deserialize.
    /// </summary>
    /// <param name="json">The json.</param>
    /// <param name="targetType">The target type.</param>
    /// <returns>The deserialize result.</returns>
    object Deserialize(string json, Type targetType);

    /// <summary>
    /// Serialize.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The serialize result.</returns>
    string Serialize(object value);

    /// <summary>
    /// Serialize.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="isIndented">The is indented.</param>
    /// <param name="jsonSerializerSettings">The json serializer settings.</param>
    /// <returns>The serialize result.</returns>
    string Serialize(object value, bool isIndented, JsonSerializerSettings jsonSerializerSettings);

    /// <summary>
    /// Serialize t t.
    /// </summary>
    /// <typeparam name="T">The type T.</typeparam>
    /// <param name="value">The value.</param>
    /// <returns>The serialize t t result.</returns>
    string SerializeT<T>(T value);

    /// <summary>
    /// Serialize t t.
    /// </summary>
    /// <typeparam name="T">The type T.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="isIndented">The is indented.</param>
    /// <param name="jsonSerializerSettings">The json serializer settings.</param>
    /// <returns>The serialize t t result.</returns>
    string SerializeT<T>(T value, bool isIndented, JsonSerializerSettings jsonSerializerSettings);
}
