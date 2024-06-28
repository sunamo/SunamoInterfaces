
namespace SunamoInterfaces;
public interface IStatusBroadcaster
{
    event Action<object, Object[]> NewStatus;
    void OnNewStatus(string s, params string[] p);
}
