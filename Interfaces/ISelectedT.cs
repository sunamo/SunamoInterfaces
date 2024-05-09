namespace
#if SunamoShared
SunamoShared
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface ISelectedT<T>
{
    T SelectedItem { get; }
}
