namespace SunamoInterfaces.Interfaces;

/// <summary>
/// A user control that an app window can host: it has a title and is initialized once after it is shown.
/// </summary>
public interface IUserControl
{
    /// <summary>
    /// Gets the title shown for the control (window title, tab header).
    /// </summary>
    string Title { get; }

    /// <summary>
    /// Initializes the control; called by the host after the control is created.
    /// </summary>
    void Init();
}
