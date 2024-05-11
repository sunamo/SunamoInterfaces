namespace SunamoInterfaces;

public interface IAsyncFile
{
    Task<string> ReadAllTextAsync(string s);
}
