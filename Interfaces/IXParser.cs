namespace SunamoInterfaces.Interfaces;
using System.Xml.Linq;

public interface IXParser
{
    void Parse(XElement node);
    string ToXml();
}