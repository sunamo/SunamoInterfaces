namespace
#if SunamoPS
SunamoPS
#elif SunamoShared
SunamoShared
#elif SunamoTextOutputGenerator
SunamoTextOutputGenerator
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface INpmBashBuilder
{
    void I(string args = null);
}
