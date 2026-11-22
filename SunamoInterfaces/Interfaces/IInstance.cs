namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i instance t type.
/// </summary>
public interface IInstance<T>
{
    /// <summary>
    /// Create instance.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The create instance result.</returns>
    T CreateInstance(object value);
}
