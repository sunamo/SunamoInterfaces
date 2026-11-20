namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i parser ext t type.
/// </summary>
public interface IParserExt<T>
{
    /// <summary>
    /// Parse.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The parse result.</returns>
    T Parse(string text);
}
