public interface IParseCollection<T>
{
    /// <summary>
    /// Pro opacny proces slouzi M ToString().
    /// </summary>
    void ParseCollection(IList<T> soubory);
}