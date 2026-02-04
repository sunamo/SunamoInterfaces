namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Generic interface for searching operations that return typed results.
/// </summary>
/// <typeparam name="T">The type of search result.</typeparam>
public interface ISearchingT<T>
{
    /// <summary>
    /// Searches for an item matching the search term.
    /// </summary>
    /// <param name="searchTerm">The search term.</param>
    /// <returns>The search result.</returns>
    T Search(string searchTerm);
}