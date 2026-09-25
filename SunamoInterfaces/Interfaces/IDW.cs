namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for folder selection operations.
/// </summary>
public interface IDW
{
    /// <summary>
    /// Selects a folder within the specified root folder path.
    /// </summary>
    /// <param name="rootFolder">The root folder path.</param>
    /// <returns>The selected folder path.</returns>
    string SelectOfFolder(string rootFolder);

    /// <summary>
    /// Selects a folder within the specified special folder.
    /// </summary>
    /// <param name="rootFolder">The special folder to search in.</param>
    /// <returns>The selected folder path.</returns>
    string SelectOfFolder(Environment.SpecialFolder rootFolder);
}