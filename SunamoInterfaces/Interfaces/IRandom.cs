namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for generating random values of type T.
/// </summary>
/// <typeparam name="T">The type of random value to generate.</typeparam>
public interface IRandom<T>
{
    /// <summary>
    /// Gets the length of the password key.
    /// </summary>
    int LengthOfPasswordKey { get; }

    /// <summary>
    /// Gets a random value.
    /// </summary>
    /// <returns>Random value of type T.</returns>
    T GetRandom();
}