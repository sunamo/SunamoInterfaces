
namespace SunamoInterfaces;
public interface IPowershellParser
{
    List<string> ParseToParts(string d, string charWhichIsNotContained);
}
