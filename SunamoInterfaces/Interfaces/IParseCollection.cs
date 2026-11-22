namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i parse collection type.
/// </summary>
public interface IParseCollection
{
    // Parses collection from list of strings.
    // For reverse process use ToString() method.
    // Parameter must be list due to parsing by indexes.
    /// <summary>
    /// Parse collection.
    /// </summary>
    /// <param name="lines">The lines.</param>
    void ParseCollection(List<string> lines);
}
