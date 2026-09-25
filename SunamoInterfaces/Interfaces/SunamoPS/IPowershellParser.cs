namespace SunamoInterfaces.Interfaces.SunamoPS;

public interface IPowershellParser
{
    List<string> ParseToParts(string text, string delimiter);
}
