namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i parse collection indexes type.
/// </summary>
public interface IParseCollectionIndexes
{
    // Parses collection from list of strings using specified indexes.
    // For reverse process use ToString() method.
    // Parameter must be list due to parsing by indexes.
    /// <summary>
    /// Parse collection.
    /// </summary>
    /// <param name="lines">The lines.</param>
    /// <param name="indexes">The indexes.</param>
    void ParseCollection(List<string> lines, params int[] indexes);
}
