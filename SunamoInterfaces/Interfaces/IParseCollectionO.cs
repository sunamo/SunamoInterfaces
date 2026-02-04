namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing collections from object lists.
/// </summary>
public interface IParseCollectionO
{
    /// <summary>
    /// Parses collection from list of objects.
    /// For reverse process use ToString() method.
    /// </summary>
    /// <param name="list">List of objects to parse.</param>
    void ParseCollection(IList<object> list);
}