namespace SunamoInterfaces.Interfaces;
public interface IStatusBroadcasterAppend : IStatusBroadcaster
{
    event Action<object, Object[]> NewStatusAppend;
    void OnNewStatusAppend(string s, params string[] p);
}
