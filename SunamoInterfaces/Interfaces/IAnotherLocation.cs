namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for managing another location with root and location retrieval.
/// </summary>
/// <typeparam name="T">The type of the root and identifier.</typeparam>
/// <typeparam name="U">The type of the returned location.</typeparam>
public interface IAnotherLocation<T, U>
{
    /// <summary>
    /// Gets or sets the root element.
    /// </summary>
    T Root { get; set; }

    /// <summary>
    /// Returns the right location for the given identifier.
    /// </summary>
    /// <param name="id">The identifier to lookup.</param>
    /// <returns>The corresponding location.</returns>
    U ReturnRightLocation(T id);
}