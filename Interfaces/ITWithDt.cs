namespace
#if SunamoCompare
SunamoCompare
#else
SunamoInterfacesInterfaces
#endif
;

public interface ITWithDt<T>
{
    T t { get; set; }
    DateTime Dt { get; set; }
}
