namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing text into a collection of typed objects.
/// </summary>
/// <typeparam name="T">The type of objects in the collection.</typeparam>
public interface IParserCollection<T>
{
    /// <summary>
    /// Parses the text into a collection of typed objects.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <returns>The parsed collection.</returns>
    List<T> ParseCollection(string text);
}