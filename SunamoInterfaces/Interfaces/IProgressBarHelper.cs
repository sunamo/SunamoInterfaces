namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Helper interface for progress bar operations.
/// Must be in sunamo because it's needed here, but DispatcherObject is not available in sunamo.
/// </summary>
public interface IProgressBarHelper
{
    /// <summary>
    /// Marks the progress as fully complete.
    /// </summary>
    void Done();

    /// <summary>
    /// Marks the progress as partially complete.
    /// </summary>
    void DonePartially();

    /// <summary>
    /// Creates a new instance of progress bar helper.
    /// </summary>
    /// <param name="progressBar">The progress bar control (System.Windows.Controls.ProgressBar).</param>
    /// <param name="overall">Overall progress value.</param>
    /// <param name="uiDispatcher">UI dispatcher object (DispatcherObject).</param>
    /// <returns>New instance of progress bar helper.</returns>
    IProgressBarHelper CreateInstance(object progressBar, double overall, object uiDispatcher);
}