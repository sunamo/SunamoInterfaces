namespace SunamoInterfaces.Interfaces;

public interface IXParser
{
    void Parse(XElement element);

    string ToXml();
}
