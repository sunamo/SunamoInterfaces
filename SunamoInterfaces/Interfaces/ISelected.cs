namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for objects with a selected item.
/// </summary>
public interface ISelected
{
    /// <summary>
    /// Gets the currently selected item.
    /// </summary>
    object SelectedItem { get; }
}