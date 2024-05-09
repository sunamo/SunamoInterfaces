namespace
#if SunamoPS
SunamoPS
#else SunamoInterfacesInterfacesSunamoPS
SunamoInterfacesInterfacesSunamoPS
#endif
;

public interface IPowershellParser
{
    List<string> ParseToParts(string d, string charWhichIsNotContained);
}
