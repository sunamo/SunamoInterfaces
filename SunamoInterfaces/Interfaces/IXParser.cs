namespace SunamoInterfaces.Interfaces;

/// <summary>
/// Represents the IX parser type.
/// </summary>
public interface IXParser
{
    /// <summary>
    /// Parse.
    /// </summary>
    /// <param name="element">The element.</param>
    void Parse(XElement element);

    /// <summary>
    /// To xml.
    /// </summary>
    /// <returns>The to xml result.</returns>
    string ToXml();
}
