namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for convention conversion operations.
/// </summary>
public interface IConvertConvention
{
    /// <summary>
    /// Converts from convention format.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>Converted text.</returns>
    string FromConvention(string text);

    /// <summary>
    /// Converts to convention format.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>Converted text.</returns>
    string ToConvention(string text);
}