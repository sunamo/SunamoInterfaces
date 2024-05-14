namespace
#if SunamoData
SunamoData
#else
SunamoInterfaces
#endif
;

public interface IParser
{
    void Parse(string co);
}