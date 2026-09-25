namespace SunamoInterfaces.Interfaces;

public interface IParseCollection
{
    // Parses collection from list of strings.
    // For reverse process use ToString() method.
    // Parameter must be list due to parsing by indexes.
    void ParseCollection(List<string> lines);
}
