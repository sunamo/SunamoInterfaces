namespace
#if SunamoCrypt
SunamoCrypt
#else
SunamoInterfaces
#endif
;
public interface ICryptHelper
{
    List<byte> Decrypt(List<byte> v);
    List<byte> Encrypt(List<byte> v);
}