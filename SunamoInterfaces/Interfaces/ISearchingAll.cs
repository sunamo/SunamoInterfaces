namespace SunamoInterfaces.Interfaces;

public interface ISearchingAll<T>
{
    List<T> Search(string searchTerm);

    void ValidateAll();

    List<string> Names();

    List<T> PasswordKeys();
}
