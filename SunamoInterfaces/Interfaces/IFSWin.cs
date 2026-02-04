namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for Windows-specific file system operations handling locked files.
/// </summary>
public interface IFSWin
{
    /// <summary>
    /// Deletes a file even if it is locked by another process.
    /// </summary>
    /// <param name="filePath">The path to the file to delete.</param>
    void DeleteFileMaybeLocked(string filePath);

    /// <summary>
    /// Deletes a file or folder even if it is locked by another process.
    /// </summary>
    /// <param name="path">The path to the file or folder to delete.</param>
    void DeleteFileOrFolderMaybeLocked(string path);
}