namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i async file type.
/// </summary>
public interface IAsyncFile
{
    /// <summary>
    /// Read all text async.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    /// <returns>The read all text async result.</returns>
    Task<string> ReadAllTextAsync(string filePath);
}
