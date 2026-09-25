namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing typed values.
/// </summary>
/// <typeparam name="T">The type of value to parse.</typeparam>
public interface IParserT<T>
{
    /// <summary>
    /// Parses the specified typed value.
    /// </summary>
    /// <param name="value">The value to parse.</param>
    void Parse(T value);
}