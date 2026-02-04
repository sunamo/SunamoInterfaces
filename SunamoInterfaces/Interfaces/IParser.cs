namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing text data.
/// </summary>
public interface IParser
{
    /// <summary>
    /// Parses the specified text.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    void Parse(string text);
}