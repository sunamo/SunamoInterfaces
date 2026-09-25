namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Interface for parsing XML using XElement (LINQ to XML).
/// </summary>
public interface IXParser
{
    /// <summary>
    /// Parses the specified XML element.
    /// </summary>
    /// <param name="element">The XML element to parse.</param>
    void Parse(XElement element);

    /// <summary>
    /// Converts the parsed data to XML string.
    /// </summary>
    /// <returns>The XML string representation.</returns>
    string ToXml();
}