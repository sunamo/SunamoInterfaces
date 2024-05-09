namespace
#if SunamoFileSystem
SunamoFileSystem
#else
SunamoInterfacesInterfaces
#endif
;

public interface ISelectFromMany<Data>
{
    void AddControl(Data data, bool b);
    void AddControls();
}
