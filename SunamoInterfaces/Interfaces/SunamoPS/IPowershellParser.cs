namespace SunamoInterfaces.Interfaces.SunamoPS;

/// <summary>
/// Interface for PowerShell parsing operations.
/// </summary>
public interface IPowershellParser
{
    /// <summary>
    /// Parses text into parts using a delimiter character.
    /// </summary>
    /// <param name="text">The text to parse.</param>
    /// <param name="charWhichIsNotContained">The delimiter character that is not contained in the parts.</param>
    /// <returns>List of parsed parts.</returns>
    List<string> ParseToParts(string text, string charWhichIsNotContained);
}