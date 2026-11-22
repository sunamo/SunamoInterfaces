namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i convert czech english type.
/// </summary>
public interface IConvertCzechEnglish
{
    /// <summary>
    /// To czech.
    /// </summary>
    /// <param name="english">The english.</param>
    /// <returns>The to czech result.</returns>
    string ToCzech(string english);

    /// <summary>
    /// To english.
    /// </summary>
    /// <param name="czech">The czech.</param>
    /// <returns>The to english result.</returns>
    string ToEnglish(string czech);
}
