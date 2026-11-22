namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the IFS win type.
/// </summary>
public interface IFSWin
{
    /// <summary>
    /// Delete file maybe locked.
    /// </summary>
    /// <param name="filePath">The file path.</param>
    void DeleteFileMaybeLocked(string filePath);

    /// <summary>
    /// Delete file or folder maybe locked.
    /// </summary>
    /// <param name="path">The path.</param>
    void DeleteFileOrFolderMaybeLocked(string path);
}
