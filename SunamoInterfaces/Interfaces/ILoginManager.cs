namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for managing user login operations.
/// </summary>
public interface ILoginManager
{
    /// <summary>
    /// Gets or sets the function for performing web requests.
    /// </summary>
    Func<string, string> DoWebRequest { get; set; }

    /// <summary>
    /// Gets or sets the function for deserializing JSON to ExternalLoginResult.
    /// </summary>
    Func<string, ExternalLoginResult> DeserializeJson { get; set; }

    /// <summary>
    /// Pairs a login and password for authentication.
    /// </summary>
    /// <param name="messageSuccessfullyLoggedIn">The message to display on successful login.</param>
    /// <param name="encryptPasswordToBase64">Function to encrypt password to Base64.</param>
    /// <param name="login">The login username.</param>
    /// <param name="password">The password.</param>
    /// <param name="hostWithSlash">The host URL with trailing slash.</param>
    /// <param name="isShowingOnUserRequest">Whether to show the result on user request.</param>
    /// <returns>True if login was successful; otherwise, false.</returns>
    bool PairLoginAndPassword(string messageSuccessfullyLoggedIn, Func<string, string> encryptPasswordToBase64,
        string login, string password, string hostWithSlash, bool isShowingOnUserRequest = false);
}