namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i random t type.
/// </summary>
public interface IRandom<T>
{
    /// <summary>
    /// Gets the length of password key.
    /// </summary>
    int LengthOfPasswordKey { get; }
    /// <summary>
    /// Get random.
    /// </summary>
    /// <returns>The get random result.</returns>
    T GetRandom();
}
