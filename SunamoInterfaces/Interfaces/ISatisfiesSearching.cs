namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for search satisfaction checking.
/// </summary>
public interface ISatisfiesSearching
{
    /// <summary>
    /// Determines whether the object satisfies the search criteria.
    /// </summary>
    /// <param name="searchTerm">The search term to check against.</param>
    /// <returns>True if satisfies search, false otherwise.</returns>
    bool SatisfiesSearch(string searchTerm);
}