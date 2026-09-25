namespace SunamoInterfaces.Interfaces;

public interface ITextOutputGenerator
{
    string PrependEveryNoWhite { get; set; }

    void PairBullet(string key, string value);

    void Append(string text);

    void AppendFormat(string text, params string[] parameters);

    void AppendLine();

    void AppendLine(string text);

    void AppendLine(StringBuilder stringBuilder);

    void AppendLineFormat(string text, params string[] parameters);

    void CountEvery<T>(IList<KeyValuePair<T, int>> list);

    void Dictionary(Dictionary<string, int> dictionary, string delimiter);

    void Dictionary(Dictionary<string, List<string>> dictionary);

    void Dictionary(Dictionary<string, string> dictionary);

    void Dictionary<Header, Value>(Dictionary<Header, List<Value>> dictionary, bool isOnlyCountingInValue = false)
        where Header : IEnumerable<char>;

    void Dictionary<T1, T2>(Dictionary<T1, T2> dictionary, string delimiter = "|") where T1 : notnull;

    string DictionaryBothToStringToSingleLine<Key, Value>(Dictionary<Key, Value> dictionary, bool isPuttingValueAsFirst,
        string delimiter = " ") where Key : notnull;

    void DictionaryKeyValuePair<T1, T2>(string header, IOrderedEnumerable<KeyValuePair<T1, T2>> ordered);

    void EndRunTime();

    void Header(string header);

    void List(IList<string> list);

    void List(IList<string> list, string header);

    void List<Header, Value>(IList<Value> list, Header header) where Header : IEnumerable<char>;

    void List<Header, Value>(IList<Value> list, Header header, object textOutputGeneratorArgs)
        where Header : IEnumerable<char>;

    void List<Value>(IList<Value> list, string delimiter = "\r\n", string whenNoEntries = "");

    void ListObject(IList list);

    void ListSB(StringBuilder stringBuilder, string value);

    void ListString(string text, string header);

    void NoData();

    void Paragraph(string text, string header);

    void Paragraph(StringBuilder stringBuilder, string header);

    void SingleCharLine(char paddingChar, int count);

    void StartRunTime(string text);

    string ToString();

    void Undo();
}
