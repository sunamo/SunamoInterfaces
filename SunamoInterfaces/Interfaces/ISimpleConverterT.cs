namespace SunamoInterfaces.Interfaces;

public interface ISimpleConverterT<TypeInClassName, U>
{
    TypeInClassName ConvertTo(U sourceValue);

    U ConvertFrom(TypeInClassName targetValue);
}
