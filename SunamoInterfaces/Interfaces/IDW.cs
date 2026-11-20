namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the IDW type.
/// </summary>
public interface IDW
{
    /// <summary>
    /// Select of folder.
    /// </summary>
    /// <param name="rootFolder">The root folder.</param>
    /// <returns>The select of folder result.</returns>
    string SelectOfFolder(string rootFolder);

    /// <summary>
    /// Select of folder.
    /// </summary>
    /// <param name="rootFolder">The root folder.</param>
    /// <returns>The select of folder result.</returns>
    string SelectOfFolder(Environment.SpecialFolder rootFolder);
}
