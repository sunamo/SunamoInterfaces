namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i registry type.
/// </summary>
public interface IRegistry
{
    /// <summary>
    /// Set value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="path">The path.</param>
    void SetValue(object value, string path);
    /// <summary>
    /// Get value.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <returns>The get value result.</returns>
    object GetValue(string path);
}
