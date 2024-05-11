
namespace
#if SunamoCrypt
SunamoCrypt
#else
SunamoInterfaces
#endif
;
public interface ICryptString
{
    string Decrypt(string v);
    string Encrypt(string v);
}