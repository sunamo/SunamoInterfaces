namespace
#if SunamoCompare
SunamoCompare
#else
SunamoInterfaces
#endif
;

public interface ITWithDt<T>
{
    T t { get; set; }
    DateTime Dt { get; set; }
}
