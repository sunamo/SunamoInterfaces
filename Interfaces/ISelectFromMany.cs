namespace
#if SunamoFileSystem
SunamoFileSystem
#else SunamoInterfacesInterfaces
SunamoInterfacesInterfaces
#endif
;

public interface ISelectFromMany<Data>
{
    void AddControl(Data data, bool b);
    void AddControls();
}
