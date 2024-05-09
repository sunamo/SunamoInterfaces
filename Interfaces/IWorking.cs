namespace
#if SunamoFtp
SunamoFtp
#else
SunamoInterfacesInterfaces
#endif
;

public interface IWorking
{
    bool IsWorking { get; }
}
