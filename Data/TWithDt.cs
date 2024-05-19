namespace
#if SunamoCompare
SunamoCompare
#else
SunamoInterfaces
#endif
;
public class TWithDt<T> : ITWithDt<T>
{
    public T t { get; set; } = default;
    public DateTime Dt { get; set; }
}