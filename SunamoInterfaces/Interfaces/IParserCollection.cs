namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i parser collection t type.
/// </summary>
public interface IParserCollection<T>
{
    /// <summary>
    /// Parse collection.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The parse collection result.</returns>
    List<T> ParseCollection(string text);
}
