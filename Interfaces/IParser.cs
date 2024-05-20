namespace
#if SunamoData
SunamoData
#elif SunamoDateTime
SunamoDateTime
#elif SunamoGoogleSheets
SunamoGoogleSheets
#else
SunamoInterfaces
#endif
;
public interface IParser
{
    void Parse(string co);
}