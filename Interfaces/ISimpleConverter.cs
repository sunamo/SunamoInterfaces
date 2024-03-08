namespace SunamoInterfaces.Interfaces;

public interface ISimpleConverterT<TypeInClassName, U>
{
    TypeInClassName ConvertTo(U u);
    U ConvertFrom(TypeInClassName t);
}

public interface ISimpleConverter : ISimpleConverterT<string, string>
{
}
