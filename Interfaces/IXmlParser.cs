namespace SunamoInterfaces.Interfaces;
using System.Xml;

public interface IXmlParser
{
    void Parse(XmlNode node);

    string ToXml();
}