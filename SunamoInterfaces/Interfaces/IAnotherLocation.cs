namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i another location t u type.
/// </summary>
public interface IAnotherLocation<T, U>
{
    /// <summary>
    /// Gets or sets the root.
    /// </summary>
    T Root { get; set; }

    /// <summary>
    /// Return right location.
    /// </summary>
    /// <param name="id">The id.</param>
    /// <returns>The return right location result.</returns>
    U ReturnRightLocation(T id);
}
