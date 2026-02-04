namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for logging operations.
/// </summary>
public interface ILog
{
    /// <summary>
    /// Creates a new log entry.
    /// </summary>
    /// <param name="entry">The log entry text.</param>
    void NewLogEntry(string entry);
}