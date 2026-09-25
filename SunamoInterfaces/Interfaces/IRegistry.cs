namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for basic operations with Windows Registry.
/// </summary>
public interface IRegistry
{
    /// <summary>
    /// Sets a value in the registry at the specified path.
    /// </summary>
    /// <param name="value">Value to set.</param>
    /// <param name="path">Registry path.</param>
    void SetValue(object value, string path);

    /// <summary>
    /// Gets a value from the registry at the specified path.
    /// </summary>
    /// <param name="path">Registry path.</param>
    /// <returns>Registry value.</returns>
    object GetValue(string path);
}