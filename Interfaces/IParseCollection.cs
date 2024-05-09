
namespace SunamoInterfaces.Interfaces;
public interface IParseCollection
{
    /// <summary>
    /// Pro opacny proces slouzi M ToString().
    /// A1 must be list due to parse by indexes
    /// </summary>
    void ParseCollection(List<string> s);
}