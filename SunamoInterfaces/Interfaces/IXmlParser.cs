namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the i xml parser type.
/// </summary>
public interface IXmlParser
{
    /// <summary>
    /// Parse.
    /// </summary>
    /// <param name="node">The node.</param>
    void Parse(XmlNode node);

    /// <summary>
    /// To xml.
    /// </summary>
    /// <returns>The to xml result.</returns>
    string ToXml();
}
