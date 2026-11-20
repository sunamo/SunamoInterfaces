namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the IFS item type.
/// </summary>
public interface IFSItem : IName, IPath, IIDParent
{
    /// <summary>
    /// Gets or sets the length.
    /// </summary>
    long Length { get; set; }
}
