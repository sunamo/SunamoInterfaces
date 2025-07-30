namespace SunamoInterfaces.Interfaces;

public interface IXmlParser
{
    void Parse(XmlNode node);
    string ToXml();
}