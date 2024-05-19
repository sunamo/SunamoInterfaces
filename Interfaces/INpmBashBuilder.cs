namespace
#if SunamoPS
SunamoPS
#elif SunamoShared
SunamoShared
#elif SunamoTextOutputGenerator
SunamoTextOutputGenerator
#else
SunamoInterfaces
#endif
;
public interface INpmBashBuilder
{
    void I(string args = null);
}