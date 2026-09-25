namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for cryptographic string operations.
/// </summary>
public interface ICryptString
{
    /// <summary>
    /// Decrypts the specified text.
    /// </summary>
    /// <param name="text">The encrypted text to decrypt.</param>
    /// <returns>The decrypted text.</returns>
    string Decrypt(string text);

    /// <summary>
    /// Encrypts the specified text.
    /// </summary>
    /// <param name="text">The text to encrypt.</param>
    /// <returns>The encrypted text.</returns>
    string Encrypt(string text);
}