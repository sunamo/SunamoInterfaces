namespace SunamoInterfaces.Interfaces;
public interface ICryptHelper
{
    List<byte> Decrypt(List<byte> v);
    List<byte> Encrypt(List<byte> v);
}
