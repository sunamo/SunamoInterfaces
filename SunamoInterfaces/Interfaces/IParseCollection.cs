namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing collections from string lists.
/// </summary>
public interface IParseCollection
{
    /// <summary>
    /// Parses collection from list of strings.
    /// For reverse process use ToString() method.
    /// Parameter must be list due to parsing by indexes.
    /// </summary>
    /// <param name="lines">List of strings to parse.</param>
    void ParseCollection(List<string> lines);
}