namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i parse collection o type.
/// </summary>
public interface IParseCollectionO
{
    // Parses collection from list of objects.
    // For reverse process use ToString() method.
    /// <summary>
    /// Parse collection.
    /// </summary>
    /// <param name="list">The list.</param>
    void ParseCollection(IList<object> list);
}
