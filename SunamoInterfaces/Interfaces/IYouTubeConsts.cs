namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i you tube consts type.
/// </summary>
public interface IYouTubeConsts
{
    /// <summary>
    /// Gets the g data youtube api keys.
    /// </summary>
    List<string> GDataYoutubeApiKeys { get; }

    /// <summary>
    /// Gets the secret.
    /// </summary>
    string Secret { get; }
}
