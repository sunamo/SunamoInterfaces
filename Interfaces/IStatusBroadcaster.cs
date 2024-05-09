namespace
#if SunamoCollectionsGeneric
SunamoCollectionsGeneric
#else
SunamoInterfacesInterfaces
#endif
;

public interface IStatusBroadcaster
{
    event Action<object, Object[]> NewStatus;
    void OnNewStatus(string s, params string[] p);
}