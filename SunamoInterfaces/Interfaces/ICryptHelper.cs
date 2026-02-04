namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for cryptographic helper operations with byte lists.
/// </summary>
public interface ICryptHelper
{
    /// <summary>
    /// Decrypts byte data.
    /// </summary>
    /// <param name="data">The encrypted data.</param>
    /// <returns>Decrypted data.</returns>
    List<byte> Decrypt(List<byte> data);

    /// <summary>
    /// Encrypts byte data.
    /// </summary>
    /// <param name="data">The data to encrypt.</param>
    /// <returns>Encrypted data.</returns>
    List<byte> Encrypt(List<byte> data);
}