namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for YouTube API constants and credentials.
/// </summary>
public interface IYouTubeConsts
{
    /// <summary>
    /// Gets the list of GData YouTube API keys.
    /// </summary>
    List<string> GDataYoutubeApiKeys { get; }

    /// <summary>
    /// Gets the secret credential.
    /// </summary>
    string Secret { get; }
}