namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfaces
#endif
;
public interface ISelectedT<T>
{
    T SelectedItem { get; }
}