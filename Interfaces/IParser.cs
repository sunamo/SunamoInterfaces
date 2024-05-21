namespace
#if SunamoData
SunamoData
#elif SunamoDateTime
SunamoDateTime
#elif SunamoGoogleSheets
SunamoGoogleSheets
#elif SunamoGitBashBuilder
SunamoGitBashBuilder
#else
SunamoInterfaces
#endif
;
public interface IParser
{
    void Parse(string co);
}