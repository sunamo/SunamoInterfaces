
namespace
#if SunamoCrypt
SunamoCrypt
#else
SunamoInterfacesInterfaces
#endif
;
public interface ICryptBytes : ICrypt
{
    List<byte> Decrypt(List<byte> v);
    List<byte> Encrypt(List<byte> v);
}