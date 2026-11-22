namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i convert number string type.
/// </summary>
public interface IConvertNumberString
{
    /// <summary>
    /// To number.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The to number result.</returns>
    int ToNumber(string text);

    /// <summary>
    /// To string.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns>The to string result.</returns>
    string ToString(int number);
}
