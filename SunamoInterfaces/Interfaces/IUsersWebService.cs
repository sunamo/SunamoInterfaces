namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for user web service operations.
/// </summary>
public interface IUsersWebService
{
    /// <summary>
    /// Gets the odd-indexed characters of the hash for the specified login.
    /// </summary>
    /// <param name="login">The user login.</param>
    /// <returns>The odd-indexed hash characters.</returns>
    string GetOddIndexesOfHash(string login);

    /// <summary>
    /// Verifies if the login and password pair is valid.
    /// </summary>
    /// <param name="login">The user login.</param>
    /// <param name="password">The user password.</param>
    /// <param name="function">The function code output.</param>
    /// <param name="dataPhoneHash">The phone data hash output.</param>
    /// <returns>True if the login and password are valid; otherwise, false.</returns>
    bool IsPairLoginAndPw(string login, string password, out int function, out string dataPhoneHash);

    /// <summary>
    /// Gets the name of the user with the specified ID.
    /// </summary>
    /// <param name="userId">The user ID.</param>
    /// <returns>The user name.</returns>
    string NameOfUserWithID(int userId);
}