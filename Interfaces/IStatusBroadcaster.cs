namespace
#if SunamoCollectionsGeneric
SunamoCollectionsGeneric
#else
SunamoInterfaces
#endif
;

public interface IStatusBroadcaster
{
    event Action<object, Object[]> NewStatus;
    void OnNewStatus(string s, params string[] p);
}