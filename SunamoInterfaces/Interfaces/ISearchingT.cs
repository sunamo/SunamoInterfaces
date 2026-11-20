namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i searching t t type.
/// </summary>
public interface ISearchingT<T>
{
    /// <summary>
    /// Search.
    /// </summary>
    /// <param name="searchTerm">The search term.</param>
    /// <returns>The search result.</returns>
    T Search(string searchTerm);
}
