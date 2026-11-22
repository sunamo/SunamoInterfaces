namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i async type.
/// </summary>
public interface IAsync
{
    /// <summary>
    /// Get result t.
    /// </summary>
    /// <typeparam name="T">The type T.</typeparam>
    /// <param name="task">The task.</param>
    /// <returns>The get result t result.</returns>
    T GetResult<T>(Task<T> task);
}
