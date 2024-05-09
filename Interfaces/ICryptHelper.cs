
namespace
#if SunamoCrypt
SunamoCrypt
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;
public interface ICryptHelper
{
    List<byte> Decrypt(List<byte> v);
    List<byte> Encrypt(List<byte> v);
}