namespace SunamoInterfaces;

public interface IXParser
{
    void Parse(XElement node);
    string ToXml();
}
