namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for searchable data containers.
/// </summary>
public interface ISearchable
{
    /// <summary>
    /// Determines whether the container contains the specified data.
    /// </summary>
    /// <param name="data">The data to search for.</param>
    /// <returns>True if the data is found; otherwise, false.</returns>
    bool ContainsData(object data);
}