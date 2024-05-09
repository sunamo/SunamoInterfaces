namespace
#if SunamoConverters
SunamoConverters
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface IConvertConvention
{
    string FromConvention(string p);
    string ToConvention(string p);
}
