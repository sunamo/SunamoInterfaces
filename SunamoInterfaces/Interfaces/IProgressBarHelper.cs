namespace SunamoInterfaces.Interfaces;

// Must be in sunamo because it's needed here, but DispatcherObject is not available in sunamo.
/// <summary>
/// Represents the i progress bar helper type.
/// </summary>
public interface IProgressBarHelper
{
    /// <summary>
    /// Done.
    /// </summary>
    void Done();
    /// <summary>
    /// Done partially.
    /// </summary>
    void DonePartially();
    /// <summary>
    /// Create instance.
    /// </summary>
    /// <param name="progressBar">The progress bar.</param>
    /// <param name="overall">The overall.</param>
    /// <param name="uiDispatcher">The ui dispatcher.</param>
    /// <returns>The create instance result.</returns>
    IProgressBarHelper CreateInstance(object progressBar, double overall, object uiDispatcher);
}
