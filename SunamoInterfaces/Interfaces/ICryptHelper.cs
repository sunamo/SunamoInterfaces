namespace SunamoInterfaces.Interfaces;

public interface ICryptHelper
{
    List<byte> Decrypt(List<byte> data);

    List<byte> Encrypt(List<byte> data);
}
