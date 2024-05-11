namespace
#if SunamoFileSystem
SunamoFileSystem
#else
SunamoInterfaces
#endif
;

public interface ISelectFromMany<Data>
{
    void AddControl(Data data, bool b);
    void AddControls();
}
