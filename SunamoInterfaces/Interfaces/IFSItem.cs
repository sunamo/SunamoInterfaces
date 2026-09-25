namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface representing a file system item with name, path, parent ID, and length.
/// </summary>
public interface IFSItem : IName, IPath, IIDParent
{
    /// <summary>
    /// Gets or sets the length of the file system item in bytes.
    /// </summary>
    long Length { get; set; }
}