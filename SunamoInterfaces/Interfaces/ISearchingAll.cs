namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for searching operations on collections.
/// If you want to apply something to all elements of type T, use this.
/// </summary>
/// <typeparam name="T">The type of elements to search.</typeparam>
public interface ISearchingAll<T>
{
    /// <summary>
    /// Searches for items matching the search term.
    /// </summary>
    /// <param name="searchTerm">The search term.</param>
    /// <returns>List of matching items.</returns>
    List<T> Search(string searchTerm);

    /// <summary>
    /// Validates that everything is initialized correctly (checks for nulls).
    /// </summary>
    void ValidateAll();

    /// <summary>
    /// Gets names of all items for easy retrieval and evaluation.
    /// </summary>
    /// <returns>List of names.</returns>
    List<string> Names();

    /// <summary>
    /// Gets all password keys.
    /// </summary>
    /// <returns>List of password keys.</returns>
    List<T> PasswordKeys();
}