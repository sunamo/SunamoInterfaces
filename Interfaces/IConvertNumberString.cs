namespace
#if SunamoConverters
SunamoConverters
#else
SunamoInterfacesInterfaces
#endif
;

public interface IConvertNumberString
{
    int ToNumber(string s);
    string ToString(int number);
}
