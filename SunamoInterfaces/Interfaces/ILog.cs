namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i log type.
/// </summary>
public interface ILog
{
    /// <summary>
    /// New log entry.
    /// </summary>
    /// <param name="entry">The entry.</param>
    void NewLogEntry(string entry);
}
