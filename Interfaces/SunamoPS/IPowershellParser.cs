namespace
#if SunamoPS
SunamoPS
#else
SunamoInterfaces
#endif
;

public interface IPowershellParser
{
    List<string> ParseToParts(string d, string charWhichIsNotContained);
}
