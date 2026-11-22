namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i login manager type.
/// </summary>
public interface ILoginManager
{
    /// <summary>
    /// Gets or sets the do web request.
    /// </summary>
    Func<string, string> DoWebRequest { get; set; }

    /// <summary>
    /// Gets or sets the deserialize json.
    /// </summary>
    Func<string, ExternalLoginResult> DeserializeJson { get; set; }

    /// <summary>
    /// Pair login and password.
    /// </summary>
    /// <param name="messageSuccessfullyLoggedIn">The message successfully logged in.</param>
    /// <param name="encryptPasswordToBase64">The encrypt password to base 64.</param>
    /// <param name="login">The login.</param>
    /// <param name="password">The password.</param>
    /// <param name="hostWithSlash">The host with slash.</param>
    /// <param name="isShowingOnUserRequest">The is showing on user request.</param>
    /// <returns>The pair login and password result.</returns>
    bool PairLoginAndPassword(string messageSuccessfullyLoggedIn, Func<string, string> encryptPasswordToBase64,
        string login, string password, string hostWithSlash, bool isShowingOnUserRequest = false);
}
