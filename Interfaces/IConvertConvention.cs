namespace
#if SunamoConverters
SunamoConverters
#else
SunamoInterfaces
#endif
;

public interface IConvertConvention
{
    string FromConvention(string p);
    string ToConvention(string p);
}
