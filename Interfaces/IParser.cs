namespace
#if SunamoData
SunamoData
#elif SunamoDateTime
SunamoDateTime
#else
SunamoInterfaces
#endif
;
public interface IParser
{
    void Parse(string co);
}