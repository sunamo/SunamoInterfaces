namespace SunamoInterfaces.Interfaces;

public interface ILoginManager
{
    Func<string, string> DoWebRequest { get; set; }

    Func<string, ExternalLoginResult> DeserializeJson { get; set; }

    bool PairLoginAndPassword(string messageSuccessfullyLoggedIn, Func<string, string> encryptPasswordToBase64,
        string login, string password, string hostWithSlash, bool isShowingOnUserRequest = false);
}
