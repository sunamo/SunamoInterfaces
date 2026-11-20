namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i parser t t type.
/// </summary>
public interface IParserT<T>
{
    /// <summary>
    /// Parse.
    /// </summary>
    /// <param name="value">The value.</param>
    void Parse(T value);
}
