using System.Xml.Linq;

namespace SunamoInterfaces.Interfaces;

public interface IXParser
{
    void Parse(XElement node);
    string ToXml();
}