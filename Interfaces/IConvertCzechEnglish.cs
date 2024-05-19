namespace
#if SunamoConverters
SunamoConverters
#else
SunamoInterfaces
#endif
;
public interface IConvertCzechEnglish
{
    string ToCzech(string english);
    string ToEnglish(string czech);
}