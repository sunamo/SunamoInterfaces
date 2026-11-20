namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i users web service type.
/// </summary>
public interface IUsersWebService
{
    /// <summary>
    /// Get odd indexes of hash.
    /// </summary>
    /// <param name="login">The login.</param>
    /// <returns>The get odd indexes of hash result.</returns>
    string GetOddIndexesOfHash(string login);

    /// <summary>
    /// Is pair login and pw.
    /// </summary>
    /// <param name="login">The login.</param>
    /// <param name="password">The password.</param>
    /// <param name="function">The function.</param>
    /// <param name="dataPhoneHash">The data phone hash.</param>
    /// <returns>The is pair login and pw result.</returns>
    bool IsPairLoginAndPw(string login, string password, out int function, out string dataPhoneHash);

    /// <summary>
    /// Name of user with ID.
    /// </summary>
    /// <param name="userId">The user id.</param>
    /// <returns>The name of user with ID result.</returns>
    string NameOfUserWithID(int userId);
}
