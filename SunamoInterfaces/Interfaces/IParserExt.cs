namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing text into a typed object.
/// </summary>
/// <typeparam name="T">The type to parse to.</typeparam>
public interface IParserExt<T>
{
    /// <summary>
    /// Parses the text into a typed object.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <returns>The parsed object.</returns>
    T Parse(string text);
}