namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing object values.
/// </summary>
public interface IParserO
{
    /// <summary>
    /// Parses the specified object value.
    /// </summary>
    /// <param name="value">The object value to parse.</param>
    void Parse(object value);
}