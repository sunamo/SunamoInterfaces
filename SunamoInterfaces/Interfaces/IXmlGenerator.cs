namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i xml generator type.
/// </summary>
public interface IXmlGenerator
{
    /// <summary>
    /// Append line.
    /// </summary>
    void AppendLine();

    /// <summary>
    /// End comment.
    /// </summary>
    void EndComment();

    /// <summary>
    /// Insert.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <param name="text">The text.</param>
    void Insert(int index, string text);

    /// <summary>
    /// Length.
    /// </summary>
    /// <returns>The length result.</returns>
    int Length();

    /// <summary>
    /// Start comment.
    /// </summary>
    void StartComment();

    /// <summary>
    /// Terminate tag.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    void TerminateTag(string tagName);

    /// <summary>
    /// To string.
    /// </summary>
    /// <returns>The to string result.</returns>
    string ToString();

    /// <summary>
    /// Write c data.
    /// </summary>
    /// <param name="content">The content.</param>
    void WriteCData(string content);

    /// <summary>
    /// Write element.
    /// </summary>
    /// <param name="elementName">The element name.</param>
    /// <param name="content">The content.</param>
    void WriteElement(string elementName, string content);

    /// <summary>
    /// Write non pair tag.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    void WriteNonPairTag(string tagName);

    /// <summary>
    /// Write non pair tag with 2 attrs.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="firstName">The first name.</param>
    /// <param name="firstValue">The first value.</param>
    /// <param name="secondName">The second name.</param>
    /// <param name="secondValue">The second value.</param>
    void WriteNonPairTagWith2Attrs(string tagName, string firstName, string firstValue, string secondName, string secondValue);

    /// <summary>
    /// Write non pair tag with attr.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attrName">The attr name.</param>
    /// <param name="attrValue">The attr value.</param>
    void WriteNonPairTagWithAttr(string tagName, string attrName, string attrValue);

    /// <summary>
    /// Write non pair tag with attrs.
    /// </summary>
    /// <param name="isAppendingNull">The is appending null.</param>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes.</param>
    void WriteNonPairTagWithAttrs(bool isAppendingNull, string tagName, params string[] attributes);

    /// <summary>
    /// Write non pair tag with attrs.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes.</param>
    void WriteNonPairTagWithAttrs(string tagName, List<string> attributes);

    /// <summary>
    /// Write non pair tag with attrs.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes.</param>
    void WriteNonPairTagWithAttrs(string tagName, params string[] attributes);

    /// <summary>
    /// Write raw.
    /// </summary>
    /// <param name="content">The content.</param>
    void WriteRaw(string content);

    /// <summary>
    /// Write tag.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    void WriteTag(string tagName);

    /// <summary>
    /// Write tag namespace manager.
    /// </summary>
    /// <param name="element">The element.</param>
    /// <param name="namespaceManager">The namespace manager.</param>
    /// <param name="namespaceUri">The namespace uri.</param>
    /// <param name="prefix">The prefix.</param>
    void WriteTagNamespaceManager(object element, XmlNamespaceManager namespaceManager, string namespaceUri, string prefix);

    /// <summary>
    /// Write tag namespace manager.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="namespaceManager">The namespace manager.</param>
    /// <param name="attributes">The attributes.</param>
    void WriteTagNamespaceManager(string tagName, XmlNamespaceManager namespaceManager, params string[] attributes);

    /// <summary>
    /// Write tag with 2 attrs.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="firstName">The first name.</param>
    /// <param name="firstValue">The first value.</param>
    /// <param name="secondName">The second name.</param>
    /// <param name="secondValue">The second value.</param>
    void WriteTagWith2Attrs(string tagName, string firstName, string firstValue, string secondName, string secondValue);

    /// <summary>
    /// Write tag with attr.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributeName">The attribute name.</param>
    /// <param name="attributeValue">The attribute value.</param>
    /// <param name="isSkippingEmptyOrNull">The is skipping empty or null.</param>
    void WriteTagWithAttr(string tagName, string attributeName, string attributeValue, bool isSkippingEmptyOrNull = false);

    /// <summary>
    /// Write tag with attrs.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes.</param>
    void WriteTagWithAttrs(string tagName, List<string> attributes);

    /// <summary>
    /// Write tag with attrs.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes.</param>
    void WriteTagWithAttrs(string tagName, params string[] attributes);

    /// <summary>
    /// Write tag with attrs check null.
    /// </summary>
    /// <param name="tagName">The tag name.</param>
    /// <param name="attributes">The attributes.</param>
    void WriteTagWithAttrsCheckNull(string tagName, params string[] attributes);

    /// <summary>
    /// Write xml declaration.
    /// </summary>
    void WriteXmlDeclaration();
}
