
namespace
#if SunamoCrypt
SunamoCrypt
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;
public interface ICryptString
{
    string Decrypt(string v);
    string Encrypt(string v);
}