namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for generating XML content.
/// </summary>
public interface IXmlGenerator
{
    /// <summary>
    /// Appends a new line to the XML output.
    /// </summary>
    void AppendLine();

    /// <summary>
    /// Ends an XML comment.
    /// </summary>
    void EndComment();

    /// <summary>
    /// Inserts text at the specified index.
    /// </summary>
    /// <param name="index">The index at which to insert.</param>
    /// <param name="text">The text to insert.</param>
    void Insert(int index, string text);

    /// <summary>
    /// Gets the length of the generated XML.
    /// </summary>
    /// <returns>The length of the XML content.</returns>
    int Length();

    /// <summary>
    /// Starts an XML comment.
    /// </summary>
    void StartComment();

    /// <summary>
    /// Terminates (closes) an XML tag.
    /// </summary>
    /// <param name="tagName">The name of the tag to terminate.</param>
    void TerminateTag(string tagName);

    /// <summary>
    /// Converts the generated XML to a string.
    /// </summary>
    /// <returns>The XML content as a string.</returns>
    string ToString();

    /// <summary>
    /// Writes a CDATA section.
    /// </summary>
    /// <param name="innerCData">The content of the CDATA section.</param>
    void WriteCData(string innerCData);

    /// <summary>
    /// Writes an XML element with inner content.
    /// </summary>
    /// <param name="elementName">The element name.</param>
    /// <param name="inner">The inner content.</param>
    void WriteElement(string elementName, string inner);

    /// <summary>
    /// Writes a self-closing (non-pair) XML tag.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    void WriteNonPairTag(string tagName);

    /// <summary>
    /// Writes a self-closing tag with two attributes.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="firstName">The first attribute name.</param>
    /// <param name="firstValue">The first attribute value.</param>
    /// <param name="secondName">The second attribute name.</param>
    /// <param name="secondValue">The second attribute value.</param>
    void WriteNonPairTagWith2Attrs(string tagName, string firstName, string firstValue, string secondName, string secondValue);

    /// <summary>
    /// Writes a self-closing tag with one attribute.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attrName">The attribute name.</param>
    /// <param name="attrValue">The attribute value.</param>
    void WriteNonPairTagWithAttr(string tagName, string attrName, string attrValue);

    /// <summary>
    /// Writes a self-closing tag with multiple attributes, optionally appending null attributes.
    /// </summary>
    /// <param name="appendNull">Whether to append null attributes.</param>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes as name-value pairs.</param>
    void WriteNonPairTagWithAttrs(bool appendNull, string tagName, params string[] attributes);

    /// <summary>
    /// Writes a self-closing tag with attributes from a list.
    /// </summary>
    /// <param name="tag">The tag name.</param>
    /// <param name="attributes">The list of attributes as name-value pairs.</param>
    void WriteNonPairTagWithAttrs(string tag, List<string> attributes);

    /// <summary>
    /// Writes a self-closing tag with multiple attributes.
    /// </summary>
    /// <param name="tag">The tag name.</param>
    /// <param name="attributes">The attributes as name-value pairs.</param>
    void WriteNonPairTagWithAttrs(string tag, params string[] attributes);

    /// <summary>
    /// Writes raw XML content without escaping.
    /// </summary>
    /// <param name="rawContent">The raw content to write.</param>
    void WriteRaw(string rawContent);

    /// <summary>
    /// Writes an opening XML tag.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    void WriteTag(string tagName);

    /// <summary>
    /// Writes a tag with namespace manager and element.
    /// </summary>
    /// <param name="element">The element object.</param>
    /// <param name="namespaceManager">The namespace manager.</param>
    /// <param name="namespaceUri">The namespace URI.</param>
    /// <param name="prefix">The namespace prefix.</param>
    void WriteTagNamespaceManager(object element, XmlNamespaceManager namespaceManager, string namespaceUri, string prefix);

    /// <summary>
    /// Writes a tag with namespace manager and attributes.
    /// </summary>
    /// <param name="nameTag">The tag name.</param>
    /// <param name="namespaceManager">The namespace manager.</param>
    /// <param name="attributes">The attributes as name-value pairs.</param>
    void WriteTagNamespaceManager(string nameTag, XmlNamespaceManager namespaceManager, params string[] attributes);

    /// <summary>
    /// Writes an opening tag with two attributes.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="firstName">The first attribute name.</param>
    /// <param name="firstValue">The first attribute value.</param>
    /// <param name="secondName">The second attribute name.</param>
    /// <param name="secondValue">The second attribute value.</param>
    void WriteTagWith2Attrs(string tagName, string firstName, string firstValue, string secondName, string secondValue);

    /// <summary>
    /// Writes an opening tag with one attribute, optionally skipping if empty or null.
    /// </summary>
    /// <param name="tag">The tag name.</param>
    /// <param name="attributeName">The attribute name.</param>
    /// <param name="attributeValue">The attribute value.</param>
    /// <param name="skipEmptyOrNull">Whether to skip if attribute value is empty or null.</param>
    void WriteTagWithAttr(string tag, string attributeName, string attributeValue, bool skipEmptyOrNull = false);

    /// <summary>
    /// Writes an opening tag with attributes from a list.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The list of attributes as name-value pairs.</param>
    void WriteTagWithAttrs(string tagName, List<string> attributes);

    /// <summary>
    /// Writes an opening tag with multiple attributes.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes as name-value pairs.</param>
    void WriteTagWithAttrs(string tagName, params string[] attributes);

    /// <summary>
    /// Writes an opening tag with attributes, checking for null values.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes as name-value pairs.</param>
    void WriteTagWithAttrsCheckNull(string tagName, params string[] attributes);

    /// <summary>
    /// Writes the XML declaration.
    /// </summary>
    void WriteXmlDeclaration();
}