namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i searching all t type.
/// </summary>
public interface ISearchingAll<T>
{
    /// <summary>
    /// Search.
    /// </summary>
    /// <param name="searchTerm">The search term.</param>
    /// <returns>The search result.</returns>
    List<T> Search(string searchTerm);

    /// <summary>
    /// Validate all.
    /// </summary>
    void ValidateAll();

    /// <summary>
    /// Names.
    /// </summary>
    /// <returns>The names result.</returns>
    List<string> Names();

    /// <summary>
    /// Password keys.
    /// </summary>
    /// <returns>The password keys result.</returns>
    List<T> PasswordKeys();
}
