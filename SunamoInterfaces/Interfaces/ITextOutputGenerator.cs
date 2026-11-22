namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i text output generator type.
/// </summary>
public interface ITextOutputGenerator
{
    /// <summary>
    /// Gets or sets the prepend every no white.
    /// </summary>
    string PrependEveryNoWhite { get; set; }

    /// <summary>
    /// Pair bullet.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <returns>The pair bullet result.</returns>
    void PairBullet(string key, string value);

    /// <summary>
    /// Append.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    void Append(string text);

    /// <summary>
    /// Append format.
    /// </summary>
    /// <param name="text">The text.</param>
    void AppendFormat(string text, params string[] parameters);

    /// <summary>
    /// Append line.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="parameters">The parameters.</param>
    void AppendLine();

    /// <summary>
    /// Append line.
    /// </summary>
    void AppendLine(string text);

    /// <summary>
    /// Append line.
    /// </summary>
    /// <param name="text">The text.</param>
    void AppendLine(StringBuilder stringBuilder);

    /// <summary>
    /// Append line format.
    /// </summary>
    /// <param name="stringBuilder">The string builder.</param>
    void AppendLineFormat(string text, params string[] parameters);

    /// <summary>
    /// Count every t.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="parameters">The parameters.</param>
    void CountEvery<T>(IList<KeyValuePair<T, int>> list);

    /// <summary>
    /// Dictionary.
    /// </summary>
    /// <typeparam name="T">The type T.</typeparam>
    /// <param name="list">The list.</param>
    void Dictionary(Dictionary<string, int> dictionary, string delimiter);

    /// <summary>
    /// Dictionary.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    /// <param name="delimiter">The delimiter.</param>
    void Dictionary(Dictionary<string, List<string>> dictionary);

    /// <summary>
    /// Dictionary.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    void Dictionary(Dictionary<string, string> dictionary);

    /// <summary>
    /// Dictionary header value.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    void Dictionary<Header, Value>(Dictionary<Header, List<Value>> dictionary, bool isOnlyCountingInValue = false)
        where Header : IEnumerable<char>;

    /// <summary>
    /// Dictionary t 1 t 2.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    /// <param name="isOnlyCountingInValue">The is only counting in value.</param>
    /// <returns>The dictionary t 1 t 2 result.</returns>
    void Dictionary<T1, T2>(Dictionary<T1, T2> dictionary, string delimiter = "|") where T1 : notnull;

    /// <summary>
    /// Dictionary both to string to single line key value.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    /// <param name="delimiter">The delimiter.</param>
    /// <returns>The dictionary both to string to single line key value result.</returns>
    string DictionaryBothToStringToSingleLine<Key, Value>(Dictionary<Key, Value> dictionary, bool isPuttingValueAsFirst,
        string delimiter = " ") where Key : notnull;

    /// <summary>
    /// Dictionary key value pair t 1 t 2.
    /// </summary>
    /// <param name="dictionary">The dictionary.</param>
    /// <param name="isPuttingValueAsFirst">The is putting value as first.</param>
    /// <param name="delimiter">The delimiter.</param>
    /// <returns>The dictionary key value pair t 1 t 2 result.</returns>
    void DictionaryKeyValuePair<T1, T2>(string header, IOrderedEnumerable<KeyValuePair<T1, T2>> ordered);

    /// <summary>
    /// End run time.
    /// </summary>
    /// <param name="header">The header.</param>
    /// <param name="ordered">The ordered.</param>
    /// <returns>The end run time result.</returns>
    void EndRunTime();

    /// <summary>
    /// Header.
    /// </summary>
    void Header(string header);

    /// <summary>
    /// List.
    /// </summary>
    /// <param name="header">The header.</param>
    void List(IList<string> list);

    /// <summary>
    /// List.
    /// </summary>
    /// <param name="list">The list.</param>
    void List(IList<string> list, string header);

    /// <summary>
    /// List header value.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="header">The header.</param>
    void List<Header, Value>(IList<Value> list, Header header) where Header : IEnumerable<char>;

    /// <summary>
    /// List header value.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="header">The header.</param>
    /// <returns>The list header value result.</returns>
    void List<Header, Value>(IList<Value> list, Header header, object textOutputGeneratorArgs)
        where Header : IEnumerable<char>;

    /// <summary>
    /// List value.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="header">The header.</param>
    /// <param name="textOutputGeneratorArgs">The text output generator args.</param>
    /// <returns>The list value result.</returns>
    void List<Value>(IList<Value> list, string delimiter = "\r\n", string whenNoEntries = "");

    /// <summary>
    /// List object.
    /// </summary>
    /// <typeparam name="Value">The type Value.</typeparam>
    /// <param name="list">The list.</param>
    /// <param name="delimiter">The delimiter.</param>
    /// <param name="whenNoEntries">The when no entries.</param>
    void ListObject(IList list);

    /// <summary>
    /// List SB.
    /// </summary>
    /// <param name="list">The list.</param>
    void ListSB(StringBuilder stringBuilder, string value);

    /// <summary>
    /// List string.
    /// </summary>
    /// <param name="stringBuilder">The string builder.</param>
    /// <param name="value">The value.</param>
    void ListString(string text, string header);

    /// <summary>
    /// No data.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="header">The header.</param>
    void NoData();

    /// <summary>
    /// Paragraph.
    /// </summary>
    void Paragraph(string text, string header);

    /// <summary>
    /// Paragraph.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="header">The header.</param>
    void Paragraph(StringBuilder stringBuilder, string header);

    /// <summary>
    /// Single char line.
    /// </summary>
    /// <param name="stringBuilder">The string builder.</param>
    /// <param name="header">The header.</param>
    void SingleCharLine(char paddingChar, int count);

    /// <summary>
    /// Start run time.
    /// </summary>
    /// <param name="paddingChar">The padding char.</param>
    /// <param name="count">The count.</param>
    void StartRunTime(string text);

    /// <summary>
    /// To string.
    /// </summary>
    /// <param name="text">The text.</param>
    string ToString();

    /// <summary>
    /// Undo.
    /// </summary>
    /// <returns>The undo result.</returns>
    void Undo();
}
