namespace SunamoInterfaces.Interfaces;

public interface ICryptString
{
    string Decrypt(string v);
    string Encrypt(string v);
}