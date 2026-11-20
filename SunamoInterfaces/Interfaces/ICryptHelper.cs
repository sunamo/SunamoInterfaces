namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i crypt helper type.
/// </summary>
public interface ICryptHelper
{
    /// <summary>
    /// Decrypt.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The decrypt result.</returns>
    List<byte> Decrypt(List<byte> data);

    /// <summary>
    /// Encrypt.
    /// </summary>
    /// <param name="data">The data.</param>
    /// <returns>The encrypt result.</returns>
    List<byte> Encrypt(List<byte> data);
}
