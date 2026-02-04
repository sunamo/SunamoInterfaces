namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for Czech-English language conversion.
/// </summary>
public interface IConvertCzechEnglish
{
    /// <summary>
    /// Converts English text to Czech.
    /// </summary>
    /// <param name="english">The English text.</param>
    /// <returns>Czech text.</returns>
    string ToCzech(string english);

    /// <summary>
    /// Converts Czech text to English.
    /// </summary>
    /// <param name="czech">The Czech text.</param>
    /// <returns>English text.</returns>
    string ToEnglish(string czech);
}