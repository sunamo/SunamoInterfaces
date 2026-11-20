namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i convert shortcut full name type.
/// </summary>
public interface IConvertShortcutFullName
{
    /// <summary>
    /// From shortcut.
    /// </summary>
    /// <param name="shortcut">The shortcut.</param>
    /// <returns>The from shortcut result.</returns>
    string FromShortcut(string shortcut);

    /// <summary>
    /// To shortcut.
    /// </summary>
    /// <param name="fullName">The full name.</param>
    /// <returns>The to shortcut result.</returns>
    string ToShortcut(string fullName);
}
