namespace
#if SunamoCompare
SunamoCompare
#else SunamoInterfacesData
SunamoInterfacesData
#endif
;


public class TWithDt<T> : ITWithDt<T>
{
    public T t { get; set; } = default;
    public DateTime Dt { get; set; }
}
