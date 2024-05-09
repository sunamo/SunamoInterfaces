namespace
#if SunamoShared
SunamoShared
#else
SunamoInterfacesInterfaces
#endif
;

public interface ISelectedT<T>
{
    T SelectedItem { get; }
}
