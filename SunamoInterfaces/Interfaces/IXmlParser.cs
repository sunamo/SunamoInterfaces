namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing XML using XmlNode.
/// </summary>
public interface IXmlParser
{
    /// <summary>
    /// Parses the specified XML node.
    /// </summary>
    /// <param name="node">The XML node to parse.</param>
    void Parse(XmlNode node);

    /// <summary>
    /// Converts the parsed data to XML string.
    /// </summary>
    /// <returns>The XML string representation.</returns>
    string ToXml();
}