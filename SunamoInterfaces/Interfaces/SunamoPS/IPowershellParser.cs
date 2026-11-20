namespace SunamoInterfaces.Interfaces.SunamoPS;

/// <summary>
/// Represents the i powershell parser type.
/// </summary>
public interface IPowershellParser
{
    /// <summary>
    /// Parse to parts.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="delimiter">The delimiter.</param>
    /// <returns>The parse to parts result.</returns>
    List<string> ParseToParts(string text, string delimiter);
}
