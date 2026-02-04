namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for generating formatted text output.
/// </summary>
public interface ITextOutputGenerator
{
    /// <summary>
    /// Gets or sets the string to prepend to every non-whitespace line.
    /// </summary>
    string PrependEveryNoWhite { get; set; }

    /// <summary>
    /// Adds a bullet point with key-value pair.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    void PairBullet(string key, string value);
    /// <summary>
    /// Appends text to the output.
    /// </summary>
    /// <param name="text">The text to append.</param>
    void Append(string text);

    /// <summary>
    /// Appends formatted text to the output.
    /// </summary>
    /// <param name="text">The format string.</param>
    /// <param name="parameters">The parameters for the format string.</param>
    void AppendFormat(string text, params string[] parameters);

    /// <summary>
    /// Appends a new line to the output.
    /// </summary>
    void AppendLine();

    /// <summary>
    /// Appends text followed by a new line.
    /// </summary>
    /// <param name="text">The text to append.</param>
    void AppendLine(string text);

    /// <summary>
    /// Appends a StringBuilder's content followed by a new line.
    /// </summary>
    /// <param name="text">The StringBuilder to append.</param>
    void AppendLine(StringBuilder text);

    /// <summary>
    /// Appends formatted text followed by a new line.
    /// </summary>
    /// <param name="text">The format string.</param>
    /// <param name="parameters">The parameters for the format string.</param>
    void AppendLineFormat(string text, params string[] parameters);
    /// <summary>
    /// Outputs count of every item in the list.
    /// </summary>
    /// <typeparam name="T">The type of the key.</typeparam>
    /// <param name="items">The items with their counts.</param>
    void CountEvery<T>(IList<KeyValuePair<T, int>> items);

    /// <summary>
    /// Outputs a dictionary of string keys to int values.
    /// </summary>
    /// <param name="charEntity">The dictionary to output.</param>
    /// <param name="delimiter">The delimiter to use.</param>
    void Dictionary(Dictionary<string, int> charEntity, string delimiter);

    /// <summary>
    /// Outputs a dictionary of string keys to string list values.
    /// </summary>
    /// <param name="dictionary">The dictionary to output.</param>
    void Dictionary(Dictionary<string, List<string>> dictionary);

    /// <summary>
    /// Outputs a dictionary of string keys to string values.
    /// </summary>
    /// <param name="dictionary">The dictionary to output.</param>
    void Dictionary(Dictionary<string, string> dictionary);

    /// <summary>
    /// Outputs a generic dictionary with headers and value lists.
    /// </summary>
    /// <typeparam name="Header">The header type implementing IEnumerable of char.</typeparam>
    /// <typeparam name="Value">The value type.</typeparam>
    /// <param name="dictionary">The dictionary to output.</param>
    /// <param name="isOnlyCountingInValue">Whether to only count values.</param>
    void Dictionary<Header, Value>(Dictionary<Header, List<Value>> dictionary, bool isOnlyCountingInValue = false)
        where Header : IEnumerable<char>;

    /// <summary>
    /// Outputs a generic dictionary with custom delimiter.
    /// </summary>
    /// <typeparam name="T1">The key type.</typeparam>
    /// <typeparam name="T2">The value type.</typeparam>
    /// <param name="dictionary">The dictionary to output.</param>
    /// <param name="delimiter">The delimiter to use.</param>
    void Dictionary<T1, T2>(Dictionary<T1, T2> dictionary, string delimiter = "|") where T1 : notnull;

    /// <summary>
    /// Converts dictionary to a single line string representation.
    /// </summary>
    /// <typeparam name="Key">The key type.</typeparam>
    /// <typeparam name="Value">The value type.</typeparam>
    /// <param name="sorted">The sorted dictionary.</param>
    /// <param name="isPuttingValueAsFirst">Whether to put value before key.</param>
    /// <param name="delimiter">The delimiter to use.</param>
    /// <returns>The single line representation.</returns>
    string DictionaryBothToStringToSingleLine<Key, Value>(Dictionary<Key, Value> sorted, bool isPuttingValueAsFirst,
        string delimiter = " ") where Key : notnull;

