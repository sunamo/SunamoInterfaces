namespace SunamoInterfaces.Interfaces;

public interface IUsersWebService
{
    string GetOddIndexesOfHash(string login);

    bool IsPairLoginAndPw(string login, string password, out int function, out string dataPhoneHash);

    string NameOfUserWithID(int userId);
}
