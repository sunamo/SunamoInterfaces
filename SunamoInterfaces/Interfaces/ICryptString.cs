namespace SunamoInterfaces.Interfaces;

public interface ICryptString
{
    string Decrypt(string text);

    string Encrypt(string text);
}
