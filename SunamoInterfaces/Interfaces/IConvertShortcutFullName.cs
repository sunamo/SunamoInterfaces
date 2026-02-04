namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for shortcut-fullname conversion operations.
/// </summary>
public interface IConvertShortcutFullName
{
    /// <summary>
    /// Converts from shortcut to full name.
    /// </summary>
    /// <param name="shortcut">The shortcut.</param>
    /// <returns>Full name.</returns>
    string FromShortcut(string shortcut);

    /// <summary>
    /// Converts from full name to shortcut.
    /// </summary>
    /// <param name="fullName">The full name.</param>
    /// <returns>Shortcut.</returns>
    string ToShortcut(string fullName);
}