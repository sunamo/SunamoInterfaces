namespace
#if SunamoConverters
SunamoConverters
#else
SunamoInterfaces
#endif
;
public interface IConvertNumberString
{
    int ToNumber(string s);
    string ToString(int number);
}