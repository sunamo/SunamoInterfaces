namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i clipboard monitor type.
/// </summary>
public interface IClipboardMonitor
{
    /// <summary>
    /// Gets or sets the after set.
    /// </summary>
    bool? AfterSet { get; set; }

    /// <summary>
    /// Gets or sets the permanently block.
    /// </summary>
    bool PermanentlyBlock { get; set; }
}
