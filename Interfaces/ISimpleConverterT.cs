
namespace
#if SunamoConverters
SunamoConverters
#else
SunamoInterfaces
#endif
;
public interface ISimpleConverterT<TypeInClassName, U>
{
    TypeInClassName ConvertTo(U u);
    U ConvertFrom(TypeInClassName t);
}