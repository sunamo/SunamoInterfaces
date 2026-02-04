namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing XML using XElement (LINQ to XML).
/// </summary>
public interface IXParser
{
    /// <summary>
    /// Parses the specified XML element.
    /// </summary>
    /// <param name="node">The XML element to parse.</param>
    void Parse(XElement node);

    /// <summary>
    /// Converts the parsed data to XML string.
    /// </summary>
    /// <returns>The XML string representation.</returns>
    string ToXml();
}