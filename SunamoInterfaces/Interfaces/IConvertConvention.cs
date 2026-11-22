namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i convert convention type.
/// </summary>
public interface IConvertConvention
{
    /// <summary>
    /// From convention.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The from convention result.</returns>
    string FromConvention(string text);

    /// <summary>
    /// To convention.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The to convention result.</returns>
    string ToConvention(string text);
}
