namespace SunamoInterfaces.Interfaces;

public interface IParseCollectionIndexes
{
    // Parses collection from list of strings using specified indexes.
    // For reverse process use ToString() method.
    // Parameter must be list due to parsing by indexes.
    void ParseCollection(List<string> lines, params int[] indexes);
}
