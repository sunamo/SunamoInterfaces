namespace
#if SunamoConverters
SunamoConverters
#else
SunamoInterfaces
#endif
;
public interface ISimpleConverter : ISimpleConverterT<string, string>
{
}