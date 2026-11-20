namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i crypt string type.
/// </summary>
public interface ICryptString
{
    /// <summary>
    /// Decrypt.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The decrypt result.</returns>
    string Decrypt(string text);

    /// <summary>
    /// Encrypt.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The encrypt result.</returns>
    string Encrypt(string text);
}
