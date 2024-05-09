namespace
#if SunamoPS
SunamoPS
#else
SunamoInterfacesInterfacesSunamoPS
#endif
;

public interface IPowershellParser
{
    List<string> ParseToParts(string d, string charWhichIsNotContained);
}
