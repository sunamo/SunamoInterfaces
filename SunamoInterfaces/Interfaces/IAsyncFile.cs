namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for asynchronous file operations.
/// </summary>
public interface IAsyncFile
{
    /// <summary>
    /// Reads all text from a file asynchronously.
    /// </summary>
    /// <param name="filePath">The path to the file.</param>
    /// <returns>The file content as string.</returns>
    Task<string> ReadAllTextAsync(string filePath);
}