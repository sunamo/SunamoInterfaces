namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for number-string conversion operations.
/// </summary>
public interface IConvertNumberString
{
    /// <summary>
    /// Converts string to number.
    /// </summary>
    /// <param name="text">The text to convert.</param>
    /// <returns>The number.</returns>
    int ToNumber(string text);

    /// <summary>
    /// Converts number to string.
    /// </summary>
    /// <param name="number">The number to convert.</param>
    /// <returns>String representation.</returns>
    string ToString(int number);
}