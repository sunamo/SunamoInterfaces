namespace
#if SunamoConverters
SunamoConverters
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface IConvertCzechEnglish
{
    string ToCzech(string english);
    string ToEnglish(string czech);
}
