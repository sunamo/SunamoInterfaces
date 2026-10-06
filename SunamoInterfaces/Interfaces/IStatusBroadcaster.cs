namespace SunamoInterfaces.Interfaces;

public interface IStatusBroadcaster
{
    event Action<object, object[]> NewStatus;

    void OnNewStatus(string status, params string[] parameters);
}
