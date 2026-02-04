namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing collections from string lists using specified indexes.
/// </summary>
public interface IParseCollectionIndexes
{
    /// <summary>
    /// Parses collection from list of strings using specified indexes.
    /// For reverse process use ToString() method.
    /// Parameter must be list due to parsing by indexes.
    /// </summary>
    /// <param name="lines">List of strings to parse.</param>
    /// <param name="indexes">Indexes to use for parsing.</param>
    void ParseCollection(List<string> lines, params int[] indexes);
}