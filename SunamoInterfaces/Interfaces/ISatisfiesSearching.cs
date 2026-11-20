namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i satisfies searching type.
/// </summary>
public interface ISatisfiesSearching
{
    /// <summary>
    /// Satisfies search.
    /// </summary>
    /// <param name="searchTerm">The search term.</param>
    /// <returns>The satisfies search result.</returns>
    bool SatisfiesSearch(string searchTerm);
}