    /// <summary>
    /// Outputs an ordered dictionary of key-value pairs with a header.
    /// </summary>
    /// <typeparam name="T1">The key type.</typeparam>
    /// <typeparam name="T2">The value type.</typeparam>
    /// <param name="header">The header text.</param>
    /// <param name="ordered">The ordered key-value pairs.</param>
    void DictionaryKeyValuePair<T1, T2>(string header, IOrderedEnumerable<KeyValuePair<T1, T2>> ordered);

    /// <summary>
    /// Ends the runtime measurement.
    /// </summary>
    void EndRunTime();

    /// <summary>
    /// Outputs a header.
    /// </summary>
    /// <param name="headerText">The header text.</param>
    void Header(string headerText);

    /// <summary>
    /// Outputs a list of strings.
    /// </summary>
    /// <param name="list">The list to output.</param>
    void List(IList<string> list);

    /// <summary>
    /// Outputs a list of strings with a header.
    /// </summary>
    /// <param name="list">The list to output.</param>
    /// <param name="header">The header text.</param>
    void List(IList<string> list, string header);

    /// <summary>
    /// Outputs a typed list with a generic header.
    /// </summary>
    /// <typeparam name="Header">The header type implementing IEnumerable of char.</typeparam>
    /// <typeparam name="Value">The value type.</typeparam>
    /// <param name="list">The list to output.</param>
    /// <param name="header">The header.</param>
    void List<Header, Value>(IList<Value> list, Header header) where Header : IEnumerable<char>;

    /// <summary>
    /// Outputs a typed list with a generic header and generator arguments.
    /// </summary>
    /// <typeparam name="Header">The header type implementing IEnumerable of char.</typeparam>
    /// <typeparam name="Value">The value type.</typeparam>
    /// <param name="list">The list to output.</param>
    /// <param name="header">The header.</param>
    /// <param name="textOutputGeneratorArgs">Additional generator arguments.</param>
    void List<Header, Value>(IList<Value> list, Header header, object textOutputGeneratorArgs)
        where Header : IEnumerable<char>;

    /// <summary>
    /// Outputs a generic list with custom delimiter.
    /// </summary>
    /// <typeparam name="Value">The value type.</typeparam>
    /// <param name="list">The list to output.</param>
    /// <param name="delimiter">The delimiter to use.</param>
    /// <param name="whenNoEntries">Text to show when list is empty.</param>
    void List<Value>(IList<Value> list, string delimiter = "\r\n", string whenNoEntries = "");

    /// <summary>
    /// Outputs a non-generic list of objects.
    /// </summary>
    /// <param name="list">The list to output.</param>
    void ListObject(IList list);

    /// <summary>
    /// Outputs a StringBuilder as a list with a value.
    /// </summary>
    /// <param name="stringBuilder">The StringBuilder to output.</param>
    /// <param name="value">The value to append.</param>
    void ListSB(StringBuilder stringBuilder, string value);

    /// <summary>
    /// Outputs a string list with a header.
    /// </summary>
    /// <param name="list">The list string to output.</param>
    /// <param name="header">The header text.</param>
    void ListString(string list, string header);

    /// <summary>
    /// Outputs a "No data" message.
    /// </summary>
    void NoData();

    /// <summary>
    /// Outputs a paragraph with a header.
    /// </summary>
    /// <param name="text">The paragraph text.</param>
    /// <param name="header">The header text.</param>
    void Paragraph(string text, string header);

    /// <summary>
    /// Outputs a paragraph from StringBuilder with a header.
    /// </summary>
    /// <param name="content">The paragraph content.</param>
    /// <param name="header">The header text.</param>
    void Paragraph(StringBuilder content, string header);

    /// <summary>
    /// Outputs a line of repeated characters.
    /// </summary>
    /// <param name="paddingChar">The character to repeat.</param>
    /// <param name="count">The number of times to repeat the character.</param>
    void SingleCharLine(char paddingChar, int count);

    /// <summary>
    /// Starts runtime measurement with a description.
    /// </summary>
    /// <param name="text">The description text.</param>
    void StartRunTime(string text);

    /// <summary>
    /// Converts the generated output to a string.
    /// </summary>
    /// <returns>The generated output as a string.</returns>
    string ToString();

    /// <summary>
    /// Undoes the last append operation.
    /// </summary>
    void Undo();
}