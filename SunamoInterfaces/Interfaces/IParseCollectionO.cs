namespace SunamoInterfaces.Interfaces;

public interface IParseCollectionO
{
    // Parses collection from list of objects.
    // For reverse process use ToString() method.
    void ParseCollection(IList<object> list);
}
